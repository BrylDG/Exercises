namespace ParkNClick
{
    partial class AdminDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            MenuPanel = new Panel();
            UserLogsLabel = new Label();
            HomeLabel = new Label();
            panel4 = new Panel();
            label9 = new Label();
            LogoutButton = new Button();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            UserGrid = new DataGridView();
            SearchBox = new TextBox();
            label1 = new Label();
            MenuPanel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGrid).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.DarkSlateGray;
            MenuPanel.Controls.Add(UserLogsLabel);
            MenuPanel.Controls.Add(HomeLabel);
            MenuPanel.Controls.Add(panel4);
            MenuPanel.Controls.Add(LogoutButton);
            MenuPanel.Controls.Add(label8);
            MenuPanel.Controls.Add(flowLayoutPanel1);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(144, 442);
            MenuPanel.TabIndex = 4;
            // 
            // UserLogsLabel
            // 
            UserLogsLabel.AutoSize = true;
            UserLogsLabel.BackColor = Color.Transparent;
            UserLogsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserLogsLabel.ForeColor = Color.FromArgb(206, 186, 172);
            UserLogsLabel.Location = new Point(32, 243);
            UserLogsLabel.Name = "UserLogsLabel";
            UserLogsLabel.Size = new Size(73, 20);
            UserLogsLabel.TabIndex = 13;
            UserLogsLabel.Text = "User Logs";
            // 
            // HomeLabel
            // 
            HomeLabel.AutoSize = true;
            HomeLabel.BackColor = Color.Transparent;
            HomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeLabel.ForeColor = Color.White;
            HomeLabel.Location = new Point(32, 195);
            HomeLabel.Name = "HomeLabel";
            HomeLabel.Size = new Size(57, 20);
            HomeLabel.TabIndex = 12;
            HomeLabel.Text = "Parking";
            HomeLabel.Click += HomeLabel_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(label9);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 46);
            panel4.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(8, 7);
            label9.Name = "label9";
            label9.Size = new Size(128, 31);
            label9.TabIndex = 11;
            label9.Text = "00:00:00";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(134, 86, 82);
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.Snow;
            LogoutButton.Location = new Point(36, 384);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(72, 27);
            LogoutButton.TabIndex = 10;
            LogoutButton.Text = "Sign Out";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gainsboro;
            label8.Location = new Point(31, 131);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 0;
            label8.Text = "Administrator";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.GhostWhite;
            flowLayoutPanel1.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel1.BackgroundImage");
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel1.Location = new Point(36, 56);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(69, 67);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // UserGrid
            // 
            UserGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGrid.Location = new Point(171, 131);
            UserGrid.Name = "UserGrid";
            UserGrid.Size = new Size(579, 292);
            UserGrid.TabIndex = 7;
            UserGrid.CellContentClick += UserGrid_CellContentClick;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(171, 102);
            SearchBox.Name = "SearchBox";
            SearchBox.PlaceholderText = "Search";
            SearchBox.Size = new Size(193, 23);
            SearchBox.TabIndex = 6;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 40);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 5;
            label1.Text = "User Logs";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(206, 186, 172);
            ClientSize = new Size(780, 440);
            Controls.Add(UserGrid);
            Controls.Add(SearchBox);
            Controls.Add(label1);
            Controls.Add(MenuPanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private EditPanel editPanel1;
        private DetailPanel detailPanel1;
        private Panel MenuPanel;
        private Panel panel4;
        private Label label9;
        private Button LogoutButton;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label UserLogsLabel;
        private Label HomeLabel;
        private System.Windows.Forms.Timer timer1;
        private DataGridView UserGrid;
        private TextBox SearchBox;
        private Label label1;
    }
}