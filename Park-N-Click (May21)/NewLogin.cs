using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ParkNClick
{
    public partial class NewLogin : Form
    {
        NewDashboard NewDB = new NewDashboard();
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        NewRegister register = new NewRegister();
        DatabaseF dbFunctions = new DatabaseF();
        string user { get; set; }
        Timer errorTimer;

        public NewLogin()
        {
            InitializeComponent();
            register.Hide();
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.WhiteSmoke, Color.FromArgb(62, 201, 149), 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void InitializeErrorTimer()
        {
            errorTimer = new Timer();
            errorTimer.Interval = 3000;
            errorTimer.Tick += ErrorTimer_Tick;
        }

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            LoginErrorLabel.Text = "";
            errorTimer.Stop();
        }




        private void NewLogin_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            register.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '•';
            }
        }
        private void Login()
        {
            string userName = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();

            if (userName == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            if (dbFunctions.IsLoginSuccessFull(userName, password)) // return ani niya kay Boolean
            {
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                NewDB.Show();
                //dbFunctions.ShowUserLogsRecord(userLogsTable); // If naa natay Ma show ang records para UserLogs
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        //private void login1()
        //{
        //    if (!string.IsNullOrEmpty(UsernameBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
        //    {
        //        cn = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //        cn.Open();
        //        cmd = new SqlCommand("SELECT * FROM Users WHERE UserUsername=@Username AND UserPassword=@Password", cn);
        //        cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
        //        cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);
        //        dr = cmd.ExecuteReader();

        //        if (dr.Read())
        //        {
        //            int userID = dr.GetInt32(dr.GetOrdinal("UserID"));
        //            string username = dr.GetString(dr.GetOrdinal("UserUsername"));
        //            DateTime loginDate = DateTime.Now;

        //            using (SqlConnection userLogsCN = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
        //            {
        //                userLogsCN.Open();
        //                SqlCommand insert = new SqlCommand("INSERT INTO UserLogs (UserID, UserUsername, UserLoginDate, Transactions) VALUES (@UserID, @UserUsername, @UserLoginDate, @Transactions)", userLogsCN);
        //                insert.Parameters.AddWithValue("@UserID", userID);
        //                insert.Parameters.AddWithValue("@UserUsername", username);
        //                insert.Parameters.AddWithValue("@UserLoginDate", loginDate);
        //                insert.Parameters.AddWithValue("Transactions", 0);
        //                insert.ExecuteNonQuery();
        //            }
        //            dr.Close();
        //            cn.Close();
        //            this.Hide();
        //            NewDB.Show();
        //        }
        //        else
        //        {
        //            dr.Close();
        //            LoginErrorLabel.Text = "Invalid Username / Password.";
        //            errorTimer.Start();
        //        }
        //    }
        //    else
        //    {
        //        LoginErrorLabel.Text = "Missing Inputs, Please input username / password.";
        //        errorTimer.Start();
        //    }
        //    user = UsernameBox.Text;
        //}


    }
}
