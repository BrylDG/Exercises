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
    public partial class AdminDashboard : Form
    {
        VehicleData VD;
        Login loginForm;
        DetailPanel DP;
        DatabaseFunctions database = new DatabaseFunctions();
        AdminDB AdminDB;
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        int id;

        public AdminDashboard(Login loginForm, AdminDB adminDB)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.AdminDB = adminDB;

            //DP = new DetailPanel();
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            database.ViewLogs(UserGrid);
        }
        private void ShowData()
        {

        }
        private void DisplayRecords()
        {
            database.ViewRecords(UserGrid);
        }
        private void LoadData()
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.UsernameBox.Text = "";
            loginForm.PasswordBox.Text = "";
            loginForm.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void view_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDB.Show();
        }

        private void UserGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text.Trim();

            //if (DateTime.TryParse(searchText, out DateTime searchDate))
            //{
            //    database.SearchLogs(UserGrid, -1, "", searchDate);
            //}
            if (int.TryParse(searchText, out int userId))
            {
                database.SearchLogs(UserGrid, userId, "");
            }
            else
            {
                database.SearchLogs(UserGrid, -1, searchText);
            }
        }
    }
}
