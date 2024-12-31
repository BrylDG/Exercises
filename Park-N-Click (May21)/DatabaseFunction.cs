using Microsoft.Data.SqlClient;
using ParkNClick;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WinFormsApp1
{
    internal class DatabaseFunctions
    {
        private string server = "(localdb)\\ProjectModels";
        private string databaseName = "ParkingSystemDB";
        private string userName = "";
        private string password = "";
        private string connectionString;
        private SqlConnection connection;
        public Boolean status { get; set; }

        private void DatabaseConnection()
        {
            OpenConnection();
            CloseConnection();
        }
        private string ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private void OpenConnection()
        {
            connectionString = $"Server={server};Database={databaseName};Uid={userName};Pwd={password}";
            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to MySQL Server: " + ex.Message);
            }
        }

        private void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
                Console.WriteLine("Connection to MySQL Server closed.");
            }
        }

        public void AddHistory(string slot, string PNum, DateTime parkIn)
        {
            OpenConnection();
            string query = @"INSERT INTO ParkingHistory (ParkingSlot, PlateNumber, ParkIn, Duration)
                            VALUES (@ParkingSlot, @PlateNumber, @ParkIn, @Duration)";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ParkingSlot", slot);
                    command.Parameters.AddWithValue("@PlateNumber", PNum);
                    command.Parameters.AddWithValue("@ParkIn", parkIn);
                    command.Parameters.AddWithValue("@Duration", 0);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        public void AddHistory2(DateTime time, int duration, string slot, string PlateNum)
        {
            OpenConnection();
            string query = @"UPDATE ParkingHistory 
                            SET Parkout = @ParkOut, Duration = @Duration
                            WHERE ParkingSlot = @ParkingSlot AND PlateNumber = @PlateNumber";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ParkOut", time);
                    command.Parameters.AddWithValue("@Duration", duration);
                    command.Parameters.AddWithValue("ParkingSlot", slot);
                    command.Parameters.AddWithValue("@PlateNumber", PlateNum);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void UpdateTransactionCount()
        {
            OpenConnection();
            try
            {
                string selectQuery = @"SELECT TOP 1 UserLogNo FROM UserLogs ORDER BY UserLogNo DESC";
                int latestUserLogNo = -1;
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            latestUserLogNo = Convert.ToInt32(reader["UserLogNo"]);
                        }
                    }
                }
                if (latestUserLogNo == -1)
                {
                    MessageBox.Show("No user log found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string selectTransactionsQuery = @"SELECT Transactions FROM UserLogs WHERE UserLogNo = @UserLogNo";
                int currentTransactions = 0;

                using (SqlCommand selectTransactionsCommand = new SqlCommand(selectTransactionsQuery, connection))
                {
                    selectTransactionsCommand.Parameters.AddWithValue("@UserLogNo", latestUserLogNo);

                    using (SqlDataReader reader = selectTransactionsCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            currentTransactions = Convert.ToInt32(reader["Transactions"]);
                        }
                    }
                }
                int newTransactions = currentTransactions + 1;
                string updateQuery = @"UPDATE UserLogs SET Transactions = @Transactions WHERE UserLogNo = @UserLogNo";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@Transactions", newTransactions);
                    updateCommand.Parameters.AddWithValue("@UserLogNo", latestUserLogNo);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Transaction count updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update transaction count.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }


        public void LogOut()
        {
            OpenConnection();
            try
            {
                string selectQuery = @"SELECT TOP 1 UserLogNo FROM UserLogs ORDER BY UserLogNo DESC";
                int latestUserLogNo = -1;
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            latestUserLogNo = Convert.ToInt32(reader["UserLogNo"]);
                        }
                    }
                }

                string updateQuery = @"UPDATE UserLogs SET UserLogoutDate = @UserLogoutDate WHERE UserLogNo = @UserLogNo";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@UserLogoutDate", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@UserLogNo", latestUserLogNo);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error logging out: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        


        public void CreateRecord(string plateNumber, string vehicleType, string vehicleBrand)
        {
            status = false;
            OpenConnection();
            try
            {
                if (PlateNumberExists(plateNumber))
                {
                    status = true;
                    return;
                }

                string query = "INSERT INTO VehicleData ([VehiclePlateNumber], [VehicleType], [VehicleBrand]) " +
                               "VALUES (@PlateNumber, @VehicleType, @VehicleBrand)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);

                int rowsAffected = command.ExecuteNonQuery();
                status = true;

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    status = true;
                    return;
                }
                else
                {
                    MessageBox.Show("Error adding records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdateRecords(int id, string plateNumber, string vehicleType, string vehicleBrand)
        {
            OpenConnection();
            try
            {
                if (PlateNumberExists(plateNumber))
                {
                    MessageBox.Show("Plate number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE Vehicle SET [Plate Number] = @PlateNumber, [Vehicle Type] = @VehicleType, [Vehicle Brand] = @VehicleBrand " +
                               "WHERE [Id] = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void NewUpdateRecords(string slot, string plateNumber, string vehicleType, string vehicleBrand)
        {
            OpenConnection();
            try
            {
                if (PlateNumberExists(plateNumber))
                {
                    MessageBox.Show("Plate number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "UPDATE  SET [Plate Number] = @PlateNumber, [Vehicle Type] = @VehicleType, [Vehicle Brand] = @VehicleBrand " +
                               "WHERE [Slot] = @Slot";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void DeleteRecord(int id)
        {
            OpenConnection();
            try
            {
                string deleteQuery = "DELETE FROM Vehicle WHERE [Id] = @Id";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("Id", id);
                deleteCommand.ExecuteNonQuery();

                string resetIdentityQuery = "IF NOT EXISTS (SELECT * FROM Vehicle) DBCC CHECKIDENT('Vehicle', RESEED, 0)";
                SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);
                resetIdentityCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void SearchRecord(DataGridView dataGridView, int id, string plateNumber)
        {
            OpenConnection();
            try
            {
                string query = "SELECT [ID], [Plate Number] FROM Vehicle WHERE (@Id = -1 OR [ID] = @Id) AND CONVERT(NVARCHAR(MAX), [Plate Number]) LIKE @PlateNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@PlateNumber", "%" + plateNumber + "%");

                ViewRecordsCommand(dataGridView, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void SearchLogs(DataGridView dataGridView, int userId, string userUsername)
        {
            OpenConnection();
            try
            {
                string query = @"
            SELECT UL.UserLogNo, UL.UserID, UL.UserUsername, UL.UserLoginDate
            FROM UserLogs UL
            INNER JOIN Users U ON UL.UserID = U.UserID
            WHERE (@UserId = -1 OR UL.UserID = @UserId) 
            AND CONVERT(NVARCHAR(MAX), UL.UserUsername) LIKE @UserUsername";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@UserUsername", "%" + userUsername + "%");

                ViewRecordsCommand(dataGridView, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }



        private void ViewRecordsCommand(DataGridView dataGridView, SqlCommand command)
        {

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void SelectedData(string plateNumber, Label plateN, Label vehicleT, Label vehicleB, Label Date)
        {
            OpenConnection();
            try
            {
                string query = "SELECT * FROM Vehicle WHERE [Plate Number] = @PlateNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    plateNumber = reader["Plate Number"].ToString();
                    string vehicleType = reader["Vehicle Type"].ToString();
                    string vehicleBrand = reader["Vehicle Brand"].ToString();
                    string vehicleDate = reader["Vehicle Date"].ToString();

                    plateN.Text = plateNumber;
                    vehicleT.Text = vehicleType;
                    vehicleB.Text = vehicleBrand;
                    Date.Text = vehicleDate;


                }
                else
                {
                    MessageBox.Show("No data found for the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void SelectedData1(string plateNumber, Label plateN, Label vehicleT, Label vehicleB, Label Date)
        {
            OpenConnection();
            try
            {
                string query = "SELECT * FROM Vehicle WHERE [Plate Number] = @PlateNumber";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    plateNumber = reader["Plate Number"].ToString();
                    string vehicleType = reader["Vehicle Type"].ToString();
                    string vehicleBrand = reader["Vehicle Brand"].ToString();
                    string vehicleDate = reader["Vehicle Date"].ToString();

                    plateN.Text = plateNumber;
                    vehicleT.Text = vehicleType;
                    vehicleB.Text = vehicleBrand;
                    Date.Text = vehicleDate;
                }
                else
                {
                    MessageBox.Show("No data found for the selected ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void ViewRecords(DataGridView dataView)
        {
            OpenConnection();
            try
            {
                string query = $"SELECT [ID], [Plate Number] From Vehicle";
                SqlCommand command = new SqlCommand(query, connection);
                ViewRecordsCommand(dataView, command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading data: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
        private bool PlateNumberExists(string plateNumber)
        {
            string query = "SELECT COUNT(*) FROM Vehicle WHERE [Plate Number] = @PlateNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlateNumber", plateNumber);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
        public void ViewLogs(DataGridView dataGridView)
        {
            string query = "SELECT * FROM UserLogs";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        dataGridView.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
