using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkNClick
{
    public partial class Receipt : Form
    {
        DateTime TimeOut;
        public static int FlagDown(string type)
        {
            switch (type)
            {
                case "Motorbike": return 20;
                case "SUV": return 40;
                case "Van": return 40;
                case "Sedan": return 30;
                default: return 0;
            }
        }

        public static int Rate(string type)
        {
            switch (type)
            {
                case "Motorbike": return 5;
                case "SUV": return 20;
                case "Van": return 20;
                case "Sedan": return 15;
                default: return 0;
            }
        }
        public Receipt(string Plate, string Type, string Brand, DateTime Ti)
        {
            TimeOut = DateTime.Now;
            InitializeComponent();
            int FD = FlagDown(Type);
            int R = Rate(Type);
            DisplayDetails(Plate, Type, Brand, Ti, FD, R);
        }
            
        private void DisplayDetails(string Plate, string Type, string Brand, DateTime Ti, int flagdown, int rate)
        {
            TimeSpan total = DateTime.Now.Subtract(Ti);
            int th = total.Hours + (total.Days * 24);
            if (total.Minutes > 30)
            {
                th++;
            }
            int totalAmount = th * rate + flagdown;

            PNReceipt.Text = Plate;
            VTReceipt.Text = Type;
            VBReceipt.Text = Brand;
            TIReceipt.Text = Ti.ToString();
            TOReceipt.Text = DateTime.Now.ToString();
            FDReceipt.Text = flagdown.ToString();
            RRate.Text = rate.ToString();
            HRate.Text = th.ToString();
            TReceipt.Text = totalAmount.ToString();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
