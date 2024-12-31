using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ParkNClick
{
    public partial class ParkInForm : Form
{

        DatabaseF dbFunctions = new DatabaseF();
        string plateNumber, type, brand;
        Floor1 floor1 = new Floor1();
        public Boolean color { get; set; }
        public string plateNo { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        string Slot { get; set; }
        public void status(Boolean status)
        {
            if (status == true)
            { 
                this.Close(); 
            }
            else return;
        }
        public ParkInForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ParkInForm_Load(object sender, EventArgs e)
        {

        }

        private void ParkInButton_Click(object sender, EventArgs e)
        {
            if (dbFunctions.CheckTransaction(PlateBox.Text) == false)
            {
                AddVehicleRecords();
                PlateBox.Text = "";
                TypeBox.SelectedIndex = -1;
                BrandBox.SelectedIndex = -1;
                RateBox.Text = "";
                FlagDownBox.Text = "";
            }
            else MessageBox.Show("Vehicle already parked in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void AddVehicleRecords()
        {
            if (TypeBox.Text == "" || BrandBox.Text == "" || PlateBox.Text == "")
            {
                MessageBox.Show("Missing input", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string slot = Slot;
                dbFunctions.CreateVehicleRecord(PlateBox.Text, TypeBox.Text, BrandBox.Text);
                color = true;
                dbFunctions.CreateTransactionRecords(PlateBox.Text, slot);
                status(dbFunctions.status);
            }
        }
        private void addBrand()
        {
            if (TypeBox.Text == "Motorbike")
            {
                BrandBox.Text = "";
                BrandBox.Items.Clear();
                BrandBox.Items.Add("Kawasaki");
                BrandBox.Items.Add("Suzuki");
                BrandBox.Items.Add("Honda");
                BrandBox.Items.Add("Russi");
            }
            else if (TypeBox.Text == "SUV")
            {
                BrandBox.Text = "";
                BrandBox.Items.Clear();
                BrandBox.Items.Add("Kia");
                BrandBox.Items.Add("Toyota");
                BrandBox.Items.Add("Ford");
                BrandBox.Items.Add("Hyundai");
                BrandBox.Items.Add("Mitsubishi");
                BrandBox.Items.Add("Isuzu");
            }
            else if (TypeBox.Text == "Sedan")
            {
                BrandBox.Text = "";
                BrandBox.Items.Clear();
                BrandBox.Items.Add("Volkswagen");
                BrandBox.Items.Add("Toyota");
                BrandBox.Items.Add("Ford");
                BrandBox.Items.Add("Hyundai");
                BrandBox.Items.Add("Mitsubishi");
                BrandBox.Items.Add("Nissan");
            }
            else if (TypeBox.Text == "Van")
            {
                BrandBox.Text = "";
                BrandBox.Items.Clear();
                BrandBox.Items.Add("Toyota");
                BrandBox.Items.Add("Nissan");
                BrandBox.Items.Add("Hyundai");
                BrandBox.Items.Add("Ford");
                BrandBox.Items.Add("Kia");
            }
        }
        private void addRFD()
        {
            if (TypeBox.Text == "Motorbike")
            {
                RateBox.Text = "5.00";
                FlagDownBox.Text = "20.00";
            }
            else if (TypeBox.Text == "SUV")
            {
                RateBox.Text = "20.00";
                FlagDownBox.Text = "40.00";
            }
            else if (TypeBox.Text == "Sedan")
            {
                RateBox.Text = "15.00";
                FlagDownBox.Text = "30.00";
            }
            else if (TypeBox.Text == "Van")
            {
                RateBox.Text = "20.00";
                FlagDownBox.Text = "40.00";
            }
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addBrand();
            addRFD();
        }

        public void SetSlotName(string buttonName) 
        {
            Slot = buttonName;
        }
    }
}
