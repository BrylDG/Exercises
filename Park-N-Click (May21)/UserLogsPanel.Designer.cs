namespace ParkNClick
{
    partial class UserLogsPanel
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
            SearchBox = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 0;
            label1.Text = "User Logs";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(27, 101);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(193, 23);
            SearchBox.TabIndex = 1;
            SearchBox.Text = "Search";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(579, 292);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UserLogsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(206, 186, 172);
            Controls.Add(dataGridView1);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Name = "UserLogsPanel";
            Size = new Size(638, 442);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SearchBox;
        private DataGridView dataGridView1;
    }
}
