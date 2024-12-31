using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class Form3 : Form
    {
        public Form3(string FPlate, string FType, string FBrand, string FTi, int FFlagDown, int FRate, int FHours, int FTotal)
        {
          InitializeComponent(FPlate, FType, FBrand, FTi, FFlagDown, FRate, FHours, FTotal);
        }

        public void Form3_Load(object sender, EventArgs e)
        {

        }
        public void receiptPanel1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
