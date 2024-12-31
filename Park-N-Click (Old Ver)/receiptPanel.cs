using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class receiptPanel : UserControl
    {
        //WORK on this
        public receiptPanel(string Plate, string Type, string Brand, string Ti, int FlagDown, int Rate, int Hours, int Total)
        {
            InitializeComponent();
            PNReceipt.Text = Plate;
            VTReceipt.Text = Type;
            VBReceipt.Text = Brand;
            TIReceipt.Text = Ti;
            TOReceipt.Text = DateTime.Now.ToString();
            FDReceipt.Text = FlagDown.ToString();
            RRate.Text = Rate.ToString();
            HRate.Text = Hours.ToString();
            TReceipt.Text = Total.ToString();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }

        public void receiptPanel_Load(object sender, EventArgs e)
        {
           
        }

        public void label12_Click(object sender, EventArgs e)
        {

        }

        public void label18_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void DetailPanel_TimeOutClicked(object sender,EventArgs e)
        {

        }
    }
}
