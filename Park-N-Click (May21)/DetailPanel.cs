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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ParkNClick
{
    public partial class DetailPanel : UserControl
    {
        public DetailPanel()
        {

            InitializeComponent();


        }

        public void UpdateDetails(string plateNumber, string vehicleType, string vehicleBrand, string vehicleTime)
        {
            // Update labels with the provided details
            VDplate.Text = plateNumber;
            VDtype.Text = vehicleType;
            VDbrand.Text = vehicleBrand;
            VDtime.Text = vehicleTime;
        }

        private void VDplate_Click(object sender, EventArgs e)
        {

        }

        private void vehiclePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
