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
    public partial class NewDashboard : Form
    {
        DatabaseFunctions db = new DatabaseFunctions();
        public NewDashboard()
        {
            InitializeComponent();
        }

        private void NewDashboard_Load(object sender, EventArgs e)
        {

        }
        public void Hover(object sender, EventArgs e)
        {
            SignOutPanel.BackColor = Color.Green;
        }
        public void Out(object sender, EventArgs e)
        {
            SignOutPanel.BackColor = Color.MediumSeaGreen;
        }

        private void SignOutPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SignOut(object sender, MouseEventArgs e)
        {
            db.LogOut();
            NewLogin login = new NewLogin();
            this.Close();
            login.Show();
        }
    }
}
