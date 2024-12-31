namespace ParkNClick
{
    partial class AdminDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDB));
            MenuPanel = new Panel();
            UserLogsLabel = new Label();
            HomeLabel = new Label();
            panel4 = new Panel();
            label9 = new Label();
            LogoutButton = new Button();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TypePanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label5 = new Label();
            label16 = new Label();
            FlagdownPanel = new Panel();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label6 = new Label();
            label17 = new Label();
            RatePanel = new Panel();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label7 = new Label();
            label18 = new Label();
            ParkInPanel = new Panel();
            button1 = new Button();
            label4 = new Label();
            TypeCB = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            PlateNoBox = new TextBox();
            BrandCB = new ComboBox();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            DatabasePanel = new Panel();
            dataTable = new DataGridView();
            txtSearchBox = new TextBox();
            dataView = new DataGridView();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel5 = new Panel();
            DoneButton = new Button();
            panel11 = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            button3 = new Button();
            label11 = new Label();
            panel7 = new Panel();
            panel12 = new Panel();
            label31 = new Label();
            vehicleTimeInPanel = new Panel();
            VDtime = new Label();
            label27 = new Label();
            panel8 = new Panel();
            vehicleBrandPanel = new Panel();
            BrandDB = new ComboBox();
            VDbrand = new Label();
            label28 = new Label();
            panel9 = new Panel();
            vehicleTypePanel = new Panel();
            TypeDB = new ComboBox();
            VDtype = new Label();
            label29 = new Label();
            panel10 = new Panel();
            plateNumberPanel = new Panel();
            PlateTB = new TextBox();
            VDplate = new Label();
            label30 = new Label();
            MenuPanel.SuspendLayout();
            panel4.SuspendLayout();
            TypePanel.SuspendLayout();
            FlagdownPanel.SuspendLayout();
            RatePanel.SuspendLayout();
            ParkInPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            DatabasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel12.SuspendLayout();
            vehicleTimeInPanel.SuspendLayout();
            panel8.SuspendLayout();
            vehicleBrandPanel.SuspendLayout();
            panel9.SuspendLayout();
            vehicleTypePanel.SuspendLayout();
            panel10.SuspendLayout();
            plateNumberPanel.SuspendLayout();
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
            MenuPanel.TabIndex = 0;
            MenuPanel.Paint += MenuPanel_Paint;
            // 
            // UserLogsLabel
            // 
            UserLogsLabel.AutoSize = true;
            UserLogsLabel.BackColor = Color.Transparent;
            UserLogsLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserLogsLabel.ForeColor = Color.White;
            UserLogsLabel.Location = new Point(36, 246);
            UserLogsLabel.Name = "UserLogsLabel";
            UserLogsLabel.Size = new Size(73, 20);
            UserLogsLabel.TabIndex = 15;
            UserLogsLabel.Text = "User Logs";
            UserLogsLabel.Click += UserLogsLabel_Click;
            // 
            // HomeLabel
            // 
            HomeLabel.AutoSize = true;
            HomeLabel.BackColor = Color.Transparent;
            HomeLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeLabel.ForeColor = Color.PeachPuff;
            HomeLabel.Location = new Point(36, 198);
            HomeLabel.Name = "HomeLabel";
            HomeLabel.Size = new Size(57, 20);
            HomeLabel.TabIndex = 14;
            HomeLabel.Text = "Parking";
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
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // TypePanel
            // 
            TypePanel.BackColor = Color.SlateGray;
            TypePanel.Controls.Add(label15);
            TypePanel.Controls.Add(label14);
            TypePanel.Controls.Add(label13);
            TypePanel.Controls.Add(label12);
            TypePanel.Controls.Add(label5);
            TypePanel.Controls.Add(label16);
            TypePanel.Location = new Point(150, 12);
            TypePanel.Name = "TypePanel";
            TypePanel.Size = new Size(185, 111);
            TypePanel.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(70, 88);
            label15.Name = "label15";
            label15.Size = new Size(43, 15);
            label15.TabIndex = 11;
            label15.Text = "Sedan";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(77, 71);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 10;
            label14.Text = "Van";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(77, 55);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 9;
            label13.Text = "SUV";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(63, 37);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 8;
            label12.Text = "Motorbike";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(46, 11);
            label5.Name = "label5";
            label5.Size = new Size(88, 16);
            label5.TabIndex = 7;
            label5.Text = "Vehicle Type";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(9, 21);
            label16.Name = "label16";
            label16.Size = new Size(168, 15);
            label16.TabIndex = 12;
            label16.Text = "_______________________";
            label16.Click += label16_Click;
            // 
            // FlagdownPanel
            // 
            FlagdownPanel.BackColor = Color.LightSlateGray;
            FlagdownPanel.Controls.Add(label22);
            FlagdownPanel.Controls.Add(label21);
            FlagdownPanel.Controls.Add(label20);
            FlagdownPanel.Controls.Add(label19);
            FlagdownPanel.Controls.Add(label6);
            FlagdownPanel.Controls.Add(label17);
            FlagdownPanel.Location = new Point(341, 12);
            FlagdownPanel.Name = "FlagdownPanel";
            FlagdownPanel.Size = new Size(238, 111);
            FlagdownPanel.TabIndex = 2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.WhiteSmoke;
            label22.Location = new Point(100, 86);
            label22.Name = "label22";
            label22.Size = new Size(38, 15);
            label22.TabIndex = 17;
            label22.Text = "30.00";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.WhiteSmoke;
            label21.Location = new Point(100, 71);
            label21.Name = "label21";
            label21.Size = new Size(38, 15);
            label21.TabIndex = 16;
            label21.Text = "40.00";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.WhiteSmoke;
            label20.Location = new Point(100, 55);
            label20.Name = "label20";
            label20.Size = new Size(38, 15);
            label20.TabIndex = 15;
            label20.Text = "40.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.WhiteSmoke;
            label19.Location = new Point(100, 39);
            label19.Name = "label19";
            label19.Size = new Size(38, 15);
            label19.TabIndex = 14;
            label19.Text = "20.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(87, 11);
            label6.Name = "label6";
            label6.Size = new Size(70, 16);
            label6.TabIndex = 8;
            label6.Text = "Flagdown";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(32, 21);
            label17.Name = "label17";
            label17.Size = new Size(182, 15);
            label17.TabIndex = 13;
            label17.Text = "_________________________";
            // 
            // RatePanel
            // 
            RatePanel.BackColor = Color.LightSlateGray;
            RatePanel.Controls.Add(label26);
            RatePanel.Controls.Add(label25);
            RatePanel.Controls.Add(label24);
            RatePanel.Controls.Add(label23);
            RatePanel.Controls.Add(label7);
            RatePanel.Controls.Add(label18);
            RatePanel.Location = new Point(585, 12);
            RatePanel.Name = "RatePanel";
            RatePanel.Size = new Size(183, 111);
            RatePanel.TabIndex = 3;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.WhiteSmoke;
            label26.Location = new Point(66, 88);
            label26.Name = "label26";
            label26.Size = new Size(38, 15);
            label26.TabIndex = 18;
            label26.Text = "15.00";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.WhiteSmoke;
            label25.Location = new Point(67, 71);
            label25.Name = "label25";
            label25.Size = new Size(38, 15);
            label25.TabIndex = 17;
            label25.Text = "20.00";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Transparent;
            label24.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.WhiteSmoke;
            label24.Location = new Point(67, 54);
            label24.Name = "label24";
            label24.Size = new Size(38, 15);
            label24.TabIndex = 16;
            label24.Text = "20.00";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.WhiteSmoke;
            label23.Location = new Point(73, 38);
            label23.Name = "label23";
            label23.Size = new Size(31, 15);
            label23.TabIndex = 15;
            label23.Text = "5.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 11);
            label7.Name = "label7";
            label7.Size = new Size(36, 16);
            label7.TabIndex = 9;
            label7.Text = "Rate";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.WhiteSmoke;
            label18.Location = new Point(13, 21);
            label18.Name = "label18";
            label18.Size = new Size(161, 15);
            label18.TabIndex = 14;
            label18.Text = "______________________";
            // 
            // ParkInPanel
            // 
            ParkInPanel.BackColor = Color.DarkSlateGray;
            ParkInPanel.Controls.Add(button1);
            ParkInPanel.Controls.Add(label4);
            ParkInPanel.Controls.Add(TypeCB);
            ParkInPanel.Controls.Add(panel1);
            ParkInPanel.Controls.Add(PlateNoBox);
            ParkInPanel.Controls.Add(BrandCB);
            ParkInPanel.Controls.Add(panel2);
            ParkInPanel.Controls.Add(panel3);
            ParkInPanel.Location = new Point(150, 129);
            ParkInPanel.Margin = new Padding(1);
            ParkInPanel.Name = "ParkInPanel";
            ParkInPanel.Size = new Size(185, 300);
            ParkInPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(54, 215);
            button1.Name = "button1";
            button1.Size = new Size(85, 21);
            button1.TabIndex = 9;
            button1.Text = "Park In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(54, 11);
            label4.Name = "label4";
            label4.Size = new Size(80, 24);
            label4.TabIndex = 6;
            label4.Text = "Park In";
            // 
            // TypeCB
            // 
            TypeCB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeCB.ForeColor = Color.Black;
            TypeCB.FormattingEnabled = true;
            TypeCB.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            TypeCB.Location = new Point(50, 63);
            TypeCB.Margin = new Padding(2);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(128, 21);
            TypeCB.TabIndex = 0;
            TypeCB.SelectedIndexChanged += TypeCB_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(5, 63);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(79, 21);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(33, 14);
            label1.TabIndex = 4;
            label1.Text = "Type";
            label1.Click += label1_Click_1;
            // 
            // PlateNoBox
            // 
            PlateNoBox.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlateNoBox.Location = new Point(50, 168);
            PlateNoBox.Margin = new Padding(2);
            PlateNoBox.Name = "PlateNoBox";
            PlateNoBox.Size = new Size(128, 22);
            PlateNoBox.TabIndex = 2;
            // 
            // BrandCB
            // 
            BrandCB.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandCB.FormattingEnabled = true;
            BrandCB.Location = new Point(50, 117);
            BrandCB.Margin = new Padding(2);
            BrandCB.Name = "BrandCB";
            BrandCB.Size = new Size(128, 21);
            BrandCB.TabIndex = 1;
            BrandCB.SelectedIndexChanged += BrandCB_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(5, 117);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 21);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PeachPuff;
            label2.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(39, 14);
            label2.TabIndex = 5;
            label2.Text = "Brand";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(5, 168);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(79, 22);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 6;
            label3.Text = "Plate #";
            // 
            // DatabasePanel
            // 
            DatabasePanel.BackColor = Color.DarkSlateGray;
            DatabasePanel.Controls.Add(dataTable);
            DatabasePanel.Controls.Add(txtSearchBox);
            DatabasePanel.Controls.Add(dataView);
            DatabasePanel.Controls.Add(label10);
            DatabasePanel.Location = new Point(341, 129);
            DatabasePanel.Name = "DatabasePanel";
            DatabasePanel.Size = new Size(238, 300);
            DatabasePanel.TabIndex = 3;
            // 
            // dataTable
            // 
            dataTable.AllowUserToResizeColumns = false;
            dataTable.AllowUserToResizeRows = false;
            dataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTable.Location = new Point(15, 60);
            dataTable.Name = "dataTable";
            dataTable.RowHeadersWidth = 51;
            dataTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataTable.Size = new Size(209, 219);
            dataTable.TabIndex = 11;
            dataTable.CellClick += dataTable_CellClick;
            dataTable.CellContentClick += dataTable_CellContentClick;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBox.Location = new Point(15, 25);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "Search";
            txtSearchBox.Size = new Size(142, 20);
            txtSearchBox.TabIndex = 10;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            // 
            // dataView
            // 
            dataView.BackgroundColor = Color.DarkSlateGray;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Location = new Point(-8, -1);
            dataView.Margin = new Padding(3, 2, 3, 2);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.Size = new Size(251, 303);
            dataView.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gainsboro;
            label10.Location = new Point(75, 155);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 8;
            label10.Text = "database ari";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkSlateGray;
            panel5.Controls.Add(DoneButton);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel10);
            panel5.Location = new Point(585, 129);
            panel5.Name = "panel5";
            panel5.Size = new Size(183, 300);
            panel5.TabIndex = 4;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(56, 251);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(75, 23);
            DoneButton.TabIndex = 22;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = true;
            DoneButton.Click += DoneButton_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gold;
            panel11.Location = new Point(5, 228);
            panel11.Name = "panel11";
            panel11.Size = new Size(177, 2);
            panel11.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gold;
            panel6.Location = new Point(3, 39);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 2);
            panel6.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(95, 251);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Parkout";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 251);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gainsboro;
            label11.Location = new Point(42, 11);
            label11.Name = "label11";
            label11.Size = new Size(111, 19);
            label11.TabIndex = 13;
            label11.Text = "Vehicle Detail";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Controls.Add(panel12);
            panel7.Controls.Add(vehicleTimeInPanel);
            panel7.Controls.Add(label27);
            panel7.Location = new Point(6, 179);
            panel7.Name = "panel7";
            panel7.Size = new Size(171, 42);
            panel7.TabIndex = 17;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.Controls.Add(label31);
            panel12.Location = new Point(155, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(13, 35);
            panel12.TabIndex = 15;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.BackColor = Color.Transparent;
            label31.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = SystemColors.ActiveCaptionText;
            label31.Location = new Point(4, 11);
            label31.Name = "label31";
            label31.Size = new Size(0, 14);
            label31.TabIndex = 14;
            // 
            // vehicleTimeInPanel
            // 
            vehicleTimeInPanel.BackColor = Color.LightGray;
            vehicleTimeInPanel.Controls.Add(VDtime);
            vehicleTimeInPanel.Location = new Point(69, 3);
            vehicleTimeInPanel.Name = "vehicleTimeInPanel";
            vehicleTimeInPanel.Size = new Size(99, 35);
            vehicleTimeInPanel.TabIndex = 14;
            vehicleTimeInPanel.Paint += vehicleTimeInPanel_Paint;
            // 
            // VDtime
            // 
            VDtime.AutoSize = true;
            VDtime.BackColor = Color.Transparent;
            VDtime.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDtime.ForeColor = SystemColors.ActiveCaptionText;
            VDtime.Location = new Point(4, 11);
            VDtime.Name = "VDtime";
            VDtime.Size = new Size(0, 14);
            VDtime.TabIndex = 14;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.ButtonHighlight;
            label27.Location = new Point(7, 14);
            label27.Name = "label27";
            label27.Size = new Size(49, 16);
            label27.TabIndex = 1;
            label27.Text = "Time in";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Controls.Add(vehicleBrandPanel);
            panel8.Controls.Add(label28);
            panel8.Location = new Point(6, 135);
            panel8.Name = "panel8";
            panel8.Size = new Size(171, 42);
            panel8.TabIndex = 16;
            // 
            // vehicleBrandPanel
            // 
            vehicleBrandPanel.BackColor = Color.LightGray;
            vehicleBrandPanel.Controls.Add(BrandDB);
            vehicleBrandPanel.Controls.Add(VDbrand);
            vehicleBrandPanel.Location = new Point(69, 3);
            vehicleBrandPanel.Name = "vehicleBrandPanel";
            vehicleBrandPanel.Size = new Size(99, 35);
            vehicleBrandPanel.TabIndex = 13;
            // 
            // BrandDB
            // 
            BrandDB.FormattingEnabled = true;
            BrandDB.Location = new Point(5, 7);
            BrandDB.Name = "BrandDB";
            BrandDB.Size = new Size(90, 23);
            BrandDB.TabIndex = 16;
            BrandDB.SelectedIndexChanged += BrandDB_SelectedIndexChanged;
            // 
            // VDbrand
            // 
            VDbrand.AutoSize = true;
            VDbrand.BackColor = Color.Transparent;
            VDbrand.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDbrand.ForeColor = SystemColors.ActiveCaptionText;
            VDbrand.Location = new Point(32, 10);
            VDbrand.Name = "VDbrand";
            VDbrand.Size = new Size(0, 15);
            VDbrand.TabIndex = 14;
            VDbrand.Click += label32_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = SystemColors.ButtonHighlight;
            label28.Location = new Point(7, 13);
            label28.Name = "label28";
            label28.Size = new Size(41, 16);
            label28.TabIndex = 1;
            label28.Text = "Brand";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkGray;
            panel9.Controls.Add(vehicleTypePanel);
            panel9.Controls.Add(label29);
            panel9.Location = new Point(6, 91);
            panel9.Name = "panel9";
            panel9.Size = new Size(171, 42);
            panel9.TabIndex = 15;
            // 
            // vehicleTypePanel
            // 
            vehicleTypePanel.BackColor = Color.LightGray;
            vehicleTypePanel.Controls.Add(TypeDB);
            vehicleTypePanel.Controls.Add(VDtype);
            vehicleTypePanel.Location = new Point(69, 3);
            vehicleTypePanel.Name = "vehicleTypePanel";
            vehicleTypePanel.Size = new Size(99, 35);
            vehicleTypePanel.TabIndex = 13;
            // 
            // TypeDB
            // 
            TypeDB.FormattingEnabled = true;
            TypeDB.Items.AddRange(new object[] { "Motorbike", "SUV", "Sedan", "Van" });
            TypeDB.Location = new Point(5, 7);
            TypeDB.Name = "TypeDB";
            TypeDB.Size = new Size(90, 23);
            TypeDB.TabIndex = 15;
            TypeDB.SelectedIndexChanged += TypeDB_SelectedIndexChanged;
            // 
            // VDtype
            // 
            VDtype.AutoSize = true;
            VDtype.BackColor = Color.Transparent;
            VDtype.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDtype.ForeColor = SystemColors.ActiveCaptionText;
            VDtype.Location = new Point(32, 10);
            VDtype.Name = "VDtype";
            VDtype.Size = new Size(0, 15);
            VDtype.TabIndex = 14;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = SystemColors.ButtonHighlight;
            label29.Location = new Point(7, 13);
            label29.Name = "label29";
            label29.Size = new Size(34, 16);
            label29.TabIndex = 1;
            label29.Text = "Type";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Silver;
            panel10.Controls.Add(plateNumberPanel);
            panel10.Controls.Add(label30);
            panel10.Location = new Point(6, 47);
            panel10.Name = "panel10";
            panel10.Size = new Size(171, 42);
            panel10.TabIndex = 14;
            // 
            // plateNumberPanel
            // 
            plateNumberPanel.BackColor = Color.LightGray;
            plateNumberPanel.Controls.Add(PlateTB);
            plateNumberPanel.Controls.Add(VDplate);
            plateNumberPanel.Location = new Point(69, 3);
            plateNumberPanel.Name = "plateNumberPanel";
            plateNumberPanel.Size = new Size(99, 35);
            plateNumberPanel.TabIndex = 12;
            // 
            // PlateTB
            // 
            PlateTB.Location = new Point(5, 7);
            PlateTB.Name = "PlateTB";
            PlateTB.Size = new Size(90, 23);
            PlateTB.TabIndex = 15;
            PlateTB.TextChanged += PlateTB_TextChanged;
            // 
            // VDplate
            // 
            VDplate.AutoSize = true;
            VDplate.BackColor = Color.Transparent;
            VDplate.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VDplate.ForeColor = SystemColors.ActiveCaptionText;
            VDplate.Location = new Point(32, 10);
            VDplate.Name = "VDplate";
            VDplate.Size = new Size(0, 15);
            VDplate.TabIndex = 14;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = SystemColors.ButtonHighlight;
            label30.Location = new Point(7, 13);
            label30.Name = "label30";
            label30.Size = new Size(61, 16);
            label30.TabIndex = 1;
            label30.Text = "Plate No.";
            // 
            // AdminDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(206, 186, 172);
            ClientSize = new Size(780, 440);
            Controls.Add(panel5);
            Controls.Add(DatabasePanel);
            Controls.Add(FlagdownPanel);
            Controls.Add(ParkInPanel);
            Controls.Add(RatePanel);
            Controls.Add(TypePanel);
            Controls.Add(MenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardMenu";
            Load += DashboardMenu_Load_1;
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            TypePanel.ResumeLayout(false);
            TypePanel.PerformLayout();
            FlagdownPanel.ResumeLayout(false);
            FlagdownPanel.PerformLayout();
            RatePanel.ResumeLayout(false);
            RatePanel.PerformLayout();
            ParkInPanel.ResumeLayout(false);
            ParkInPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            DatabasePanel.ResumeLayout(false);
            DatabasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            vehicleTimeInPanel.ResumeLayout(false);
            vehicleTimeInPanel.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            vehicleBrandPanel.ResumeLayout(false);
            vehicleBrandPanel.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            vehicleTypePanel.ResumeLayout(false);
            vehicleTypePanel.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            plateNumberPanel.ResumeLayout(false);
            plateNumberPanel.PerformLayout();
            ResumeLayout(false);
        }

        private void dataTable_CellClick(object sender, EventArgs e)
        { 
           // detailPanel1.Visible = true;
        }

        #endregion
        private Panel MenuPanel;
        private Panel TypePanel;
        private Panel FlagdownPanel;
        private Panel RatePanel;
        private Panel ParkInPanel;
        private Panel DatabasePanel;
        private ComboBox TypeCB;
        private ComboBox BrandCB;
        private TextBox PlateNoBox;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label8;
        private Button button1;
        private Label label10;
        private Button LogoutButton;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label17;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private DataGridView dataView;
        private TextBox txtSearchBox;
        private Panel panel4;
        private EditPanel editPanel1;
        private DataGridView dataTable;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel5;
        public Panel panel11;
        public Panel panel6;
        public Button button2;
        public Button button3;
        public Label label11;
        public Panel panel7;
        public Panel vehicleTimeInPanel;
        public Label label27;
        public Panel panel8;
        public Panel vehicleBrandPanel;
        public Label label28;
        public Panel panel9;
        public Panel vehicleTypePanel;
        public Label label29;
        public Panel panel10;
        public Panel plateNumberPanel;
        public Label label30;
        public Label VDtime;
        public Label VDbrand;
        public Label VDtype;
        public Label VDplate;
        public Button DoneButton;
        private TextBox PlateTB;
        private ComboBox BrandDB;
        private ComboBox TypeDB;
        private Label UserLogsLabel;
        private Label HomeLabel;
        public Panel panel12;
        public Label label31;
    }
}