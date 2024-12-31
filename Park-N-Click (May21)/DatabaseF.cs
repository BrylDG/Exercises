using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ParkNClick
{
    internal class DatabaseF
    {
        private string server = "(localdb)\\MSSQLLocalDB";
        private string databaseName = "ParkingSystemDB";
        private string userName = "";
        private string password = "";
        private string connectionString;
        private SqlConnection connection;
        private string Time;

        public Boolean status { get; set; } // Deletonon
        private void DatabaseConnection()
        {
            OpenConnection();
            CloseConnection();
        }

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

        //***************dbFunctions***********************


        //**************************CreateRecords********************************
        public void CreateUserRecord(string firstName, string middleInitial, string lastName, string userName, string password)
        {
            status = false;
            OpenConnection();

            try
            {


                if (IsUserNameExist(userName))
                {
                    MessageBox.Show("Username already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = true;
                    return;
                }

                string query = "INSERT INTO Users ([FirstName], [MiddleInitial], [LastName], [UserName], [Password]) " +
                               "VALUES (@firstName, @middleInitial, @lastName,@userName,@password )";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@middleInitial", middleInitial);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@userName", userName);
                command.Parameters.AddWithValue("@password", password);


                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to add record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }
        private void CreateUserLog(string userName) // Gi pansak rani nako sa IsLoginSuccessFull
        {
            try
            {
                OpenConnection();

                // Insert query for UserLogs table
                string query = "INSERT INTO UserLogs (UserName, UserLogIn) " +
                               "SELECT @UserName, @UserLogInDate FROM Users WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@UserLogInDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error logging user login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool IsLoginSuccessFull(string userName, string password)
        {
            bool loginSuccessful = false;
            OpenConnection();
            try
            {
                string query = "SELECT 1 FROM Users WHERE UserName=@UserName AND Password=@Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Login successful, no need to fetch user details
                        loginSuccessful = true;

                        // Log the user login in UserLogs table
                        CreateUserLog(userName);
                    }
                }

                return loginSuccessful;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if an exception occurs
            }
            finally
            {
                CloseConnection();
            }
        }
        public void CreateVehicleRecord(string plateNumber, string vehicleType, string vehicleBrand)
        {
            status = false;
            OpenConnection();
            try
            {
                if (IsPlateNumberExist(plateNumber))
                {
                    MessageBox.Show("PlateNumber already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = true;
                    return;
                }


                string query = "INSERT INTO Vehicles([PlateNumber], [VehicleType], [VehicleBrand]) " +
                              "VALUES (@PlateNumber, @VehicleType, @VehicleBrand)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlateNumber", plateNumber);
                command.Parameters.AddWithValue("@VehicleType", vehicleType);
                command.Parameters.AddWithValue("@vehicleBrand", vehicleBrand);

                int rowsAffected = command.ExecuteNonQuery();
                status = true;
                if (rowsAffected <= 0)
                {
                    MessageBox.Show("Failed to park in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("ParkIn successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void CreateTransactionRecords(string PlateNumber, string slot)
        {
            string userId = GetUserID();
            DateTime dateTime = DateTime.Now;
            OpenConnection();
            try
            {


                string query = "INSERT INTO [Transaction] ([UserID], [PlateNumber], [Slots],[ParkIn]) " +
                          "VALUES (@UserId, @PlateNumber, @slot,@ParkIn)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@PlateNumber", PlateNumber);
                    command.Parameters.AddWithValue("@slot", slot);
                    command.Parameters.AddWithValue("@ParkIn", dateTime);
                    Time = dateTime.ToString();

                    int rowsAffected = command.ExecuteNonQuery();
                    status = true;
                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Failed to park in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("ParkIn successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private string GetUserID()
        {
            OpenConnection();
            string userId = "";
            try
            {

                string query = "SELECT TOP 1 UserLogNo FROM UserLogs ORDER BY UserLogIn DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userId = result.ToString();
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
            return userId;
        }

        public void ShowDetails(string slots)
        {
            string plateNumber = "";
            string type = "";
            string brand = "";
            string time = "";

            //Using TransactionID to determine the latest entry
            //command.Parameters.AddWithValue("@ParkingSlot", slot);
            OpenConnection();
            try
            {
                string query = @"SELECT v.PlateNumber, v.VehicleType, v.VehicleBrand, t.ParkIn
                                FROM [Transaction] t
                                INNER JOIN
                                Vehicles v ON t.PlateNumber = v.PlateNumber
                                WHERE t.Slots = @slots";
                                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@slots", slots);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            plateNumber = reader["PlateNumber"].ToString();
                            type = reader["VehicleType"].ToString();
                            brand = reader["VehicleBrand"].ToString();
                            time = reader["ParkIn"].ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            ParkoutForm parkout = new ParkoutForm();
            parkout.Name = slots;
            parkout.UpdateDetails(plateNumber, type, brand, time);
            parkout.SetSlotName(slots);
            parkout.Show();
           
        }

        public void OccupySlot(string parkingSlot, string status)
        {
            OpenConnection();
            try
            {
                string query = "UPDATE ParkingArea SET SlotStatus = @Status WHERE SlotsId = @Slot";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Slot", parkingSlot);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        public string GetSlotStatus(string slotId)
        {
            OpenConnection();
            string result = "";


            try
            {
                // Ensure the connection is open
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "SELECT SlotStatus FROM ParkingArea WHERE SlotsId = @SlotId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SlotId", slotId);
                    result = cmd.ExecuteScalar()?.ToString();
                }
            }
            catch (SqlException sqlEx)
            {
                // Log specific SQL exceptions here
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Log general exceptions here
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public void UpdateTransaction(string slot)
        {
            string transactionType = "Park Out";
            string paymentStatus = "Paid";

            OpenConnection();
            try
            {
                string query = @"UPDATE [Transaction] SET [TransactionType] = @transactionType, [PaymentStatus] = @paymentStatus, [ParkOut] = @parkOut WHERE [Slots] = @slot";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@slot", slot);
                    cmd.Parameters.AddWithValue("@transactionType", transactionType);
                    cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus);
                    cmd.Parameters.AddWithValue("@parkOut", DateTime.Now);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Failed to update transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Transaction successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool CheckTransaction(string plateNo)
        {
            OpenConnection();
            try
            {
                string query = @"
                     SELECT  [TransactionType]
                     FROM [Transaction]
                     WHERE PlateNumber = @VehiclePlateNumber ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VehiclePlateNumber", plateNo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string latestTransactionType = reader["TransactionType"].ToString();

                            if (latestTransactionType == "Park In")
                            {
                                return false;
                            }
                            else if (latestTransactionType == "Park Out")
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }

        public void LoadParkingStatus(Button[] buttons)
        {
            OpenConnection();
            try
            {
                string query = "SELECT SlotsId, SlotStatus FROM ParkingArea";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string slotId = reader["SlotsId"].ToString();
                            string slotStatus = reader["SlotStatus"].ToString();
                            Button button = buttons.FirstOrDefault(b => b.Name == $"{slotId}");

                            if (button != null)
                            {
                                button.BackColor = slotStatus == "Occupied" ? Color.Brown : Color.SeaGreen;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }//I loads for the status of Area

        public void ShowUserLogsRecord(DataGridView userLogsTable)
        {
            OpenConnection();
            try
            {
                string query = "SELECT * FROM UserLogs";
                SqlCommand command = new SqlCommand(query, connection);
                ViewRecordsCommand(userLogsTable, command);
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

        public void SelectedData(string plateNumber, TextBox plateN, ComboBox vehicleT, ComboBox vehicleB)
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

                    plateN.Text = plateNumber;
                    vehicleT.Text = vehicleType;
                    vehicleB.Text = vehicleBrand;
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
        private bool IsUserNameExist(string userName)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE [UserName] = @userName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userName", userName);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }

        private bool IsPlateNumberExist(string plateNumber)
        {
            string query = "SELECT COUNT(*) FROM Vehicles WHERE [PLateNumber] = @PlateNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PlateNumber", plateNumber);

            int count = (int)command.ExecuteScalar();
            return count > 0;
        }
        



        //public void UpdateRecords(int id, string plateNumber, string vehicleType, string vehicleBrand)
        //{
        //    OpenConnection();
        //    try
        //    {
        //        string query = "UPDATE Vehicle SET [Plate Number] = @PlateNumber, [Vehicle Type] = @VehicleType, [Vehicle Brand] = @VehicleBrand " +
        //                       "WHERE [Id] = @Id";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@Id", id); // Make sure to include the id parameter
        //        command.Parameters.AddWithValue("@PlateNumber", plateNumber);
        //        command.Parameters.AddWithValue("@VehicleType", vehicleType);
        //        command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
        //        int rowsAffected = command.ExecuteNonQuery();

        //        if (rowsAffected <= 0)
        //        {
        //            MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}

        //public void DeleteRecord(int id)
        //{
        //    OpenConnection();
        //    try
        //    {

        //        string deleteQuery = "DELETE FROM Vehicle WHERE [Id] = @Id";
        //        SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
        //        deleteCommand.Parameters.AddWithValue("Id", id);
        //        deleteCommand.ExecuteNonQuery();

        //        // Reset the identity seed if the table is empty
        //        string resetIdentityQuery = "IF NOT EXISTS (SELECT * FROM Vehicle) DBCC CHECKIDENT('Vehicle', RESEED, 0)";
        //        SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);
        //        resetIdentityCommand.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}
        //public void SearchRecord(DataGridView dataGridView, int id, string plateNumber)
        //{
        //    OpenConnection();
        //    try
        //    {
        //        string query = "SELECT [ID], [Plate Number] FROM Vehicle WHERE (@Id = -1 OR [ID] = @Id) AND CONVERT(NVARCHAR(MAX), [Plate Number]) LIKE @PlateNumber";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@Id", id);
        //        command.Parameters.AddWithValue("@PlateNumber", "%" + plateNumber + "%");

        //        ViewRecordsCommand(dataGridView, command);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}

    }
}
