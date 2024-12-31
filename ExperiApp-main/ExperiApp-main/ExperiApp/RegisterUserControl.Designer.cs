namespace ExperiApp
{
    partial class RegisterUserControl
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
            RegConPassBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BackButton = new Button();
            RegisterButton = new Button();
            RegPassBox = new TextBox();
            RegUserBox = new TextBox();
            label1 = new Label();
            FirstNameBox = new TextBox();
            MiddleNameBox = new TextBox();
            FamilyNameBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(FamilyNameBox);
            panel1.Controls.Add(MiddleNameBox);
            panel1.Controls.Add(FirstNameBox);
            panel1.Controls.Add(RegConPassBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(RegPassBox);
            panel1.Controls.Add(RegUserBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 411);
            panel1.TabIndex = 1;
            // 
            // RegConPassBox
            // 
            RegConPassBox.Location = new Point(162, 298);
            RegConPassBox.Name = "RegConPassBox";
            RegConPassBox.Size = new Size(140, 23);
            RegConPassBox.TabIndex = 8;
            RegConPassBox.TextChanged += RegConPassBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 280);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 280);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 219);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Location = new Point(110, 364);
            BackButton.Margin = new Padding(0);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(97, 26);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back To Sign In";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(120, 338);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Sign Up";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RegPassBox
            // 
            RegPassBox.Location = new Point(16, 298);
            RegPassBox.Name = "RegPassBox";
            RegPassBox.Size = new Size(140, 23);
            RegPassBox.TabIndex = 2;
            // 
            // RegUserBox
            // 
            RegUserBox.Location = new Point(16, 237);
            RegUserBox.Name = "RegUserBox";
            RegUserBox.Size = new Size(286, 23);
            RegUserBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 49);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(16, 128);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(140, 23);
            FirstNameBox.TabIndex = 9;
            // 
            // MiddleNameBox
            // 
            MiddleNameBox.Location = new Point(162, 128);
            MiddleNameBox.Name = "MiddleNameBox";
            MiddleNameBox.Size = new Size(140, 23);
            MiddleNameBox.TabIndex = 10;
            // 
            // FamilyNameBox
            // 
            FamilyNameBox.Location = new Point(16, 183);
            FamilyNameBox.Name = "FamilyNameBox";
            FamilyNameBox.Size = new Size(286, 23);
            FamilyNameBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 110);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 110);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 13;
            label6.Text = "Middle Initial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 165);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 14;
            label7.Text = "Family Name";
            // 
            // RegisterUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            Controls.Add(panel1);
            Name = "RegisterUserControl";
            Size = new Size(783, 411);
            Load += RegisterUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button BackButton;
        private Button RegisterButton;
        private TextBox RegPassBox;
        private TextBox RegUserBox;
        private Label label1;
        private TextBox RegConPassBox;
        private Label label4;
        private TextBox MiddleNameBox;
        private TextBox FirstNameBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox FamilyNameBox;
    }
}
