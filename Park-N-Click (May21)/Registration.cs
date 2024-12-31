using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace ParkNClick
{
    public partial class Registration : Form
    {
        Login login;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn;

        public Registration()

        {
            InitializeComponent();
            login = new Login();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordBox.PasswordChar = '\0';
                ConfirmPasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '•';
                ConfirmPasswordBox.PasswordChar = '•';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                try
                {
                    cn.Open();

                    if (FirstNameBox.Text.IsNullOrEmpty() || MiddleInitialBox.Text.IsNullOrEmpty() || LastNameBox.Text.IsNullOrEmpty() || UsernameBox.Text.IsNullOrEmpty() || PasswordBox.Text.IsNullOrEmpty() || ConfirmPasswordBox.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Fill-out all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (PasswordBox.Text != ConfirmPasswordBox.Text)
                    {
                        MessageBox.Show("Invalid confirm passowrd input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES (@UserUsername, @UserPassword, @UserFirstName, @UserMiddleInitial, @UserLastName)", cn))
                        {
                            cmd.Parameters.AddWithValue("@UserUsername", UsernameBox.Text);
                            cmd.Parameters.AddWithValue("@UserPassword", PasswordBox.Text);
                            cmd.Parameters.AddWithValue("@UserFirstName", FirstNameBox.Text);
                            cmd.Parameters.AddWithValue("@UserMiddleInitial", MiddleInitialBox.Text);
                            cmd.Parameters.AddWithValue("@UserLastName", LastNameBox.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account Created", "Done", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627) // Check for duplicate key error
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    cn.Close();
                }
            }

            // Clear input fields
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            MiddleInitialBox.Text = "";
            LastNameBox.Text = "";
            ConfirmPasswordBox.Text = "";
        }


        private void Registration_Load(object sender, EventArgs e)
        {

        }
        //private void label5_Click(object sender, EventArgs e)
        //{
        //    // Specify the correct database where the 'Users' table exists
        //    cn = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //    cn.Open();

        //    if (string.IsNullOrEmpty(FirstNameBox.Text) || string.IsNullOrEmpty(MiddleInitialBox.Text) || string.IsNullOrEmpty(LastNameBox.Text) || string.IsNullOrEmpty(UsernameBox.Text) || string.IsNullOrEmpty(PasswordBox.Text) || string.IsNullOrEmpty(ConfirmPasswordBox.Text))
        //    {
        //        MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //    {
        //        // Explicitly specify column names in the INSERT statement
        //        cm = new SqlCommand("INSERT INTO Users (UserUsername, UserPassword, UserFirstName, UserMiddleInitial, UserLastName) VALUES (@UserUsername, @UserPassword, @UserFirstName, @UserMiddleInitial, @UserLastName)", cn);
        //        cm.Parameters.AddWithValue("UserUsername", UsernameBox.Text);
        //        cm.Parameters.AddWithValue("UserPassword", PasswordBox.Text);
        //        cm.Parameters.AddWithValue("UserFirstName", FirstNameBox.Text);
        //        cm.Parameters.AddWithValue("UserMiddleInitial", MiddleInitialBox.Text);
        //        cm.Parameters.AddWithValue("UserLastName", LastNameBox.Text);

        //        // Execute the query
        //        int rowsAffected = cm.ExecuteNonQuery();

        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Account Created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to create account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    // Close the connection
        //    cn.Close();
        //}

    }
}
