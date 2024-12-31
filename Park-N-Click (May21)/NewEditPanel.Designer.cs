namespace ParkNClick
{
    partial class NewEditPanel
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
            label1 = new Label();
            panel4 = new Panel();
            editPVehicleBrand = new ComboBox();
            label4 = new Label();
            panel3 = new Panel();
            editPVehicleType = new ComboBox();
            label3 = new Label();
            panel5 = new Panel();
            editPPlateNumber = new TextBox();
            label2 = new Label();
            DoneButton = new Button();
            CancelButton = new Button();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(49, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 29);
            label1.TabIndex = 15;
            label1.Text = "Edit Details";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(editPVehicleBrand);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(18, 191);
            panel4.Margin = new Padding(4, 4, 4, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 52);
            panel4.TabIndex = 14;
            // 
            // editPVehicleBrand
            // 
            editPVehicleBrand.FormattingEnabled = true;
            editPVehicleBrand.Location = new Point(74, 14);
            editPVehicleBrand.Margin = new Padding(4, 4, 4, 4);
            editPVehicleBrand.Name = "editPVehicleBrand";
            editPVehicleBrand.Size = new Size(128, 28);
            editPVehicleBrand.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(9, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 19);
            label4.TabIndex = 1;
            label4.Text = "Brand";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(editPVehicleType);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(18, 131);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 52);
            panel3.TabIndex = 13;
            // 
            // editPVehicleType
            // 
            editPVehicleType.FormattingEnabled = true;
            editPVehicleType.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            editPVehicleType.Location = new Point(74, 14);
            editPVehicleType.Margin = new Padding(4, 4, 4, 4);
            editPVehicleType.Name = "editPVehicleType";
            editPVehicleType.Size = new Size(128, 28);
            editPVehicleType.TabIndex = 2;
            editPVehicleType.SelectedIndexChanged += EPTypeBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(9, 16);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(editPPlateNumber);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(18, 71);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(206, 52);
            panel5.TabIndex = 12;
            // 
            // editPPlateNumber
            // 
            editPPlateNumber.Location = new Point(89, 14);
            editPPlateNumber.Margin = new Padding(4, 4, 4, 4);
            editPPlateNumber.Name = "editPPlateNumber";
            editPPlateNumber.Size = new Size(113, 27);
            editPPlateNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(5, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 1;
            label2.Text = "Plate No.";
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(130, 280);
            DoneButton.Margin = new Padding(4, 4, 4, 4);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(94, 29);
            DoneButton.TabIndex = 16;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += Edit_PanelButtons;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(18, 280);
            CancelButton.Margin = new Padding(4, 4, 4, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += Edit_PanelButtons;
            // 
            // NewEditPanel
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(CancelButton);
            Controls.Add(DoneButton);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NewEditPanel";
            Size = new Size(238, 332);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel5;
        private Label label2;
        private Button DoneButton;
        public ComboBox editPVehicleBrand;
        public ComboBox editPVehicleType;
        public TextBox editPPlateNumber;
        private Button CancelButton;
    }
}
