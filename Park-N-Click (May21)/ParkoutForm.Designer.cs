using Microsoft.Data.SqlClient;

namespace ParkNClick
{
    partial class ParkoutForm
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
        /// 

        private void InitializeComponent()
        {
            panel11 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel5 = new Panel();
            vehicleTimeInPanel = new Panel();
            VDtime = new Label();
            label5 = new Label();
            panel4 = new Panel();
            vehicleBrandPanel = new Panel();
            VDbrand = new Label();
            label4 = new Label();
            panel3 = new Panel();
            vehicleTypePanel = new Panel();
            VDtype = new Label();
            label3 = new Label();
            panel2 = new Panel();
            plateNumberPanel = new Panel();
            VDplate = new Label();
            label2 = new Label();
            newEditPanel1 = new NewEditPanel();
            panel5.SuspendLayout();
            vehicleTimeInPanel.SuspendLayout();
            panel4.SuspendLayout();
            vehicleBrandPanel.SuspendLayout();
            panel3.SuspendLayout();
            vehicleTypePanel.SuspendLayout();
            panel2.SuspendLayout();
            plateNumberPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gold;
            panel11.Location = new Point(6, 222);
            panel11.Name = "panel11";
            panel11.Size = new Size(177, 2);
            panel11.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gold;
            panel6.Location = new Point(4, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 2);
            panel6.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(95, 234);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Parkout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 18;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += editButtonClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 13;
            label1.Text = "Slot Details";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(vehicleTimeInPanel);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(7, 173);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 42);
            panel5.TabIndex = 17;
            // 
            // vehicleTimeInPanel
            // 
            vehicleTimeInPanel.BackColor = Color.LightGray;
            vehicleTimeInPanel.Controls.Add(VDtime);
            vehicleTimeInPanel.Location = new Point(69, 3);
            vehicleTimeInPanel.Name = "vehicleTimeInPanel";
            vehicleTimeInPanel.Size = new Size(99, 35);
            vehicleTimeInPanel.TabIndex = 14;
            // 
            // VDtime
            // 
            VDtime.AutoSize = true;
            VDtime.BackColor = Color.Transparent;
            VDtime.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDtime.ForeColor = SystemColors.ActiveCaptionText;
            VDtime.Location = new Point(25, 10);
            VDtime.Name = "VDtime";
            VDtime.Size = new Size(0, 15);
            VDtime.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(7, 14);
            label5.Name = "label5";
            label5.Size = new Size(49, 16);
            label5.TabIndex = 1;
            label5.Text = "Time in";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(vehicleBrandPanel);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(7, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 42);
            panel4.TabIndex = 16;
            // 
            // vehicleBrandPanel
            // 
            vehicleBrandPanel.BackColor = Color.LightGray;
            vehicleBrandPanel.Controls.Add(VDbrand);
            vehicleBrandPanel.Location = new Point(69, 3);
            vehicleBrandPanel.Name = "vehicleBrandPanel";
            vehicleBrandPanel.Size = new Size(99, 35);
            vehicleBrandPanel.TabIndex = 13;
            // 
            // VDbrand
            // 
            VDbrand.AutoSize = true;
            VDbrand.BackColor = Color.Transparent;
            VDbrand.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDbrand.ForeColor = SystemColors.ActiveCaptionText;
            VDbrand.Location = new Point(27, 10);
            VDbrand.Name = "VDbrand";
            VDbrand.Size = new Size(0, 15);
            VDbrand.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(7, 13);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 1;
            label4.Text = "Brand";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(vehicleTypePanel);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(7, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 42);
            panel3.TabIndex = 15;
            // 
            // vehicleTypePanel
            // 
            vehicleTypePanel.BackColor = Color.LightGray;
            vehicleTypePanel.Controls.Add(VDtype);
            vehicleTypePanel.Location = new Point(69, 3);
            vehicleTypePanel.Name = "vehicleTypePanel";
            vehicleTypePanel.Size = new Size(99, 35);
            vehicleTypePanel.TabIndex = 13;
            // 
            // VDtype
            // 
            VDtype.AutoSize = true;
            VDtype.BackColor = Color.Transparent;
            VDtype.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDtype.ForeColor = SystemColors.ActiveCaptionText;
            VDtype.Location = new Point(27, 10);
            VDtype.Name = "VDtype";
            VDtype.Size = new Size(0, 15);
            VDtype.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(7, 13);
            label3.Name = "label3";
            label3.Size = new Size(34, 16);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(plateNumberPanel);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(7, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 42);
            panel2.TabIndex = 14;
            // 
            // plateNumberPanel
            // 
            plateNumberPanel.BackColor = Color.LightGray;
            plateNumberPanel.Controls.Add(VDplate);
            plateNumberPanel.Location = new Point(69, 3);
            plateNumberPanel.Name = "plateNumberPanel";
            plateNumberPanel.Size = new Size(99, 35);
            plateNumberPanel.TabIndex = 12;
            // 
            // VDplate
            // 
            VDplate.AutoSize = true;
            VDplate.BackColor = Color.Transparent;
            VDplate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDplate.ForeColor = SystemColors.ActiveCaptionText;
            VDplate.Location = new Point(28, 10);
            VDplate.Name = "VDplate";
            VDplate.Size = new Size(0, 15);
            VDplate.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(7, 13);
            label2.Name = "label2";
            label2.Size = new Size(61, 16);
            label2.TabIndex = 1;
            label2.Text = "Plate No.";
            // 
            // newEditPanel1
            // 
            newEditPanel1.Location = new Point(-7, -1);
            newEditPanel1.Margin = new Padding(4, 4, 4, 4);
            newEditPanel1.Name = "newEditPanel1";
            newEditPanel1.Size = new Size(190, 266);
            newEditPanel1.slot = null;
            newEditPanel1.TabIndex = 22;
            newEditPanel1.Visible = false;
            newEditPanel1.Load += EPVehicleDetails;
            // 
            // ParkoutForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(184, 261);
            Controls.Add(panel11);
            Controls.Add(panel6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(newEditPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ParkoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkoutForm";
            Load += ParkoutForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            vehicleTimeInPanel.ResumeLayout(false);
            vehicleTimeInPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            vehicleBrandPanel.ResumeLayout(false);
            vehicleBrandPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            vehicleTypePanel.ResumeLayout(false);
            vehicleTypePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            plateNumberPanel.ResumeLayout(false);
            plateNumberPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        public Panel panel11;
        public Panel panel6;
        public Button button2;
        public Button button1;
        public Label label1;
        public Panel panel5;
        public Panel vehicleTimeInPanel;
        public Label VDtime;
        public Label label5;
        public Panel panel4;
        public Panel vehicleBrandPanel;
        public Label VDbrand;
        public Label label4;
        public Panel panel3;
        public Panel vehicleTypePanel;
        public Label VDtype;
        public Label label3;
        public Panel panel2;
        public Panel plateNumberPanel;
        public Label VDplate;
        public Label label2;
        private NewEditPanel newEditPanel1;
    }
}