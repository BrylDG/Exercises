using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ParkNClick
{

    public partial class ParkoutForm : Form
    {
        private string server = "(localdb)\\MSSQLLocalDB";
        private string databaseName = "ParkingSystemDB";
        private string userName = "";
        private string password = "";
        public Boolean color { get; set; }
        public string plateNum { get; set; }
        public string VType { get; set; }
        public string VBrand { get; set; }
        string Slot { get; set; }
        Floor1 f1 = new Floor1();
        NewEditPanel editPanel = new NewEditPanel();
        DatabaseF dbFunctions = new DatabaseF();
        NewReceipt rp;

        public void status(Boolean status)
        {
            if (status == true)
            { this.Close(); }
            else return;
        }
        public ParkoutForm()
        {
            InitializeComponent();


        }

        //private void ParkoutForm_Load(object sender, EventArgs e)
        //{
        //    dbFunctions.ShowDetails(Slot);
        //    VDplate.Text = plateNum;
        //}

        public void UpdateDetails(string plateNumber, string vehicleType, string vehicleBrand, string vehicleTime)
        {
            editPanel.SetPlateNumber(plateNumber);
            VDplate.Text = plateNumber;
            VDtype.Text = vehicleType;
            VDbrand.Text = vehicleBrand;
            VDtime.Text = vehicleTime;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Park Out?", "Search Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                rp = new NewReceipt(VDplate.Text, VDtype.Text, VDbrand.Text, DateTime.Parse(VDtime.Text));
                rp.slot = this.Name;
                rp.Show();
                dbFunctions.UpdateTransaction(Slot);
                color = false;
                UpdateStatus(this.Name,"Vacant");
                this.Close();
                VDplate.Text = "";
                VDtype.Text = "";
                VDbrand.Text = "";
                VDtime.Text = "";
            }
        }
        public void UpdateStatus(string slot, string status)
        {
            string sqlQuery = @"UPDATE ParkingArea SET SlotStatus = @SlotStatus WHERE SlotsId = @SlotsId";
            using (SqlConnection connection = new SqlConnection($"Server={server};Database={databaseName};Uid={userName};Pwd={password}"))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@SlotsID", slot);
                    command.Parameters.AddWithValue("@SlotStatus", status);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Slot status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records found for the specified parking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating slot status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //public void UpdateDetails(object sender, EventArgs e)
        //{
        //    dbFunctions.ShowDetails(Slot);
        //}
        public void editButtonClicked(object sender, EventArgs e)
        {
            newEditPanel1.Visible = true; //EditPanel
            newEditPanel1.BringToFront();
        }

        public void EPVehicleDetails(object sender, EventArgs e)
        {
            newEditPanel1.slot = this.Name;
            newEditPanel1.editPPlateNumber.PlaceholderText = VDplate.Text;
            newEditPanel1.editPVehicleType.Text = VDtype.Text;
            newEditPanel1.editPVehicleBrand.Text = VDbrand.Text;
            newEditPanel1.SetPlateNumber(VDplate.Text);
        }

        public void SetSlotName(string buttonName)
        {
            Slot = buttonName;
        }

        private void ParkoutForm_Load(object sender, EventArgs e)
        {

        }
        //public void SetName(string buttonName)
        //{
        //    plateNum = buttonName;
        //}
        //public void Test(string buttonName)
        //{
        //    plate = buttonName;
        //}

        //public voi
    }
}
