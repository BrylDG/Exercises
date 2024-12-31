namespace ExperiApp
{
    partial class LoginUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            SignUpButton = new Button();
            SignInButton = new Button();
            LogPassBox = new TextBox();
            LogUserBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(SignUpButton);
            panel1.Controls.Add(SignInButton);
            panel1.Controls.Add(LogPassBox);
            panel1.Controls.Add(LogUserBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(467, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 411);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 210);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 140);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Transparent;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Location = new Point(125, 330);
            SignUpButton.Margin = new Padding(0);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 26);
            SignUpButton.TabIndex = 4;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(125, 304);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(75, 23);
            SignInButton.TabIndex = 3;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // LogPassBox
            // 
            LogPassBox.Location = new Point(37, 228);
            LogPassBox.Name = "LogPassBox";
            LogPassBox.Size = new Size(249, 23);
            LogPassBox.TabIndex = 2;
            // 
            // LogUserBox
            // 
            LogUserBox.Location = new Point(37, 158);
            LogUserBox.Name = "LogUserBox";
            LogUserBox.Size = new Size(249, 23);
            LogUserBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 51);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "LoginUserControl";
            Size = new Size(783, 411);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button SignUpButton;
        private Button SignInButton;
        private TextBox LogPassBox;
        private TextBox LogUserBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
