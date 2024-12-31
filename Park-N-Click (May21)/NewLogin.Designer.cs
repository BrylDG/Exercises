namespace ParkNClick
{
    partial class NewLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLogin));
            LoginPanel = new Panel();
            newRegister1 = new NewRegister();
            LoginErrorLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            ErrorLabel = new Label();
            UserErrorLabel = new Label();
            PassErrorLabel = new Label();
            PasswordPanel = new Panel();
            PasswordBox = new TextBox();
            UsernamePanel = new Panel();
            UsernameBox = new TextBox();
            LoginButton = new Button();
            EnterButton = new Button();
            ExitButton = new Button();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PasswordPanel.SuspendLayout();
            UsernamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.White;
            LoginPanel.Controls.Add(newRegister1);
            LoginPanel.Controls.Add(LoginErrorLabel);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(checkBox1);
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Controls.Add(UsernameLabel);
            LoginPanel.Controls.Add(PasswordLabel);
            LoginPanel.Controls.Add(ErrorLabel);
            LoginPanel.Controls.Add(UserErrorLabel);
            LoginPanel.Controls.Add(PassErrorLabel);
            LoginPanel.Controls.Add(PasswordPanel);
            LoginPanel.Controls.Add(UsernamePanel);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Location = new Point(84, 139);
            LoginPanel.Margin = new Padding(4, 4, 4, 4);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(438, 650);
            LoginPanel.TabIndex = 1;
            // 
            // newRegister1
            // 
            newRegister1.Location = new Point(0, 0);
            newRegister1.Margin = new Padding(5, 5, 5, 5);
            newRegister1.Name = "newRegister1";
            newRegister1.Size = new Size(438, 650);
            newRegister1.TabIndex = 4;
            newRegister1.Visible = false;
            newRegister1.BackButtonClicked += NewRegister1_BackButtonClicked;
            // 
            // LoginErrorLabel
            // 
            LoginErrorLabel.AutoSize = true;
            LoginErrorLabel.BackColor = Color.Transparent;
            LoginErrorLabel.ForeColor = Color.Red;
            LoginErrorLabel.Location = new Point(59, 408);
            LoginErrorLabel.Margin = new Padding(4, 0, 4, 0);
            LoginErrorLabel.Name = "LoginErrorLabel";
            LoginErrorLabel.Size = new Size(0, 20);
            LoginErrorLabel.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(62, 201, 149);
            label2.Location = new Point(154, 496);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 23;
            label2.Text = "Create Account";
            label2.Click += newRegister_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(140, 478);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 17);
            label1.TabIndex = 22;
            label1.Text = "Don't have an account?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkBox1.Location = new Point(59, 380);
            checkBox1.Margin = new Padding(4, 4, 4, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(95, 49);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 178);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.ForeColor = Color.Black;
            UsernameLabel.Location = new Point(59, 230);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 19;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.ForeColor = Color.Black;
            PasswordLabel.Location = new Point(59, 312);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 18;
            PasswordLabel.Text = "Password";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(64, 500);
            ErrorLabel.Margin = new Padding(4, 0, 4, 0);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 20);
            ErrorLabel.TabIndex = 17;
            // 
            // UserErrorLabel
            // 
            UserErrorLabel.AutoSize = true;
            UserErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserErrorLabel.ForeColor = Color.Red;
            UserErrorLabel.Location = new Point(59, 300);
            UserErrorLabel.Margin = new Padding(4, 0, 4, 0);
            UserErrorLabel.Name = "UserErrorLabel";
            UserErrorLabel.Size = new Size(0, 20);
            UserErrorLabel.TabIndex = 16;
            // 
            // PassErrorLabel
            // 
            PassErrorLabel.AutoSize = true;
            PassErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassErrorLabel.ForeColor = Color.Red;
            PassErrorLabel.Location = new Point(59, 378);
            PassErrorLabel.Margin = new Padding(4, 0, 4, 0);
            PassErrorLabel.Name = "PassErrorLabel";
            PassErrorLabel.Size = new Size(0, 20);
            PassErrorLabel.TabIndex = 15;
            // 
            // PasswordPanel
            // 
            PasswordPanel.BackColor = Color.White;
            PasswordPanel.BorderStyle = BorderStyle.FixedSingle;
            PasswordPanel.Controls.Add(PasswordBox);
            PasswordPanel.ForeColor = Color.NavajoWhite;
            PasswordPanel.Location = new Point(59, 335);
            PasswordPanel.Margin = new Padding(4, 4, 4, 4);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Size = new Size(311, 37);
            PasswordPanel.TabIndex = 13;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.White;
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.Location = new Point(4, 4);
            PasswordBox.Margin = new Padding(4, 4, 4, 4);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '•';
            PasswordBox.Size = new Size(295, 27);
            PasswordBox.TabIndex = 1;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = Color.White;
            UsernamePanel.BorderStyle = BorderStyle.FixedSingle;
            UsernamePanel.Controls.Add(UsernameBox);
            UsernamePanel.ForeColor = Color.Black;
            UsernamePanel.Location = new Point(59, 252);
            UsernamePanel.Margin = new Padding(4, 4, 4, 4);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(311, 37);
            UsernamePanel.TabIndex = 12;
            // 
            // UsernameBox
            // 
            UsernameBox.BackColor = Color.White;
            UsernameBox.BorderStyle = BorderStyle.None;
            UsernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameBox.ForeColor = Color.Black;
            UsernameBox.Location = new Point(4, 4);
            UsernameBox.Margin = new Padding(4, 4, 4, 4);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(301, 27);
            UsernameBox.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Gainsboro;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.Black;
            LoginButton.Location = new Point(188, 436);
            LoginButton.Margin = new Padding(4, 4, 4, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(70, 26);
            LoginButton.TabIndex = 14;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Transparent;
            EnterButton.Location = new Point(0, 2);
            EnterButton.Margin = new Padding(4, 4, 4, 4);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(0, 0);
            EnterButton.TabIndex = 2;
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Location = new Point(0, 0);
            ExitButton.Margin = new Padding(4, 4, 4, 4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(0, 0);
            ExitButton.TabIndex = 3;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // NewLogin
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(62, 201, 149);
            CancelButton = ExitButton;
            CausesValidation = false;
            ClientSize = new Size(605, 851);
            Controls.Add(EnterButton);
            Controls.Add(ExitButton);
            Controls.Add(LoginPanel);
            ForeColor = Color.FromArgb(71, 121, 196);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 4, 4, 4);
            Name = "NewLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += NewLogin_Load;
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            ResumeLayout(false);
        }

        private void NewRegister1_BackButtonClicked(object sender, EventArgs e)
        {
            newRegister1.Hide();
        }

        private void newRegister_Clicked(object sender, EventArgs e)
        {
            newRegister1.Show();
        }

        #endregion

        private Panel LoginPanel;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label ErrorLabel;
        private Label UserErrorLabel;
        private Label PassErrorLabel;
        private Panel PasswordPanel;
        public TextBox PasswordBox;
        private Panel UsernamePanel;
        public TextBox UsernameBox;
        public Button LoginButton;
        public Button EnterButton;
        public Button ExitButton;
        private NewRegister newRegister1;
        private Label LoginErrorLabel;
    }
}