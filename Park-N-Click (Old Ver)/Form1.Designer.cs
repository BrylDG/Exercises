namespace ParkingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gradientPanel1 = new gradientPanel();
            loginButton = new Button();
            button1 = new Button();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            textBox1 = new TextBox();
            passwordLabel = new Label();
            userTextBox = new TextBox();
            usernameLabel = new Label();
            button2 = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 80F;
            gradientPanel1.BackColor = Color.Silver;
            gradientPanel1.BottomColor = Color.Gray;
            gradientPanel1.Controls.Add(loginButton);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(label4);
            gradientPanel1.Controls.Add(label3);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(pictureBox4);
            gradientPanel1.Controls.Add(textBox1);
            gradientPanel1.Controls.Add(passwordLabel);
            gradientPanel1.Controls.Add(userTextBox);
            gradientPanel1.Controls.Add(usernameLabel);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(443, 577);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.Black;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ControlText;
            loginButton.Location = new Point(165, 438);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(96, 37);
            loginButton.TabIndex = 16;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 50);
            button1.Name = "button1";
            button1.Size = new Size(93, 33);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(131, 159);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 15;
            label1.Text = "Park n' Click";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(143, 481);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(278, 270);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(62, 393);
            label3.Name = "label3";
            label3.Size = new Size(0, 16);
            label3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(62, 288);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(165, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(105, 107);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Ebrima", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(62, 369);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '•';
            textBox1.Size = new Size(312, 21);
            textBox1.TabIndex = 3;
            textBox1.MouseClick += textBox1_MouseClick;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = SystemColors.ControlLight;
            passwordLabel.Location = new Point(62, 341);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(81, 21);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // userTextBox
            // 
            userTextBox.BorderStyle = BorderStyle.None;
            userTextBox.Font = new Font("Ebrima", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTextBox.ForeColor = SystemColors.WindowText;
            userTextBox.Location = new Point(62, 264);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(312, 21);
            userTextBox.TabIndex = 1;
            userTextBox.MouseClick += userTextBox_MouseClick;
            userTextBox.TextChanged += userTextBox_TextChanged;
            userTextBox.KeyDown += userTextBox_KeyDown;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = SystemColors.ControlLight;
            usernameLabel.Location = new Point(62, 235);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 21);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            // 
            // button2
            // 
            button2.Location = new Point(24, 623);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = button2;
            ClientSize = new Size(443, 577);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Park n' Click";
            TopMost = true;
            Load += Form1_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public gradientPanel gradientPanel1;
        public Label usernameLabel;
        public TextBox userTextBox;
        public TextBox textBox1;
        public Label passwordLabel;
        public PictureBox pictureBox4;
        public Label label2;
        public Label label3;
        public Label label4;
        private Button button2;
        private Label label1;
        public Button button1;
        private Label label5;
        private Button loginButton;
    }
}
