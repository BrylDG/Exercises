using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ParkNClick
{
    public partial class NewEditPanel : UserControl
    {
        DatabaseFunctions db = new DatabaseFunctions();
        public string slot { get; set; }
        string PlateNumber { get; set; }
        public NewEditPanel()
        {
            InitializeComponent();
        }

        private void Edit_PanelButtons(object sender, EventArgs e)
        {
            EditRecord( editPVehicleType.Text, editPVehicleBrand.Text);
            this.Visible = false;
        }

        private void EPTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addBrand();
        }
        private void addBrand()
        {
            if (editPVehicleType.Text == "Motorbike")
            {
                editPVehicleBrand.Text = "";
                editPVehicleBrand.Items.Clear();
                editPVehicleBrand.Items.Add("Kawasaki");
                editPVehicleBrand.Items.Add("Suzuki");
                editPVehicleBrand.Items.Add("Honda");
                editPVehicleBrand.Items.Add("Russi");
            }
            else if (editPVehicleType.Text == "SUV")
            {
                editPVehicleBrand.Text = "";
                editPVehicleBrand.Items.Clear();
                editPVehicleBrand.Items.Add("Kia");
                editPVehicleBrand.Items.Add("Toyota");
                editPVehicleBrand.Items.Add("Ford");
                editPVehicleBrand.Items.Add("Hyundai");
                editPVehicleBrand.Items.Add("Mitsubishi");
                editPVehicleBrand.Items.Add("Isuzu");
            }
            else if (editPVehicleType.Text == "Sedan")
            {
                editPVehicleBrand.Text = "";
                editPVehicleBrand.Items.Clear();
                editPVehicleBrand.Items.Add("Volkswagen");
                editPVehicleBrand.Items.Add("Toyota");
                editPVehicleBrand.Items.Add("Ford");
                editPVehicleBrand.Items.Add("Hyundai");
                editPVehicleBrand.Items.Add("Mitsubishi");
                editPVehicleBrand.Items.Add("Nissan");
            }
            else if (editPVehicleType.Text == "Van")
            {
                editPVehicleBrand.Text = "";
                editPVehicleBrand.Items.Clear();
                editPVehicleBrand.Items.Add("Toyota");
                editPVehicleBrand.Items.Add("Nissan");
                editPVehicleBrand.Items.Add("Hyundai");
                editPVehicleBrand.Items.Add("Ford");
                editPVehicleBrand.Items.Add("Kia");
            }
        }
        private void EditRecord(string vehicleType, string vehicleBrand)
        {
            if (editPVehicleType.Text == "" || editPVehicleBrand.Text == "" )
            {
                MessageBox.Show("Error: Parking slot information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //details(TType, GetUsername(), slot, plateNo, vehicleType, vehicleBrand, DateTime.Now, Status);

            }
        }
        public string GetUsername()
        {
            string lastUsername = null;
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True";
            string query = "SELECT TOP 1 UserUsername FROM UserLogs ORDER BY UserLoginDate DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            lastUsername = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching last username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return lastUsername;
        }

        public void details(string transactionType, string transactionUser, string slot, string plateNo, string vehicleType, string vehicleBrand, DateTime time, string status)
        {
            string sqlQuery = @"INSERT INTO TransactionTable (TransactionType, TransactionUser, ParkingSlot, VehiclePlateNumber, VehicleType, VehicleBrand, ParkInParkOut, PaymentStatus)
                        VALUES (@TransactionType, @TransactionUser, @ParkingSlot, @VehiclePlateNumber, @VehicleType, @VehicleBrand, @ParkInParkOut, @PaymentStatus)";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@TransactionType", transactionType);
                    command.Parameters.AddWithValue("@TransactionUser", transactionUser);
                    command.Parameters.AddWithValue("@ParkingSlot", slot);
                    command.Parameters.AddWithValue("@VehiclePlateNumber", plateNo);
                    command.Parameters.AddWithValue("@VehicleType", vehicleType);
                    command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
                    command.Parameters.AddWithValue("@ParkInParkOut", time);
                    command.Parameters.AddWithValue("@PaymentStatus", status);

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

        public void SetPlateNumber(string plateNumber) 
        {
            PlateNumber = plateNumber;
        }

        //private void NewEditPanel_Load(object sender, EventArgs e)
        //{

        //}

    }
}
