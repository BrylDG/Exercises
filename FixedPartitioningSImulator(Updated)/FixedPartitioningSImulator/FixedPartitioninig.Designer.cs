namespace FixedPartitioningSImulator
{
    partial class FixedPartitioninig
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
            MemorySizeBox = new TextBox();
            ProcessCountBox = new TextBox();
            GenerateButton = new Button();
            MemoryPanel = new Panel();
            OSPanel = new Panel();
            label1 = new Label();
            InputSectionBox = new GroupBox();
            panel1 = new Panel();
            ListLabel = new Label();
            CalculateButton = new Button();
            ResetButton = new Button();
            panel6 = new Panel();
            label5 = new Label();
            label3 = new Label();
            TickTockLabel = new Label();
            panel3 = new Panel();
            PartitionLabel = new Label();
            label2 = new Label();
            panel4 = new Panel();
            WaitingListLabel = new Label();
            label4 = new Label();
            panel5 = new Panel();
            ProcessLabel = new Label();
            panel7 = new Panel();
            Processes = new Label();
            label6 = new Label();
            OSPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // MemorySizeBox
            // 
            MemorySizeBox.Location = new Point(12, 47);
            MemorySizeBox.Name = "MemorySizeBox";
            MemorySizeBox.PlaceholderText = "Memory Size";
            MemorySizeBox.Size = new Size(135, 23);
            MemorySizeBox.TabIndex = 0;
            // 
            // ProcessCountBox
            // 
            ProcessCountBox.Location = new Point(12, 87);
            ProcessCountBox.Name = "ProcessCountBox";
            ProcessCountBox.PlaceholderText = "Process Count";
            ProcessCountBox.Size = new Size(135, 23);
            ProcessCountBox.TabIndex = 1;
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.FromArgb(13, 27, 42);
            GenerateButton.FlatAppearance.BorderSize = 0;
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(153, 87);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(75, 23);
            GenerateButton.TabIndex = 3;
            GenerateButton.Text = "Generate";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // MemoryPanel
            // 
            MemoryPanel.BackColor = Color.FromArgb(224, 225, 221);
            MemoryPanel.BorderStyle = BorderStyle.FixedSingle;
            MemoryPanel.Location = new Point(1059, 167);
            MemoryPanel.Name = "MemoryPanel";
            MemoryPanel.Size = new Size(200, 494);
            MemoryPanel.TabIndex = 5;
            // 
            // OSPanel
            // 
            OSPanel.BackColor = Color.FromArgb(13, 27, 42);
            OSPanel.BorderStyle = BorderStyle.FixedSingle;
            OSPanel.Controls.Add(label1);
            OSPanel.ForeColor = Color.White;
            OSPanel.Location = new Point(1059, 138);
            OSPanel.Name = "OSPanel";
            OSPanel.Size = new Size(200, 30);
            OSPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 5);
            label1.Name = "label1";
            label1.Size = new Size(159, 17);
            label1.TabIndex = 0;
            label1.Text = "Operating System (100kb)";
            // 
            // InputSectionBox
            // 
            InputSectionBox.BackColor = Color.FromArgb(224, 225, 221);
            InputSectionBox.Location = new Point(12, 138);
            InputSectionBox.Name = "InputSectionBox";
            InputSectionBox.Size = new Size(857, 329);
            InputSectionBox.TabIndex = 6;
            InputSectionBox.TabStop = false;
            InputSectionBox.Text = "Input Section";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(73, 90, 114);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ListLabel);
            panel1.Location = new Point(12, 473);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 188);
            panel1.TabIndex = 7;
            // 
            // ListLabel
            // 
            ListLabel.AutoSize = true;
            ListLabel.BackColor = Color.Transparent;
            ListLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListLabel.ForeColor = Color.White;
            ListLabel.Location = new Point(15, 20);
            ListLabel.Name = "ListLabel";
            ListLabel.Size = new Size(0, 13);
            ListLabel.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.BackColor = Color.FromArgb(13, 27, 42);
            CalculateButton.FlatAppearance.BorderSize = 0;
            CalculateButton.FlatStyle = FlatStyle.Flat;
            CalculateButton.ForeColor = Color.White;
            CalculateButton.Location = new Point(234, 87);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 8;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = false;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.BackColor = Color.FromArgb(13, 27, 42);
            ResetButton.FlatAppearance.BorderSize = 0;
            ResetButton.FlatStyle = FlatStyle.Flat;
            ResetButton.ForeColor = Color.White;
            ResetButton.Location = new Point(315, 87);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(75, 23);
            ResetButton.TabIndex = 10;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = false;
            ResetButton.Click += ResetButton_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(119, 141, 169);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(TickTockLabel);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(1059, 111);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 30);
            panel6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(67, 5);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 10;
            label5.Text = "msec";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Counter: ";
            // 
            // TickTockLabel
            // 
            TickTockLabel.AutoSize = true;
            TickTockLabel.BackColor = Color.Transparent;
            TickTockLabel.Location = new Point(57, 5);
            TickTockLabel.Name = "TickTockLabel";
            TickTockLabel.Size = new Size(13, 15);
            TickTockLabel.TabIndex = 9;
            TickTockLabel.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(119, 141, 169);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(PartitionLabel);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(473, 473);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 188);
            panel3.TabIndex = 8;
            // 
            // PartitionLabel
            // 
            PartitionLabel.AutoSize = true;
            PartitionLabel.BackColor = Color.Transparent;
            PartitionLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PartitionLabel.ForeColor = Color.White;
            PartitionLabel.Location = new Point(13, 20);
            PartitionLabel.Name = "PartitionLabel";
            PartitionLabel.Size = new Size(0, 13);
            PartitionLabel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(605, 20);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(187, 198, 212);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(WaitingListLabel);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(694, 473);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 188);
            panel4.TabIndex = 9;
            // 
            // WaitingListLabel
            // 
            WaitingListLabel.AutoSize = true;
            WaitingListLabel.BackColor = Color.Transparent;
            WaitingListLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WaitingListLabel.ForeColor = Color.Black;
            WaitingListLabel.Location = new Point(13, 20);
            WaitingListLabel.Name = "WaitingListLabel";
            WaitingListLabel.Size = new Size(0, 17);
            WaitingListLabel.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(605, 20);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 225, 221);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ProcessLabel);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(875, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(178, 523);
            panel5.TabIndex = 6;
            // 
            // ProcessLabel
            // 
            ProcessLabel.AutoSize = true;
            ProcessLabel.Location = new Point(3, 55);
            ProcessLabel.Name = "ProcessLabel";
            ProcessLabel.Size = new Size(0, 15);
            ProcessLabel.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(119, 141, 169);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(Processes);
            panel7.Location = new Point(-1, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(187, 44);
            panel7.TabIndex = 7;
            // 
            // Processes
            // 
            Processes.AutoSize = true;
            Processes.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Processes.ForeColor = Color.White;
            Processes.Location = new Point(39, 5);
            Processes.Name = "Processes";
            Processes.Size = new Size(108, 25);
            Processes.TabIndex = 0;
            Processes.Text = "Processing:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(303, 16);
            label6.Name = "label6";
            label6.Size = new Size(751, 55);
            label6.TabIndex = 11;
            label6.Text = "FIXED PARTITION SIMULATOR";
            // 
            // FixedPartitioninig
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(59, 68, 66);
            ClientSize = new Size(1314, 681);
            Controls.Add(label6);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(ResetButton);
            Controls.Add(CalculateButton);
            Controls.Add(panel1);
            Controls.Add(InputSectionBox);
            Controls.Add(OSPanel);
            Controls.Add(MemoryPanel);
            Controls.Add(GenerateButton);
            Controls.Add(ProcessCountBox);
            Controls.Add(MemorySizeBox);
            Controls.Add(panel3);
            Name = "FixedPartitioninig";
            Text = "FixedPartitioninig";
            Load += FixedPartitioninig_Load;
            OSPanel.ResumeLayout(false);
            OSPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MemorySizeBox;
        private TextBox ProcessCountBox;
        private Button GenerateButton;
        private Panel MemoryPanel;
        private Panel OSPanel;
        private GroupBox InputSectionBox;
        private Label label1;
        private Panel panel1;
        private Label ListLabel;
        private Button CalculateButton;
        private Button ResetButton;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private Label WaitingListLabel;
        private Label PartitionLabel;
        private Panel panel6;
        private Label label3;
        private Label TickTockLabel;
        private Panel panel5;
        private Panel panel7;
        private Label Processes;
        private Label ProcessLabel;
        private Label label5;
        private Label label6;
    }
}