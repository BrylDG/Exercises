namespace ParkNClick
{
    partial class NewDashboard
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
            panel1 = new Panel();
            SignOutPanel = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            UserLogsButton = new Button();
            TransactionsButton = new Button();
            ParkButton = new Button();
            panel2 = new Panel();
            floor12 = new Floor1();
            panel1.SuspendLayout();
            SignOutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 201, 149);
            panel1.Controls.Add(SignOutPanel);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(UserLogsButton);
            panel1.Controls.Add(TransactionsButton);
            panel1.Controls.Add(ParkButton);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 688);
            panel1.TabIndex = 0;
            // 
            // SignOutPanel
            // 
            SignOutPanel.BackColor = Color.MediumSeaGreen;
            SignOutPanel.Controls.Add(label1);
            SignOutPanel.Location = new Point(0, 643);
            SignOutPanel.Name = "SignOutPanel";
            SignOutPanel.Size = new Size(197, 39);
            SignOutPanel.TabIndex = 5;
            SignOutPanel.Paint += SignOutPanel_Paint;
            SignOutPanel.MouseClick += SignOut;
            SignOutPanel.MouseLeave += Out;
            SignOutPanel.MouseHover += Hover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 14);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Sign Out";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(197, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1070, 685);
            panel3.TabIndex = 2;
            // 
            // UserLogsButton
            // 
            UserLogsButton.FlatAppearance.BorderSize = 0;
            UserLogsButton.FlatStyle = FlatStyle.Flat;
            UserLogsButton.Location = new Point(0, 340);
            UserLogsButton.Name = "UserLogsButton";
            UserLogsButton.Size = new Size(200, 53);
            UserLogsButton.TabIndex = 4;
            UserLogsButton.Text = "User Logs";
            UserLogsButton.UseVisualStyleBackColor = true;
            // 
            // TransactionsButton
            // 
            TransactionsButton.FlatAppearance.BorderSize = 0;
            TransactionsButton.FlatStyle = FlatStyle.Flat;
            TransactionsButton.Location = new Point(0, 290);
            TransactionsButton.Name = "TransactionsButton";
            TransactionsButton.Size = new Size(200, 53);
            TransactionsButton.TabIndex = 3;
            TransactionsButton.Text = "Transactions";
            TransactionsButton.UseVisualStyleBackColor = true;
            // 
            // ParkButton
            // 
            ParkButton.BackgroundImageLayout = ImageLayout.None;
            ParkButton.FlatAppearance.BorderSize = 0;
            ParkButton.FlatStyle = FlatStyle.Flat;
            ParkButton.Location = new Point(0, 241);
            ParkButton.Name = "ParkButton";
            ParkButton.Size = new Size(200, 53);
            ParkButton.TabIndex = 2;
            ParkButton.Text = "Parking";
            ParkButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(23, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 150);
            panel2.TabIndex = 1;
            // 
            // floor12
            // 
            floor12.Location = new Point(197, 0);
            floor12.Name = "floor12";
            floor12.Size = new Size(1070, 685);
            floor12.slot = null;
            floor12.TabIndex = 1;
            // 
            // NewDashboard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1264, 681);
            Controls.Add(floor12);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Park N' Click!";
            Load += NewDashboard_Load;
            panel1.ResumeLayout(false);
            SignOutPanel.ResumeLayout(false);
            SignOutPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void floor2_clicked(object sender, EventArgs e)
        {
            floor11.Hide();
            floor21.Show();
        }
        private void floor1_clicked(object sender, EventArgs e)
        {
            floor21.Hide();
            floor11.Show();
        }
        private void button_Click(object sender, EventArgs e)
        { 
            PIForm.Show();
        }

        #endregion

        ParkInForm PIForm = new ParkInForm();
        private Panel panel1;
        private Button ParkButton;
        private Panel panel2;
        private Button UserLogsButton;
        private Button TransactionsButton;
        private Panel panel3;
        private Floor2 floor21;
        private Floor1 floor11;
        private Panel SignOutPanel;
        private Label label1;
        private Floor1 floor12;
    }
}