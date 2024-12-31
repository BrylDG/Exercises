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

namespace ExperiApp 
{
    public partial class RegisterUserControl : UserControl
    {
        public event EventHandler BackButtonClicked;
        SqlCommand cm;
        SqlDataReader dr;
        SqlConnection cn;
        public RegisterUserControl()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void RegisterUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            cn.Open();
            if (RegUserBox.Text.IsNullOrEmpty() || RegPassBox.Text.IsNullOrEmpty() || RegConPassBox.Text.IsNullOrEmpty())
            {
                Application.Exit();
            }
            else
            {
                cm = new SqlCommand("insert into Users values(@usrFN,@usrLN,@usrMI,@usrname,@usrpw)", cn);
                cm.Parameters.AddWithValue("usrname", RegUserBox.Text);
                cm.Parameters.AddWithValue("usrpw", RegPassBox.Text);
                cm.Parameters.AddWithValue("usrFN", FirstNameBox.Text);
                cm.Parameters.AddWithValue("usrMI", MiddleNameBox.Text);
                cm.Parameters.AddWithValue("usrLN", FamilyNameBox.Text);
                cm.ExecuteNonQuery();
                MessageBox.Show("Account Created", "Done", MessageBoxButtons.OK);
            }
            cn.Close();
        }

        private void RegConPassBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    