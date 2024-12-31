using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ParkingApp
{
    public partial class Form2 : Form
    {
        public int nextPanelX = 743;
        public int nextPanelY = 12;
        VehicleData VD = new VehicleData();
        public List<DetailPanel> panels = new List<DetailPanel>();
        public int number = 0;
        public string type, brand, PlateNumber;
        public DateTime timeIn, timeOut;
        public bool hide = false;
       // Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Text = "";
            textBox1.Text = "";
            FlagDownLabel.Text = "";
            RateLabel.Text = "";
            label4.Text = "";
            this.Size = new System.Drawing.Size(1280, 720);
            this.MinimumSize = this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
            float dpiX, dpiY;
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(dpiX, dpiY);
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void detailPanel4_Load(object sender, EventArgs e)
        {
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            type = "MotorBike";
            label4.Text = type;
            FlagDownLabel.Text = "20";
            RateLabel.Text = "5";
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kawasaki");
            comboBox1.Items.Add("Suzuki");
            comboBox1.Items.Add("Honda");
            comboBox1.Items.Add("Rusi");
            comboBox1.Items.Add("Yamaha");

        }

        public void button2_Click(object sender, EventArgs e)
        {
            type = "SUV";
            label4.Text = type;
            FlagDownLabel.Text = "40";
            RateLabel.Text = "20";
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kia");
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Ford");
            comboBox1.Items.Add("Hyundai");
            comboBox1.Items.Add("Mitsubishi");
            comboBox1.Items.Add("Isuzu");
        }

        public void button4_Click(object sender, EventArgs e)
        {
            type = "Sedan";
            label4.Text = type;
            FlagDownLabel.Text = "30";
            RateLabel.Text = "15";
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Volkswagen");
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Ford");
            comboBox1.Items.Add("Hyundai");
            comboBox1.Items.Add("Mitsubishi");
            comboBox1.Items.Add("Nissan");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            type = "Van";
            label4.Text = type;
            FlagDownLabel.Text = "40";
            RateLabel.Text = "20";
            comboBox1.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Toyota");
            comboBox1.Items.Add("Nissan");
            comboBox1.Items.Add("Hyundai");
            comboBox1.Items.Add("Ford");
            comboBox1.Items.Add("Kia");
        }

        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || FlagDownLabel.Text == "" || RateLabel.Text == "" || label4.Text == "") { ErrorMessageLabel.Text = "Missing Inputs! Please Input Details."; }
            else if (string.IsNullOrWhiteSpace(textBox1.Text)) { ErrorMessageLabel.Text = "Enter Vehicle Plate Number"; }
            else
            { 
                timeIn = DateTime.Now;
                brand = comboBox1.Text;
                PlateNumber = textBox1.Text;
                VD.Details.Add(new VehicleData(number, type, timeIn.ToString(), PlateNumber, brand));
                DetailPanel detailPanel = new DetailPanel(VD.Details, number);
                number++;
                detailPanel.Location = new System.Drawing.Point(nextPanelX, nextPanelY);
                detailPanel.PanelRemoved += DetailPanel_PanelRemoved;
                this.Controls.Add(detailPanel);
                detailPanel.BringToFront();
                sidePanelRight1.flowLayoutPanel1.Controls.Add(detailPanel);
                panels.Add(detailPanel);
                nextPanelY = panels.Count > 0 ? panels.Last().Bottom : nextPanelY;
                detailPanel.VerticalScroll.Value = detailPanel.VerticalScroll.Maximum;
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                textBox1.Text = "";
                FlagDownLabel.Text = "";
                RateLabel.Text = "";
                label4.Text = "";
                ErrorMessageLabel.Text = "";
            }
        }

        public void DetailPanel_PanelRemoved(object sender, EventArgs e)
        {
            DetailPanel removedPanel = sender as DetailPanel;
            int removedIndex = panels.IndexOf(removedPanel);
            if (removedIndex >= 0)
            {
                int gapHeight = removedPanel.Height;
                this.Controls.Remove(removedPanel);
                panels.Remove(removedPanel);
                for (int i = removedIndex; i < panels.Count; i++)
                {
                    panels[i].Top -= gapHeight;
                }
                nextPanelY = panels.Count > 0 ? panels.Last().Bottom : nextPanelY;
            }
        }

        public void Brand_Click(object sender, EventArgs e)
        {

        }

        public void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void label12_Click(object sender, EventArgs e)
        {

        }

        public void label17_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("hh:mm tt");
        }

        public void receiptPanel1_Load(object sender, EventArgs e)
        {

        }

        public void label8_Click(object sender, EventArgs e)
        {

        }

        public void clock_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.FormClosed += Form1_FormClosed;
            form1.Show();
            this.Hide();
            hide = true;
        }
        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
