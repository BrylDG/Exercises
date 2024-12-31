using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using System.Drawing.Text;
using System.Numerics;



namespace ParkNClick
{
    public partial class Dashboard : Form
    {
        public event EventHandler Clicked;
        VehicleData VD;
        Login loginForm;
        DetailPanel dp = new DetailPanel();
        EditPanel ED;
        DatabaseFunctions database = new DatabaseFunctions();
        AdminDashboard ADB;
        Receipt rp;

        private string plateNumber, vehicleType, vehicleBrand, vehicleTime;
        int id;

        public Dashboard(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            //this.detailPanel = detailPanel;
            //DP = detailPanel;
            DisplayRecords();
            ShowDetails();
            //SetRoundedEdges(DetailPanel);
            //SetRoundedEdges(DatabasePanel);
            //SetRoundedEdges(ParkInPanel);
            //SetRoundedEdges(FlagdownPanel);
            //SetRoundedEdges(TypePanel);
            //SetRoundedEdges(RatePanel);

        }



        private void ResetLabel(Label label)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (sender, e) =>
            {
                label.Text = "";
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
        private void add()
        {
            if (TypeCB.Text == "Motorbike")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Kawasaki");
                BrandCB.Items.Add("Suzuki");
                BrandCB.Items.Add("Honda");
                BrandCB.Items.Add("Russi");
            }
            else if (TypeCB.Text == "SUV")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Kia");
                BrandCB.Items.Add("Toyota");
                BrandCB.Items.Add("Ford");
                BrandCB.Items.Add("Hyundai");
                BrandCB.Items.Add("Mitsubishi");
                BrandCB.Items.Add("Isuzu");
            }
            else if (TypeCB.Text == "Sedan")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Volkswagen");
                BrandCB.Items.Add("Toyota");
                BrandCB.Items.Add("Ford");
                BrandCB.Items.Add("Hyundai");
                BrandCB.Items.Add("Mitsubishi");
                BrandCB.Items.Add("Nissan");
            }
            else if (TypeCB.Text == "Van")
            {
                BrandCB.Text = "";
                BrandCB.Items.Clear();
                BrandCB.Items.Add("Toyota");
                BrandCB.Items.Add("Nissan");
                BrandCB.Items.Add("Hyundai");
                BrandCB.Items.Add("Ford");
                BrandCB.Items.Add("Kia");
            }
        }
        private void addEdit()
        {
            if (TypeDB.Text == "Motorbike")
            {
                BrandDB.Text = "";
                BrandDB.Items.Clear();
                BrandDB.Items.Add("Kawasaki");
                BrandDB.Items.Add("Suzuki");
                BrandDB.Items.Add("Honda");
                BrandDB.Items.Add("Russi");
            }
            else if (TypeDB.Text == "SUV")
            {
                BrandDB.Text = "";
                BrandDB.Items.Clear();
                BrandDB.Items.Add("Kia");
                BrandDB.Items.Add("Toyota");
                BrandDB.Items.Add("Ford");
                BrandDB.Items.Add("Hyundai");
                BrandDB.Items.Add("Mitsubishi");
                BrandDB.Items.Add("Isuzu");
            }
            else if (TypeDB.Text == "Sedan")
            {
                BrandDB.Text = "";
                BrandDB.Items.Clear();
                BrandDB.Items.Add("Volkswagen");
                BrandDB.Items.Add("Toyota");
                BrandDB.Items.Add("Ford");
                BrandDB.Items.Add("Hyundai");
                BrandDB.Items.Add("Mitsubishi");
                BrandDB.Items.Add("Nissan");
            }
            else if (TypeDB.Text == "Van")
            {
                BrandDB.Text = "";
                BrandDB.Items.Clear();
                BrandDB.Items.Add("Toyota");
                BrandDB.Items.Add("Nissan");
                BrandDB.Items.Add("Hyundai");
                BrandDB.Items.Add("Ford");
                BrandDB.Items.Add("Kia");
            }
        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            add();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrandCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddData();
            TypeCB.Text = "";
            BrandCB.Text = "";
            PlateNoBox.Text = "";

            //    //AYAW LNG SANI HILABTI NAA RAKOI G ADD BAGO NA CODE NA SAME UG FUNCTION ANI

            //    brand = comboBox1.Text;
            //     PlateNumber = textBox1.Text;
            //     VD.Details.Add(new VehicleData(number, type, timeIn.ToString(), PlateNumber, brand));
            //     DetailPanel detailPanel = new DetailPanel(VD.Details, number);
            //     number++;
            //     detailPanel.Location = new System.Drawing.Point(nextPanelX, nextPanelY);
            //     detailPanel.PanelRemoved += DetailPanel_PanelRemoved;
            //     this.Controls.Add(detailPanel);
            //     detailPanel.BringToFront();
            //     sidePanelRight1.flowLayoutPanel1.Controls.Add(detailPanel);
            //     panels.Add(detailPanel);
            //     nextPanelY = panels.Count > 0 ? panels.Last().Bottom : nextPanelY;
            //     detailPanel.VerticalScroll.Value = detailPanel.VerticalScroll.Maximum;
            //     comboBox1.Text = "";
            //     textBox1.Text = "";
            //     FlagDownLabel.Text = "";
            //     RateLabel.Text = "";
            //     label4.Text = "";
            //     ErrorMessageLabel.Text = "";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.UsernameBox.Text = "";
            loginForm.PasswordBox.Text = "";
            loginForm.Show();
        }

        private void DetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("hh:mm tt");
        }
        private void DashboardMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }



        private void DashboardMenu_Load_1(object sender, EventArgs e)
        {
            PlateTB.Hide();
            BrandDB.Hide();
            TypeDB.Hide();
            DoneButton.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ViewTimeIn_Click(object sender, EventArgs e)
        {

        }

        private void VBrand_Click(object sender, EventArgs e)
        {

        }



        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Low level functions
        private void AddData()
        {
            if (TypeCB.Text == "" || BrandCB.Text == "" || PlateNoBox.Text == "")
            {
                MessageBox.Show("Missing input  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddRecord();
                DisplayRecords();
            }
        }
        private void DisplayRecords()
        {
            database.ViewRecords(dataTable);
        }
        private void AddRecord()
        {
            DataValues(out plateNumber, out vehicleType, out vehicleBrand);
            database.CreateRecord(plateNumber, vehicleType, vehicleBrand);
        }
        private void UpdateRecords()
        {
            DataValuesEdit(out plateNumber, out vehicleType, out vehicleBrand);
            database.UpdateRecords(id, plateNumber, vehicleType, vehicleBrand);
        }

        private void DataValuesEdit(out string plateNumber, out string vehicleType, out string vehicleBrand)
        {
            plateNumber = PlateTB.Text;
            vehicleType = TypeDB.Text;
            vehicleBrand = BrandDB.Text;
        }
        private void DataValues(out string plateNumber, out string vehicleType, out string vehicleBrand)
        {
            plateNumber = PlateNoBox.Text;
            vehicleType = TypeCB.Text;
            vehicleBrand = BrandCB.Text;
        }

        private void DeleteRecords()
        {
            plateNumber = PlateNoBox.Text;
            database.DeleteRecord(id);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchBox.Text.Trim();

            if (int.TryParse(searchText, out id))
            {
                database.SearchRecord(dataTable, id, "");

            }
            else
            {
                database.SearchRecord(dataTable, -1, searchText);
            }
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataTable.Rows[e.RowIndex];
                object idCellValue = selectedRow.Cells["Id"].Value;

                int.TryParse(idCellValue.ToString(), out id);

                plateNumber = selectedRow.Cells["Plate Number"].Value.ToString();
                database.SelectedData(plateNumber, VDplate, VDtype, VDbrand, VDtime);
            }


        }
        private void ShowDetails()
        {
            dp.UpdateDetails(dp.VDplate.Text, dp.VDtype.Text, dp.VDbrand.Text, dp.VDtime.Text);
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            UpdateRecords();
            DisplayRecords();
            PlateTB.Hide();
            BrandDB.Hide();
            TypeDB.Hide();
            DoneButton.Hide();
            button3.Show();
            button2.Show();
            VDtime.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlateTB.Text = "";
            PlateTB.Show();
            BrandDB.Show();
            TypeDB.Show();
            DoneButton.Show();
            VDplate.Text = "";
            VDbrand.Text = "";
            VDtype.Text = "";
            PlateTB.Text = dp.VDplate.Text;
            TypeDB.Text = dp.VDtype.Text;
            BrandDB.Text = dp.VDbrand.Text;
            button3.Hide();
            button2.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Park Out?", "Search Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                rp = new Receipt(VDplate.Text, VDtype.Text, VDbrand.Text, DateTime.Parse(VDtime.Text));
                rp.Show();
                DeleteRecords();
                DisplayRecords();
                VDplate.Text = "";
                VDtype.Text = "";
                VDbrand.Text = "";
                VDtime.Text = "";
            }
        }

        private void TypeDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            addEdit();
        }

        private void UserLogsLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADB.Show();
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PlateTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrandDB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void vehicleTimeInPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
