namespace ParkingApp
{
    partial class DetailPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            button1 = new Button();
            typeDisplay = new Label();
            brandDisplay = new Label();
            TIDisplay = new Label();
            TODisplay = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            InvalidTimeOut = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(388, 127);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 0;
            button1.Text = "Time Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // typeDisplay
            // 
            typeDisplay.AutoSize = true;
            typeDisplay.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeDisplay.Location = new Point(44, 1);
            typeDisplay.Name = "typeDisplay";
            typeDisplay.Size = new Size(55, 20);
            typeDisplay.TabIndex = 1;
            typeDisplay.Text = "Toyota";
            typeDisplay.Click += typeDisplay_Click;
            // 
            // brandDisplay
            // 
            brandDisplay.AutoSize = true;
            brandDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandDisplay.Location = new Point(37, 1);
            brandDisplay.Name = "brandDisplay";
            brandDisplay.Size = new Size(51, 21);
            brandDisplay.TabIndex = 2;
            brandDisplay.Text = "label1";
            // 
            // TIDisplay
            // 
            TIDisplay.AutoSize = true;
            TIDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TIDisplay.Location = new Point(3, 1);
            TIDisplay.Name = "TIDisplay";
            TIDisplay.Size = new Size(51, 21);
            TIDisplay.TabIndex = 3;
            TIDisplay.Text = "label1";
            // 
            // TODisplay
            // 
            TODisplay.AutoSize = true;
            TODisplay.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TODisplay.Location = new Point(14, 0);
            TODisplay.Name = "TODisplay";
            TODisplay.Size = new Size(139, 43);
            TODisplay.TabIndex = 4;
            TODisplay.Text = "YAN120";
            TODisplay.Click += TODisplay_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TODisplay);
            panel1.Location = new Point(18, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 50);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 24);
            panel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 19;
            label1.Text = "TYPE:";
            label1.Click += label1_Click_2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(typeDisplay);
            panel3.Location = new Point(72, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 24);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(brandDisplay);
            panel4.Location = new Point(99, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(133, 24);
            panel4.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(18, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(82, 24);
            panel5.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 19;
            label3.Text = "BRAND:";
            label3.Click += label3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Snow;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TIDisplay);
            panel6.Location = new Point(297, 44);
            panel6.Name = "panel6";
            panel6.Size = new Size(199, 24);
            panel6.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gainsboro;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(215, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(108, 24);
            panel7.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 19;
            label4.Text = "TIME IN:";
            // 
            // InvalidTimeOut
            // 
            InvalidTimeOut.AutoSize = true;
            InvalidTimeOut.Font = new Font("Agency FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvalidTimeOut.ForeColor = Color.Red;
            InvalidTimeOut.Location = new Point(215, 18);
            InvalidTimeOut.Name = "InvalidTimeOut";
            InvalidTimeOut.Size = new Size(0, 20);
            InvalidTimeOut.TabIndex = 22;
            // 
            // DetailPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(InvalidTimeOut);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(10, 20, 10, 10);
            Name = "DetailPanel";
            Size = new Size(513, 170);
            Load += DetailPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Label typeDisplay;
        public Label brandDisplay;
        public Label TIDisplay;
        public Label TODisplay;
        public Panel panel1;
        public Panel panel2;
        public Label label1;
        public Panel panel3;
        public Panel panel4;
        public Panel panel5;
        public Label label3;
        public Panel panel6;
        public Panel panel7;
        public Label label4;
        private Label InvalidTimeOut;
    }
}
