using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperiApp
{
    public partial class LoginUserControl : UserControl
    {
        public event EventHandler SignUpButtonClicked, SignInButtonClicked;
        SqlCommand cm;
        SqlDataReader dr;
        SqlConnection cn;

        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            cn.Open();
            if (LogUserBox.Text.IsNullOrEmpty() || LogPassBox.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Wabalo", "Patotoya", MessageBoxButtons.OK);
            }
            else
            {
                cm = new SqlCommand("select * from Users where usrname='" + LogUserBox.Text + "'and usrpw='" + LogPassBox.Text + "'", cn);
                dr = cm.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    SignInButtonClicked?.Invoke(this, EventArgs.Empty);
                }
            }
            cn.Close();
        }
    }
}
