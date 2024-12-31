namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            w = new Panel();
            userControl11 = new UserControl1();
            MotorBikeButton = new Button();
            SUVbutton = new Button();
            SedanButton = new Button();
            VehicleTypeBox = new TextBox();
            TimeInButton = new Button();
            VanButton = new Button();
            TimeInBox = new TextBox();
            RateBox = new TextBox();
            FlagDownBox = new TextBox();
            FlagdownLabel = new Label();
            RateLabel = new Label();
            TimeOutInput = new TextBox();
            TimeOutDisplay = new TextBox();
            TimeOutButton = new Button();
            AmountBox = new TextBox();
            CalculateButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            userControl12 = new UserControl1();
            w.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // w
            // 
            w.BackColor = SystemColors.ControlLight;
            w.Controls.Add(userControl11);
            w.Location = new Point(660, -2);
            w.Margin = new Padding(3, 2, 3, 2);
            w.Name = "w";
            w.Size = new Size(444, 508);
            w.TabIndex = 0;
            w.Paint += panel1_Paint;
            // 
            // userControl11
            // 
            userControl11.BackColor = SystemColors.ActiveCaption;
            userControl11.Location = new Point(16, 11);
            userControl11.Margin = new Padding(3, 2, 3, 2);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(407, 184);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load_1;
            // 
            // MotorBikeButton
            // 
            MotorBikeButton.Location = new Point(118, 187);
            MotorBikeButton.Margin = new Padding(3, 2, 3, 2);
            MotorBikeButton.Name = "MotorBikeButton";
            MotorBikeButton.Size = new Size(82, 22);
            MotorBikeButton.TabIndex = 1;
            MotorBikeButton.Text = "MotorBikeButton";
            MotorBikeButton.UseVisualStyleBackColor = true;
            MotorBikeButton.Click += MotorBikeButton_Click;
            // 
            // SUVbutton
            // 
            SUVbutton.Location = new Point(226, 187);
            SUVbutton.Margin = new Padding(3, 2, 3, 2);
            SUVbutton.Name = "SUVbutton";
            SUVbutton.Size = new Size(82, 22);
            SUVbutton.TabIndex = 2;
            SUVbutton.Text = "SUVbutton";
            SUVbutton.UseVisualStyleBackColor = true;
            SUVbutton.Click += SUVbutton_Click;
            // 
            // SedanButton
            // 
            SedanButton.Location = new Point(449, 187);
            SedanButton.Margin = new Padding(3, 2, 3, 2);
            SedanButton.Name = "SedanButton";
            SedanButton.Size = new Size(82, 22);
            SedanButton.TabIndex = 4;
            SedanButton.Text = "SedanButton";
            SedanButton.UseVisualStyleBackColor = true;
            SedanButton.Click += button3_Click;
            // 
            // VehicleTypeBox
            // 
            VehicleTypeBox.Location = new Point(186, 146);
            VehicleTypeBox.Margin = new Padding(3, 2, 3, 2);
            VehicleTypeBox.Name = "VehicleTypeBox";
            VehicleTypeBox.Size = new Size(110, 23);
            VehicleTypeBox.TabIndex = 7;
            VehicleTypeBox.Text = "Vehicle Type";
            VehicleTypeBox.TextAlign = HorizontalAlignment.Center;
            VehicleTypeBox.TextChanged += FlagDownBox_TextChanged;
            // 
            // TimeInButton
            // 
            TimeInButton.Location = new Point(401, 351);
            TimeInButton.Margin = new Padding(3, 2, 3, 2);
            TimeInButton.Name = "TimeInButton";
            TimeInButton.Size = new Size(82, 22);
            TimeInButton.TabIndex = 9;
            TimeInButton.Text = "TimeInButton";
            TimeInButton.UseVisualStyleBackColor = true;
            TimeInButton.Click += button5_Click;
            // 
            // VanButton
            // 
            VanButton.Location = new Point(343, 187);
            VanButton.Margin = new Padding(3, 2, 3, 2);
            VanButton.Name = "VanButton";
            VanButton.Size = new Size(82, 22);
            VanButton.TabIndex = 10;
            VanButton.Text = "VanButton";
            VanButton.UseVisualStyleBackColor = true;
            VanButton.Click += button1_Click;
            // 
            // TimeInBox
            // 
            TimeInBox.Location = new Point(401, 377);
            TimeInBox.Margin = new Padding(3, 2, 3, 2);
            TimeInBox.Name = "TimeInBox";
            TimeInBox.Size = new Size(178, 23);
            TimeInBox.TabIndex = 12;
            TimeInBox.TextChanged += TimeInBox_TextChanged;
            // 
            // RateBox
            // 
            RateBox.Location = new Point(421, 94);
            RateBox.Margin = new Padding(3, 2, 3, 2);
            RateBox.Name = "RateBox";
            RateBox.Size = new Size(110, 23);
            RateBox.TabIndex = 8;
            RateBox.TextChanged += RateBox_TextChanged;
            // 
            // FlagDownBox
            // 
            FlagDownBox.Location = new Point(118, 70);
            FlagDownBox.Margin = new Padding(3, 2, 3, 2);
            FlagDownBox.Name = "FlagDownBox";
            FlagDownBox.Size = new Size(110, 23);
            FlagDownBox.TabIndex = 11;
            FlagDownBox.TextChanged += FlagDownBox_TextChanged_1;
            // 
            // FlagdownLabel
            // 
            FlagdownLabel.AutoSize = true;
            FlagdownLabel.Location = new Point(118, 53);
            FlagdownLabel.Name = "FlagdownLabel";
            FlagdownLabel.Size = new Size(62, 15);
            FlagdownLabel.TabIndex = 13;
            FlagdownLabel.Text = "Flagdown:";
            FlagdownLabel.Click += label1_Click;
            // 
            // RateLabel
            // 
            RateLabel.AutoSize = true;
            RateLabel.Location = new Point(422, 53);
            RateLabel.Name = "RateLabel";
            RateLabel.Size = new Size(33, 15);
            RateLabel.TabIndex = 14;
            RateLabel.Text = "Rate:";
            // 
            // TimeOutInput
            // 
            TimeOutInput.Location = new Point(118, 242);
            TimeOutInput.Margin = new Padding(3, 2, 3, 2);
            TimeOutInput.Name = "TimeOutInput";
            TimeOutInput.Size = new Size(414, 23);
            TimeOutInput.TabIndex = 15;
            TimeOutInput.TextChanged += TimeOutInput_TextChanged;
            // 
            // TimeOutDisplay
            // 
            TimeOutDisplay.Location = new Point(118, 377);
            TimeOutDisplay.Margin = new Padding(3, 2, 3, 2);
            TimeOutDisplay.Name = "TimeOutDisplay";
            TimeOutDisplay.Size = new Size(221, 23);
            TimeOutDisplay.TabIndex = 16;
            TimeOutDisplay.TextChanged += TimeOutDisplay_TextChanged;
            // 
            // TimeOutButton
            // 
            TimeOutButton.Location = new Point(118, 351);
            TimeOutButton.Margin = new Padding(3, 2, 3, 2);
            TimeOutButton.Name = "TimeOutButton";
            TimeOutButton.Size = new Size(82, 22);
            TimeOutButton.TabIndex = 17;
            TimeOutButton.Text = "TimeOutButton";
            TimeOutButton.UseVisualStyleBackColor = true;
            TimeOutButton.Click += TimeOutButton_Click;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(401, 439);
            AmountBox.Margin = new Padding(3, 2, 3, 2);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(178, 23);
            AmountBox.TabIndex = 18;
            AmountBox.TextChanged += AmountBox_TextChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(401, 412);
            CalculateButton.Margin = new Padding(3, 2, 3, 2);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(82, 22);
            CalculateButton.TabIndex = 19;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 149);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 20;
            label1.Text = "Flagdown:";
            label1.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(userControl12);
            panel1.Location = new Point(118, 70);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 25);
            panel1.TabIndex = 21;
            // 
            // userControl12
            // 
            userControl12.BackColor = SystemColors.ActiveCaption;
            userControl12.Location = new Point(16, 11);
            userControl12.Margin = new Padding(3, 2, 3, 2);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(407, 184);
            userControl12.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 505);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(CalculateButton);
            Controls.Add(AmountBox);
            Controls.Add(TimeOutButton);
            Controls.Add(TimeOutDisplay);
            Controls.Add(TimeOutInput);
            Controls.Add(RateLabel);
            Controls.Add(FlagdownLabel);
            Controls.Add(TimeInBox);
            Controls.Add(FlagDownBox);
            Controls.Add(VanButton);
            Controls.Add(TimeInButton);
            Controls.Add(RateBox);
            Controls.Add(VehicleTypeBox);
            Controls.Add(SedanButton);
            Controls.Add(SUVbutton);
            Controls.Add(MotorBikeButton);
            Controls.Add(w);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            w.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel w;
        private Button MotorBikeButton;
        private Button SUVbutton;
        private Button SedanButton;
        private ComboBox BrandBox;
        private TextBox PlateNumberBox;
        private TextBox VehicleTypeBox;
        private Button TimeInButton;
        private Button VanButton;
        private TextBox TimeInBox;
        private TextBox RateBox;
        private TextBox FlagDownBox;
        private Label FlagdownLabel;
        private Label RateLabel;
        private TextBox TimeOutInput;
        private TextBox TimeOutDisplay;
        private Button TimeOutButton;
        public TextBox AmountBox;
        private Button CalculateButton;
        private UserControl1 userControl11;
        private Label label1;
        private Panel panel1;
        private UserControl1 userControl12;
    }
}
