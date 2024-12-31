using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.DataFormats;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingApp
{
    public partial class DetailPanel : UserControl
    {
        public event EventHandler TimeOutClicked;
        public event EventHandler PanelRemoved;
        public int flagdown, rate, hours, total;
        public string type, TI, plate, brand, TO;

        public static int FlagDown(string type)
        {
            switch (type)
            {
                case "MotorBike": return 20;
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
                case "MotorBike": return 5;
                case "SUV": return 20;
                case "Van": return 20;
                case "Sedan": return 15;
                default: return 0;
            }
        }

        public DetailPanel(List<VehicleData> vehicleDataList, int number)
        {
            InitializeComponent();
            type = vehicleDataList[number].typeA;
            TI = vehicleDataList[number].timeInA;
            plate = vehicleDataList[number].plateNumberA;
            brand = vehicleDataList[number].brandA;
            flagdown = FlagDown(type);
            rate = Rate(type);
            typeDisplay.Text = vehicleDataList[number].typeA;
            TIDisplay.Text = vehicleDataList[number].timeInA;
            TODisplay.Text = vehicleDataList[number].plateNumberA;
            brandDisplay.Text = vehicleDataList[number].brandA;

            //para pa smooth sa edges
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            Region = new Region(path);
        }

        public void button1_Click(object sender, EventArgs e)
        {   
            Program123 pg123 = new Program123()
            {
                timeIn = DateTime.Parse(TI),
                timeOut = DateTime.Now,
                type = type,
                brand = brand,
            };
            TO = pg123.timeOut.ToString();
            hours = pg123.TotalHours();
            total = pg123.TotalAmount();
            if (DateTime.Parse(TO) < DateTime.Parse(TI))
            {
                InvalidTimeOut.Text = "Invalid Time Out Date and Time!";
            }
            else
            {
                DialogResult result = MessageBox.Show("Proceed ParkOut?","Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) { MessageBox.Show("Park out cancelled."); }
                else
                {
                    OnTimeOutClicked(EventArgs.Empty);

                    if (this.Parent != null)
                    {
                        this.Parent.Controls.Remove(this);
                    }
                    else
                    {
                        OnPanelRemoved(EventArgs.Empty);
                    }
                    Form3 form3 = new Form3(plate, type, brand, TI, flagdown, rate, hours, total);
                    form3.Show();
                }
            }
        }
        protected virtual void OnTimeOutClicked(EventArgs e)
        {
            TimeOutClicked?.Invoke(this, e);
        }
        protected virtual void OnPanelRemoved(EventArgs e)
        {
            PanelRemoved?.Invoke(this, e);
        }

        public void DetailPanel_Load(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void Brand_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void typeDisplay_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void TODisplay_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click_2(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
