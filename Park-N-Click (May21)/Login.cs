using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ParkNClick
{
    public partial class Login : Form
    {
        Dashboard dashboard;
        AdminDB admindashboard;
        Registration registration;
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        AdminDashboard adb;

        public Login()
        {
            InitializeComponent();
            dashboard = new Dashboard(this);
            admindashboard = new AdminDB(this);
        }

        private void login()
        {
            if (!string.IsNullOrEmpty(UsernameBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text))
            {
                cn = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                cn.Open();
                cmd = new SqlCommand("SELECT * FROM Users WHERE UserUsername=@Username AND UserPassword=@Password", cn);
                cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (UsernameBox.Text == "admin")
                    {
                        int userID = dr.GetInt32(dr.GetOrdinal("UserID"));
                        string username = dr.GetString(dr.GetOrdinal("UserUsername"));
                        DateTime loginDate = DateTime.Now;

                        using (SqlConnection userLogsCN = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                        {
                            userLogsCN.Open();
                            SqlCommand insert = new SqlCommand("INSERT INTO UserLogs (UserID, UserUsername, UserLoginDate) VALUES (@UserID, @UserUsername, @UserLoginDate)", userLogsCN);
                            insert.Parameters.AddWithValue("@UserID", userID);
                            insert.Parameters.AddWithValue("@UserUsername", username);
                            insert.Parameters.AddWithValue("@UserLoginDate", loginDate);
                            insert.ExecuteNonQuery();
                        }
                        dr.Close();
                        cn.Close();
                        this.Hide();
                        admindashboard.Show();
                    }
                    else
                    {
                        int userID = dr.GetInt32(dr.GetOrdinal("UserID"));
                        string username = dr.GetString(dr.GetOrdinal("UserUsername"));
                        DateTime loginDate = DateTime.Now;

                        using (SqlConnection userLogsCN = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                        {
                            userLogsCN.Open();
                            SqlCommand insert = new SqlCommand("INSERT INTO UserLogs (UserID, UserUsername, UserLoginDate) VALUES (@UserID, @UserUsername, @UserLoginDate)", userLogsCN);
                            insert.Parameters.AddWithValue("@UserID", userID);
                            insert.Parameters.AddWithValue("@UserUsername", username);
                            insert.Parameters.AddWithValue("@UserLoginDate", loginDate);
                            insert.ExecuteNonQuery();
                        }
                        dr.Close();
                        cn.Close();
                        this.Hide();
                        dashboard.Show();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No account available with this username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in both username and password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            registration = new Registration();
            this.Hide();
            registration.Show();
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
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
