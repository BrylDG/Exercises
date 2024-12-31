namespace ExperiApp
{
    partial class LoginForm
    {
        Dashboard db = new Dashboard();
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            registerUserControl1 = new RegisterUserControl();
            loginUserControl1 = new LoginUserControl();
            EnterButton = new Button();
            SuspendLayout();
            // 
            // registerUserControl1
            // 
            registerUserControl1.BackColor = SystemColors.MenuHighlight;
            registerUserControl1.Location = new Point(0, 0);
            registerUserControl1.Name = "registerUserControl1";
            registerUserControl1.Size = new Size(783, 411);
            registerUserControl1.TabIndex = 0;
            registerUserControl1.BackButtonClicked += registerUserControl1_BackButtonClicked;
            // 
            // loginUserControl1
            // 
            loginUserControl1.BackColor = SystemColors.MenuHighlight;
            loginUserControl1.ForeColor = Color.Black;
            loginUserControl1.Location = new Point(0, 180);
            loginUserControl1.Name = "loginUserControl1";
            loginUserControl1.Size = new Size(783, 411);
            loginUserControl1.TabIndex = 1;
            loginUserControl1.SignUpButtonClicked += loginUserControl1_SignUpButtonClicked;
            loginUserControl1.SignInButtonClicked += loginUserControl1_SignInButtonClicked;
            loginUserControl1.Load += loginUserControl1_Load;
            // 
            // EnterButton
            // 
            EnterButton.Location = new Point(708, 35);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(0, 0);
            EnterButton.TabIndex = 2;
            EnterButton.UseVisualStyleBackColor = true;
            EnterButton.Click += loginUserControl1_SignInButtonClicked;
            // 
            // LoginForm
            // 
            AcceptButton = EnterButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(784, 411);
            Controls.Add(EnterButton);
            Controls.Add(loginUserControl1);
            Controls.Add(registerUserControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Park N' Go";
            Load += LoginForm_Load;
            ResumeLayout(false);
        }

        private void loginUserControl1_SignUpButtonClicked(object sender, EventArgs e)
        {
            registerUserControl1.Show();
            loginUserControl1.Hide();
        }

        private void registerUserControl1_BackButtonClicked(object sender, EventArgs e)
        {
            loginUserControl1.Show();
            registerUserControl1.Hide();
        }
        private void loginUserControl1_SignInButtonClicked(object sender, EventArgs e)
        {
            this.Hide();
            db.Show();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private LoginUserControl loginUserControl1;
        private RegisterUserControl registerUserControl1;
        private Button EnterButton;
    }
}
