namespace ParkNClick
{
    partial class DetailPanel
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
            vehiclePanel = new Panel();
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
            vehiclePanel.SuspendLayout();
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
            // vehiclePanel
            // 
            vehiclePanel.BackColor = Color.Gainsboro;
            vehiclePanel.Controls.Add(panel11);
            vehiclePanel.Controls.Add(panel6);
            vehiclePanel.Controls.Add(button2);
            vehiclePanel.Controls.Add(button1);
            vehiclePanel.Controls.Add(label1);
            vehiclePanel.Controls.Add(panel5);
            vehiclePanel.Controls.Add(panel4);
            vehiclePanel.Controls.Add(panel3);
            vehiclePanel.Controls.Add(panel2);
            vehiclePanel.Location = new Point(3, 3);
            vehiclePanel.Name = "vehiclePanel";
            vehiclePanel.Size = new Size(177, 293);
            vehiclePanel.TabIndex = 0;
            vehiclePanel.Paint += vehiclePanel_Paint;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gold;
            panel11.Location = new Point(2, 222);
            panel11.Name = "panel11";
            panel11.Size = new Size(177, 2);
            panel11.TabIndex = 12;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gold;
            panel6.Location = new Point(0, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 2);
            panel6.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(92, 245);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Parkout";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(10, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Detail";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gray;
            panel5.Controls.Add(vehicleTimeInPanel);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 173);
            panel5.Name = "panel5";
            panel5.Size = new Size(171, 42);
            panel5.TabIndex = 8;
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
            panel4.Location = new Point(3, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(171, 42);
            panel4.TabIndex = 7;
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
            panel3.Location = new Point(3, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(171, 42);
            panel3.TabIndex = 6;
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
            panel2.Location = new Point(3, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 42);
            panel2.TabIndex = 5;
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
            VDplate.Click += VDplate_Click;
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
            // DetailPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(vehiclePanel);
            Name = "DetailPanel";
            Size = new Size(183, 299);
            vehiclePanel.ResumeLayout(false);
            vehiclePanel.PerformLayout();
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
        }

        #endregion

        public Panel vehiclePanel;
        public Label label1;
        public Label label2;
        public Panel panel5;
        public Label label5;
        public Panel panel4;
        public Label label4;
        public Panel panel3;
        public Label label3;
        public Panel panel2;
        public Button button2;
        public Button button1;
        public Panel panel6;
        public Panel vehicleTimeInPanel;
        public Panel vehicleBrandPanel;
        public Panel vehicleTypePanel;
        public Panel plateNumberPanel;
        public Panel panel11;
        public Label VDtime;
        public Label VDbrand;
        public Label VDtype;
        public Label VDplate;
    }
}
