namespace ParkNClick
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            UsernameBox = new TextBox();
            LoginButton = new Button();
            UsernamePanel = new Panel();
            PasswordPanel = new Panel();
            PasswordBox = new TextBox();
            ExitButton = new Button();
            EnterButton = new Button();
            PassErrorLabel = new Label();
            UserErrorLabel = new Label();
            ErrorLabel = new Label();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            UsernamePanel.SuspendLayout();
            PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.White;
            UsernameBox.BorderStyle = BorderStyle.None;
            UsernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.ForeColor = Color.Black;
            UsernameBox.Location = new Point(3, 3);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(241, 22);
            UsernameBox.TabIndex = 0;
            UsernameBox.TextChanged += UsernameBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Gainsboro;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(129, 322);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(56, 21);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.White;
            UsernamePanel.BorderStyle = BorderStyle.FixedSingle;
            UsernamePanel.Controls.Add(UsernameBox);
            UsernamePanel.ForeColor = Color.NavajoWhite;
            UsernamePanel.Location = new Point(26, 175);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(249, 30);
            UsernamePanel.TabIndex = 0;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.White;
            PasswordPanel.BorderStyle = BorderStyle.FixedSingle;
            PasswordPanel.Controls.Add(PasswordBox);
            PasswordPanel.ForeColor = Color.NavajoWhite;
            PasswordPanel.Location = new Point(26, 241);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(249, 30);
            PasswordPanel.TabIndex = 1;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.White;
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.Location = new Point(3, 3);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '•';
            PasswordBox.Size = new Size(236, 22);
            PasswordBox.TabIndex = 1;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Location = new Point(2, 2);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(0, 0);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Transparent;
            EnterButton.Location = new Point(1, 1);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(0, 0);
            EnterButton.TabIndex = 0;
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // PassErrorLabel
            // 
            PassErrorLabel.AutoSize = true;
            PassErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassErrorLabel.ForeColor = Color.Red;
            PassErrorLabel.Location = new Point(26, 275);
            PassErrorLabel.Name = "PassErrorLabel";
            PassErrorLabel.Size = new Size(0, 15);
            PassErrorLabel.TabIndex = 3;
            // 
            // UserErrorLabel
            // 
            UserErrorLabel.AutoSize = true;
            UserErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserErrorLabel.ForeColor = Color.Red;
            UserErrorLabel.Location = new Point(26, 213);
            UserErrorLabel.Name = "UserErrorLabel";
            UserErrorLabel.Size = new Size(0, 15);
            UserErrorLabel.TabIndex = 4;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(30, 373);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 5;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.ForeColor = Color.White;
            PasswordLabel.Location = new Point(26, 223);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.ForeColor = Color.White;
            UsernameLabel.Location = new Point(26, 157);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 7;
            UsernameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 142);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(26, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(91, 355);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 10;
            label1.Text = "Don't have an account?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(102, 370);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 11;
            label2.Text = "Create Account";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.DarkSlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = ExitButton;
            ClientSize = new Size(300, 500);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(ErrorLabel);
            Controls.Add(UserErrorLabel);
            Controls.Add(PassErrorLabel);
            Controls.Add(EnterButton);
            Controls.Add(ExitButton);
            Controls.Add(PasswordPanel);
            Controls.Add(UsernamePanel);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox UsernameBox;
        public Button LoginButton;
        private Panel UsernamePanel;
        private Panel PasswordPanel;
        public TextBox PasswordBox;
        public Button ExitButton;
        public Button EnterButton;
        private Label PassErrorLabel;
        private Label UserErrorLabel;
        private Label ErrorLabel;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
    }
}
