namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string type = "";
        DateTime TimeIn, TimeOut;
        int FlagDown, Rate, TotalAmount, number = 1;
        UserControl1 userControl1 = new UserControl1();
        VehicleData VD = new VehicleData();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //TimeInButton
        {
            //TimeIn = DateTime.Now;
            TimeInBox.Text = TimeIn.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MotorBikeButton_Click(object sender, EventArgs e) //MotorBikeButton
        {
            type = "MotorBike";
            VehicleTypeBox.Text = type;
            FlagDownBox.Text = "20";
            RateBox.Text = "5";
        }

        private void SUVbutton_Click(object sender, EventArgs e) //SUVButton
        {
            type = "SUV";
            VehicleTypeBox.Text = type;
            FlagDownBox.Text = "40";
            RateBox.Text = "20";
        }

        private void button3_Click(object sender, EventArgs e) //SedanButton
        {
            type = "Sedan";
            VehicleTypeBox.Text = type;
            FlagDownBox.Text = "30";
            RateBox.Text = "15";
        }

        private void button1_Click(object sender, EventArgs e) //VanButton
        {
            type = "Van";
            VehicleTypeBox.Text = type;
            FlagDownBox.Text = "40";
            RateBox.Text = "20";
        }
        private void FlagDownBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeInBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlagDownBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BrandBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimeOutInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeOutDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeOutButton_Click(object sender, EventArgs e)
        {
            //TimeOut = DateTime.Parse(TimeOutInput.Text);
            TimeOutDisplay.Text = TimeOut.ToString();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            /* Program123 programMain = new Program123()
             {
                 timeIn = TimeIn,
                 timeOut = TimeOut,
                 type = type
             };
             //Work on this!
             AmountBox.Text = programMain.rawr();*/
            VD.Details.Add(new VehicleData(number, type, TimeIn.ToString(), TimeOut.ToString()));
            userControl1.typeDisplay.Text = VD.Details[1].typeA;
            userControl1.TIDisplay.Text = VD.Details[1].timeInA;
            userControl1.TODisplay.Text = VD.Details[1].timeOutA;
            number++;
            MessageBox.Show(VD.Details[1].typeA.ToString());
        }

        public void AmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlateNoDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
