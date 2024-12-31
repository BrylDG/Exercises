using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ParkNClick
{
    public partial class NewRegister : UserControl
    {
        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection cn;

        DatabaseF dbFunctions = new DatabaseF();
        public event EventHandler BackButtonClicked;

        private Timer errorLabelTimer;

        public NewRegister()
        {
            InitializeComponent();
            InitializeErrorLabelTimer();
        }

        private void InitializeErrorLabelTimer()
        {
            errorLabelTimer = new Timer();
            errorLabelTimer.Interval = 5000; // 5 seconds
            errorLabelTimer.Tick += ErrorLabelTimer_Tick;
        }

        private void ErrorLabelTimer_Tick(object sender, EventArgs e)
        {
            ErrorLabel.Text = string.Empty;
            errorLabelTimer.Stop();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
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

            RegisterRecords();
        }
        private void RegisterRecords()
        {
            if (FirstNameBox.Text == "" || LastNameBox.Text == "" || MiddleInitialBox.Text == "" || UsernameBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Fill-out all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dbFunctions.CreateUserRecord(FirstNameBox.Text, MiddleInitialBox.Text, LastNameBox.Text, UsernameBox.Text, PasswordBox.Text);
                FirstNameBox.Text = "";
                LastNameBox.Text = "";
                MiddleInitialBox.Text = "";
                UsernameBox.Text = "";
                PasswordBox.Text = "";
                ConfirmPasswordBox.Text = "";
            }
        }

        //private void Login()
        //{
        //    string userName = textLogUserName.Text.Trim();
        //    string password = textLogPassword.Text.Trim();

        //    if (userName == "" || password == "")
        //    {
        //        MessageBox.Show("Please enter username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (dbFunctions.IsLoginSuccessFull(userName, password)) // return ani niya kay Boolean
        //    {
        //        MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        dbFunctions.ShowUserLogsRecord(userLogsTable);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void SetErrorLabelText(string message)
        {
            ErrorLabel.Text = message;
            errorLabelTimer.Stop();
            errorLabelTimer.Start();
        }
    }
}
