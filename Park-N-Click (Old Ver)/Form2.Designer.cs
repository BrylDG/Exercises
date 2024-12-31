namespace ParkingApp
{
    partial class Form2
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            gradientPanel1 = new gradientPanel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            sidePanelRight1 = new sidePanelRight();
            ParkInButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            FlagDownLabel = new Label();
            label2 = new Label();
            panel2 = new Panel();
            RateLabel = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            gradientPanel2 = new gradientPanel();
            ErrorMessageLabel = new Label();
            label22 = new Label();
            textBox1 = new TextBox();
            panel5 = new Panel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            Brand = new Label();
            gradientPanel3 = new gradientPanel();
            label7 = new Label();
            gradientPanel6 = new gradientPanel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            gradientPanel4 = new gradientPanel();
            gradientPanel7 = new gradientPanel();
            label14 = new Label();
            label17 = new Label();
            label15 = new Label();
            label16 = new Label();
            label8 = new Label();
            gradientPanel5 = new gradientPanel();
            label9 = new Label();
            gradientPanel8 = new gradientPanel();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            panel6 = new Panel();
            clock = new Label();
            LogOut = new Panel();
            LogOutButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            gradientPanel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            gradientPanel3.SuspendLayout();
            gradientPanel6.SuspendLayout();
            gradientPanel4.SuspendLayout();
            gradientPanel7.SuspendLayout();
            gradientPanel5.SuspendLayout();
            gradientPanel8.SuspendLayout();
            panel6.SuspendLayout();
            LogOut.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 80F;
            gradientPanel1.BackColor = Color.Silver;
            gradientPanel1.BottomColor = Color.Transparent;
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(pictureBox4);
            gradientPanel1.Location = new Point(12, 12);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(162, 572);
            gradientPanel1.TabIndex = 2;
            gradientPanel1.TopColor = Color.Black;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(18, 184);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 15;
            label6.Text = "Administrator";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(21, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 110);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(34, 437);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 89);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // sidePanelRight1
            // 
            sidePanelRight1.AutoScroll = true;
            sidePanelRight1.Location = new Point(734, -1);
            sidePanelRight1.Name = "sidePanelRight1";
            sidePanelRight1.Size = new Size(530, 682);
            sidePanelRight1.TabIndex = 3;
            // 
            // ParkInButton
            // 
            ParkInButton.AccessibleName = "parkInButton";
            ParkInButton.BackColor = Color.DarkSeaGreen;
            ParkInButton.Cursor = Cursors.Hand;
            ParkInButton.Location = new Point(205, 382);
            ParkInButton.Name = "ParkInButton";
            ParkInButton.Size = new Size(103, 31);
            ParkInButton.TabIndex = 0;
            ParkInButton.Text = "Park In";
            ParkInButton.UseVisualStyleBackColor = false;
            ParkInButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 4;
            label1.Text = "Flag Down: ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(FlagDownLabel);
            panel1.Location = new Point(50, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(103, 23);
            panel1.TabIndex = 5;
            // 
            // FlagDownLabel
            // 
            FlagDownLabel.AutoSize = true;
            FlagDownLabel.Font = new Font("Segoe UI", 10F);
            FlagDownLabel.Location = new Point(4, 0);
            FlagDownLabel.Name = "FlagDownLabel";
            FlagDownLabel.Size = new Size(0, 19);
            FlagDownLabel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(382, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 6;
            label2.Text = "Rate:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(RateLabel);
            panel2.Location = new Point(382, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(103, 23);
            panel2.TabIndex = 7;
            // 
            // RateLabel
            // 
            RateLabel.AutoSize = true;
            RateLabel.Font = new Font("Segoe UI", 10F);
            RateLabel.Location = new Point(3, 0);
            RateLabel.Name = "RateLabel";
            RateLabel.Size = new Size(0, 19);
            RateLabel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(205, 112);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 8;
            label3.Text = "Type: ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(205, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(103, 23);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Location = new Point(50, 181);
            button1.Margin = new Padding(10, 3, 10, 3);
            button1.Name = "button1";
            button1.Size = new Size(82, 30);
            button1.TabIndex = 10;
            button1.Text = "Motorbike";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.Location = new Point(186, 181);
            button2.Margin = new Padding(10, 3, 10, 3);
            button2.Name = "button2";
            button2.Size = new Size(82, 30);
            button2.TabIndex = 11;
            button2.Text = "SUV";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.WhiteSmoke;
            button3.Location = new Point(288, 181);
            button3.Margin = new Padding(10, 3, 10, 3);
            button3.Name = "button3";
            button3.Size = new Size(82, 30);
            button3.TabIndex = 12;
            button3.Text = "Van";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Location = new Point(403, 181);
            button4.Margin = new Padding(10, 3, 10, 3);
            button4.Name = "button4";
            button4.Size = new Size(82, 30);
            button4.TabIndex = 13;
            button4.Text = "Sedan";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.BorderStyle = BorderStyle.Fixed3D;
            gradientPanel2.BottomColor = Color.DarkGray;
            gradientPanel2.Controls.Add(ErrorMessageLabel);
            gradientPanel2.Controls.Add(label22);
            gradientPanel2.Controls.Add(panel2);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(panel1);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(panel3);
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(textBox1);
            gradientPanel2.Controls.Add(panel5);
            gradientPanel2.Controls.Add(comboBox1);
            gradientPanel2.Controls.Add(panel4);
            gradientPanel2.Controls.Add(button4);
            gradientPanel2.Controls.Add(button3);
            gradientPanel2.Controls.Add(button2);
            gradientPanel2.Controls.Add(button1);
            gradientPanel2.Controls.Add(ParkInButton);
            gradientPanel2.Location = new Point(180, 223);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(548, 454);
            gradientPanel2.TabIndex = 14;
            gradientPanel2.TopColor = Color.Silver;
            gradientPanel2.Paint += gradientPanel2_Paint;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.AutoSize = true;
            ErrorMessageLabel.BackColor = Color.Transparent;
            ErrorMessageLabel.ForeColor = Color.Red;
            ErrorMessageLabel.Location = new Point(171, 350);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(0, 15);
            ErrorMessageLabel.TabIndex = 19;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(228, 10);
            label22.Name = "label22";
            label22.Size = new Size(77, 28);
            label22.TabIndex = 8;
            label22.Text = "Park In";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDarkDark;
            panel5.Controls.Add(label5);
            panel5.ForeColor = SystemColors.ButtonFace;
            panel5.Location = new Point(100, 290);
            panel5.Name = "panel5";
            panel5.Size = new Size(62, 23);
            panel5.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 4);
            label5.Name = "label5";
            label5.Size = new Size(43, 13);
            label5.TabIndex = 0;
            label5.Text = "Plate #";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "  " });
            comboBox1.Location = new Point(159, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(Brand);
            panel4.Location = new Point(100, 253);
            panel4.Name = "panel4";
            panel4.Size = new Size(62, 23);
            panel4.TabIndex = 15;
            // 
            // Brand
            // 
            Brand.AutoSize = true;
            Brand.BackColor = Color.Transparent;
            Brand.Font = new Font("Nirmala UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Brand.ForeColor = SystemColors.ButtonFace;
            Brand.Location = new Point(15, 4);
            Brand.Name = "Brand";
            Brand.Size = new Size(38, 13);
            Brand.TabIndex = 0;
            Brand.Text = "Brand";
            Brand.Click += Brand_Click;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Angle = 0F;
            gradientPanel3.BackColor = Color.LightGray;
            gradientPanel3.BorderStyle = BorderStyle.Fixed3D;
            gradientPanel3.BottomColor = Color.Empty;
            gradientPanel3.Controls.Add(label7);
            gradientPanel3.Controls.Add(gradientPanel6);
            gradientPanel3.Location = new Point(180, 12);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(182, 205);
            gradientPanel3.TabIndex = 15;
            gradientPanel3.TopColor = Color.Empty;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 13);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 5;
            label7.Text = "Vehicle Type:";
            // 
            // gradientPanel6
            // 
            gradientPanel6.Angle = 0F;
            gradientPanel6.BackColor = Color.WhiteSmoke;
            gradientPanel6.BottomColor = Color.Empty;
            gradientPanel6.Controls.Add(label13);
            gradientPanel6.Controls.Add(label12);
            gradientPanel6.Controls.Add(label11);
            gradientPanel6.Controls.Add(label10);
            gradientPanel6.Location = new Point(15, 43);
            gradientPanel6.Name = "gradientPanel6";
            gradientPanel6.Size = new Size(138, 145);
            gradientPanel6.TabIndex = 6;
            gradientPanel6.TopColor = Color.Empty;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(20, 110);
            label13.Name = "label13";
            label13.Size = new Size(45, 17);
            label13.TabIndex = 10;
            label13.Text = "Sedan";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(20, 82);
            label12.Name = "label12";
            label12.Size = new Size(31, 17);
            label12.TabIndex = 9;
            label12.Text = "Van";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 52);
            label11.Name = "label11";
            label11.Size = new Size(33, 17);
            label11.TabIndex = 8;
            label11.Text = "SUV";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(20, 22);
            label10.Name = "label10";
            label10.Size = new Size(72, 17);
            label10.TabIndex = 7;
            label10.Text = "Motorbike";
            // 
            // gradientPanel4
            // 
            gradientPanel4.Angle = 0F;
            gradientPanel4.BackColor = Color.Silver;
            gradientPanel4.BorderStyle = BorderStyle.Fixed3D;
            gradientPanel4.BottomColor = Color.Empty;
            gradientPanel4.Controls.Add(gradientPanel7);
            gradientPanel4.Controls.Add(label8);
            gradientPanel4.Location = new Point(353, 12);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(199, 205);
            gradientPanel4.TabIndex = 16;
            gradientPanel4.TopColor = Color.Empty;
            // 
            // gradientPanel7
            // 
            gradientPanel7.Angle = 0F;
            gradientPanel7.BackColor = Color.WhiteSmoke;
            gradientPanel7.BottomColor = Color.Empty;
            gradientPanel7.Controls.Add(label14);
            gradientPanel7.Controls.Add(label17);
            gradientPanel7.Controls.Add(label15);
            gradientPanel7.Controls.Add(label16);
            gradientPanel7.Location = new Point(32, 43);
            gradientPanel7.Name = "gradientPanel7";
            gradientPanel7.Size = new Size(120, 145);
            gradientPanel7.TabIndex = 7;
            gradientPanel7.TopColor = Color.Empty;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(41, 110);
            label14.Name = "label14";
            label14.Size = new Size(40, 17);
            label14.TabIndex = 10;
            label14.Text = "30.00";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(41, 22);
            label17.Name = "label17";
            label17.Size = new Size(40, 17);
            label17.TabIndex = 7;
            label17.Text = "20.00";
            label17.Click += label17_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(41, 82);
            label15.Name = "label15";
            label15.Size = new Size(40, 17);
            label15.TabIndex = 9;
            label15.Text = "40.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(41, 52);
            label16.Name = "label16";
            label16.Size = new Size(40, 17);
            label16.TabIndex = 8;
            label16.Text = "40.00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(54, 13);
            label8.Name = "label8";
            label8.Size = new Size(78, 17);
            label8.TabIndex = 6;
            label8.Text = "Flag Down:";
            label8.Click += label8_Click;
            // 
            // gradientPanel5
            // 
            gradientPanel5.Angle = 0F;
            gradientPanel5.BackColor = Color.DarkGray;
            gradientPanel5.BorderStyle = BorderStyle.Fixed3D;
            gradientPanel5.BottomColor = Color.Empty;
            gradientPanel5.Controls.Add(label9);
            gradientPanel5.Controls.Add(gradientPanel8);
            gradientPanel5.Location = new Point(549, 12);
            gradientPanel5.Name = "gradientPanel5";
            gradientPanel5.Size = new Size(179, 205);
            gradientPanel5.TabIndex = 17;
            gradientPanel5.TopColor = Color.Empty;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(69, 13);
            label9.Name = "label9";
            label9.Size = new Size(39, 17);
            label9.TabIndex = 7;
            label9.Text = "Rate:";
            // 
            // gradientPanel8
            // 
            gradientPanel8.Angle = 0F;
            gradientPanel8.BackColor = Color.WhiteSmoke;
            gradientPanel8.BottomColor = Color.Empty;
            gradientPanel8.Controls.Add(label18);
            gradientPanel8.Controls.Add(label19);
            gradientPanel8.Controls.Add(label20);
            gradientPanel8.Controls.Add(label21);
            gradientPanel8.Location = new Point(28, 43);
            gradientPanel8.Name = "gradientPanel8";
            gradientPanel8.Size = new Size(123, 145);
            gradientPanel8.TabIndex = 8;
            gradientPanel8.TopColor = Color.Empty;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(41, 110);
            label18.Name = "label18";
            label18.Size = new Size(40, 17);
            label18.TabIndex = 10;
            label18.Text = "15.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(40, 82);
            label19.Name = "label19";
            label19.Size = new Size(40, 17);
            label19.TabIndex = 9;
            label19.Text = "20.00";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(41, 52);
            label20.Name = "label20";
            label20.Size = new Size(40, 17);
            label20.TabIndex = 8;
            label20.Text = "20.00";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(41, 22);
            label21.Name = "label21";
            label21.Size = new Size(33, 17);
            label21.TabIndex = 7;
            label21.Text = "5.00";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(clock);
            panel6.Location = new Point(12, 575);
            panel6.Name = "panel6";
            panel6.Size = new Size(162, 63);
            panel6.TabIndex = 18;
            // 
            // clock
            // 
            clock.AutoSize = true;
            clock.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clock.ForeColor = Color.ForestGreen;
            clock.Location = new Point(0, 12);
            clock.Name = "clock";
            clock.Size = new Size(103, 37);
            clock.TabIndex = 0;
            clock.Text = "00:00";
            clock.Click += clock_Click;
            // 
            // LogOut
            // 
            LogOut.BackColor = SystemColors.GrayText;
            LogOut.Controls.Add(LogOutButton);
            LogOut.Location = new Point(12, 637);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(162, 40);
            LogOut.TabIndex = 20;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.FromArgb(255, 192, 192);
            LogOutButton.Location = new Point(43, 9);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(75, 23);
            LogOutButton.TabIndex = 20;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AcceptButton = ParkInButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1264, 681);
            ControlBox = false;
            Controls.Add(LogOut);
            Controls.Add(panel6);
            Controls.Add(gradientPanel1);
            Controls.Add(gradientPanel5);
            Controls.Add(gradientPanel4);
            Controls.Add(gradientPanel3);
            Controls.Add(gradientPanel2);
            Controls.Add(sidePanelRight1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Form2_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            gradientPanel6.ResumeLayout(false);
            gradientPanel6.PerformLayout();
            gradientPanel4.ResumeLayout(false);
            gradientPanel4.PerformLayout();
            gradientPanel7.ResumeLayout(false);
            gradientPanel7.PerformLayout();
            gradientPanel5.ResumeLayout(false);
            gradientPanel5.PerformLayout();
            gradientPanel8.ResumeLayout(false);
            gradientPanel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            LogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public gradientPanel gradientPanel1;
        public PictureBox pictureBox4;
        public sidePanelRight sidePanelRight1;
        public PictureBox pictureBox1;
        public Button ParkInButton;
        public Label label1;
        public Panel panel1;
        public Label label2;
        public Panel panel2;
        public Label label3;
        public Panel panel3;
        public Label label4;
        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public gradientPanel gradientPanel2;
        public ComboBox comboBox1;
        public Panel panel4;
        public Label Brand;
        public TextBox textBox1;
        public Panel panel5;
        public Label label5;
        public Label label6;
        public gradientPanel gradientPanel3;
        public gradientPanel gradientPanel4;
        public gradientPanel gradientPanel5;
        public gradientPanel gradientPanel6;
        public Label label13;
        public Label label12;
        public Label label11;
        public Label label10;
        public Label label7;
        public Label label8;
        public Label label9;
        public gradientPanel gradientPanel7;
        public Label label14;
        public Label label15;
        public Label label16;
        public Label label17;
        public gradientPanel gradientPanel8;
        public Label label18;
        public Label label19;
        public Label label20;
        public Label label21;
        public Panel panel6;
        public Label clock;
        public Label label22;
        public Label FlagDownLabel;
        public Label RateLabel;
        public Label ErrorMessageLabel;
        private System.ComponentModel.IContainer components;
        private Panel LogOut;
        private Button LogOutButton;
        public System.Windows.Forms.Timer timer1;
    }
}