using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class Form1 : Form
    {
        string username = "admin", password = "admin";
        Form2 form2 = new Form2();
        bool hide1 = false;

        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = this.MaximumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.AutoScaleMode = AutoScaleMode.Dpi;
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

        public void button1_Click(object sender, EventArgs e)
        {
            Login();
        }


        private void Login()
        {
            if (string.IsNullOrEmpty(userTextBox.Text) && string.IsNullOrEmpty(textBox1.Text) || userTextBox.Text != username && textBox1.Text != password)
            {

                label5.Text = "Missing/Invalid Username and Password";
            }
            else if (userTextBox.Text != username)
            {
                label2.Text = "Invalid Username";
            }
            else if (textBox1.Text != password)
            {

                label3.Text = "Invalid Password";
            }
            else
            {

                form2.FormClosed += Form2_FormClosed;
                form2.Show();
                this.Hide();
            }
        }

        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }


        private void userTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
        }
        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = userTextBox.SelectionStart;
            userTextBox.Text = RemoveWhitespace(userTextBox.Text);
            label2.Text = "";

        }
        private void userTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (userTextBox.Text == "")
                {
                    label2.Text = "Please enter your username!";
                }
                else
                {
                    textBox1.Focus();

                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

            label3.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Login();

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Text = RemoveWhitespace(textBox1.Text);

        }

        private string RemoveWhitespace(string input)
        {
            return Regex.Replace(input, @"\s", "");
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form2.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
    }

}

