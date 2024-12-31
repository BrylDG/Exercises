namespace ParkNClick
{
    partial class ParkInForm
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
            ParkInButton = new Button();
            label1 = new Label();
            panel4 = new Panel();
            BrandBox = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            TypeBox = new ComboBox();
            label3 = new Label();
            panel2 = new Panel();
            PlateBox = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            FlagDownBox = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            RateBox = new TextBox();
            label6 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // ParkInButton
            // 
            ParkInButton.Location = new Point(66, 282);
            ParkInButton.Margin = new Padding(4, 4, 4, 4);
            ParkInButton.Name = "ParkInButton";
            ParkInButton.Size = new Size(94, 29);
            ParkInButton.TabIndex = 26;
            ParkInButton.Text = "Park In";
            ParkInButton.UseVisualStyleBackColor = true;
            ParkInButton.Click += ParkInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 22;
            label1.Text = "Park In";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(BrandBox);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(10, 132);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 44);
            panel4.TabIndex = 25;
            // 
            // BrandBox
            // 
            BrandBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BrandBox.FormattingEnabled = true;
            BrandBox.Location = new Point(92, 8);
            BrandBox.Margin = new Padding(4, 4, 4, 4);
            BrandBox.Name = "BrandBox";
            BrandBox.Size = new Size(108, 28);
            BrandBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(9, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 1;
            label4.Text = "Brand";
            
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(TypeBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(10, 89);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 48);
            panel3.TabIndex = 24;
            // 
            // TypeBox
            // 
            TypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeBox.FormattingEnabled = true;
            TypeBox.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            TypeBox.Location = new Point(92, 8);
            TypeBox.Margin = new Padding(4, 4, 4, 4);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(108, 28);
            TypeBox.TabIndex = 2;
            TypeBox.SelectedIndexChanged += TypeBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(9, 10);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 1;
            label3.Text = "Type";
          
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(PlateBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(10, 45);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 48);
            panel2.TabIndex = 23;
            // 
            // PlateBox
            // 
            PlateBox.Location = new Point(92, 8);
            PlateBox.Margin = new Padding(4, 4, 4, 4);
            PlateBox.Name = "PlateBox";
            PlateBox.Size = new Size(108, 27);
            PlateBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(9, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 1;
            label2.Text = "Plate No.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(FlagDownBox);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(10, 176);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 45);
            panel1.TabIndex = 27;
            // 
            // FlagDownBox
            // 
            FlagDownBox.Location = new Point(92, 8);
            FlagDownBox.Margin = new Padding(4, 4, 4, 4);
            FlagDownBox.Name = "FlagDownBox";
            FlagDownBox.ReadOnly = true;
            FlagDownBox.Size = new Size(108, 27);
            FlagDownBox.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(9, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 1;
            label5.Text = "FlagDown";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(RateBox);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(10, 220);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 45);
            panel5.TabIndex = 28;
            // 
            // RateBox
            // 
            RateBox.Location = new Point(92, 8);
            RateBox.Margin = new Padding(4, 4, 4, 4);
            RateBox.Name = "RateBox";
            RateBox.ReadOnly = true;
            RateBox.Size = new Size(108, 27);
            RateBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(9, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 19);
            label6.TabIndex = 1;
            label6.Text = "Rate";
            // 
            // ParkInForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(230, 326);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(ParkInButton);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 4, 4, 4);
            Name = "ParkInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkInForm";
            Load += ParkInForm_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button ParkInButton;
        public Label label1;
        public Panel panel4;
        public Label label4;
        public Panel panel3;
        public ComboBox TypeBox;
        public Label label3;
        public Panel panel2;
        public TextBox PlateBox;
        public Label label2;
        public ComboBox BrandBox;
        public Panel panel1;
        public TextBox FlagDownBox;
        public Label label5;
        public Panel panel5;
        public TextBox RateBox;
        public Label label6;
    }
}