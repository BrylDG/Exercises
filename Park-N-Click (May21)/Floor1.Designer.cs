using Microsoft.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace ParkNClick
{
    partial class Floor1

    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        DatabaseFunctions db = new DatabaseFunctions();

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
            Floor1Button = new Button();
            Floor2Button = new Button();
            H1 = new Button();
            G1 = new Button();
            L1 = new Button();
            K1 = new Button();
            J1 = new Button();
            I1 = new Button();
            MJ1 = new Button();
            MK1 = new Button();
            ML1 = new Button();
            MM1 = new Button();
            MN1 = new Button();
            MO1 = new Button();
            MP1 = new Button();
            MQ1 = new Button();
            MR1 = new Button();
            B1 = new Button();
            C1 = new Button();
            D1 = new Button();
            E1 = new Button();
            F1 = new Button();
            MI1 = new Button();
            MH1 = new Button();
            MG1 = new Button();
            MF1 = new Button();
            ME1 = new Button();
            MD1 = new Button();
            MC1 = new Button();
            MB1 = new Button();
            MA1 = new Button();
            A1 = new Button();
            SuspendLayout();
            // 
            // Floor1Button
            // 
            Floor1Button.BackColor = Color.SteelBlue;
            Floor1Button.Location = new Point(16, 602);
            Floor1Button.Name = "Floor1Button";
            Floor1Button.Size = new Size(75, 63);
            Floor1Button.TabIndex = 0;
            Floor1Button.Text = "1";
            Floor1Button.UseVisualStyleBackColor = false;
            
            // 
            // Floor2Button
            // 
            Floor2Button.Location = new Point(97, 602);
            Floor2Button.Name = "Floor2Button";
            Floor2Button.Size = new Size(75, 63);
            Floor2Button.TabIndex = 1;
            Floor2Button.Text = "2";
            Floor2Button.UseVisualStyleBackColor = true;
            Floor2Button.Click += Floor2Button_Click;
            // 
            // H1
            // 
            H1.BackColor = Color.SeaGreen;
            H1.Location = new Point(590, 144);
            H1.Name = "H1";
            H1.Size = new Size(188, 79);
            H1.TabIndex = 13;
            H1.Text = "H1";
            H1.UseVisualStyleBackColor = false;
            H1.Click += Slot_Buttons;
            // 
            // G1
            // 
            G1.BackColor = Color.SeaGreen;
            G1.Location = new Point(590, 59);
            G1.Name = "G1";
            G1.Size = new Size(188, 79);
            G1.TabIndex = 11;
            G1.Text = "G1";
            G1.UseVisualStyleBackColor = false;
            G1.Click += Slot_Buttons;
            // 
            // L1
            // 
            L1.BackColor = Color.SeaGreen;
            L1.Location = new Point(590, 484);
            L1.Name = "L1";
            L1.Size = new Size(188, 79);
            L1.TabIndex = 19;
            L1.Text = "L1";
            L1.UseVisualStyleBackColor = false;
            L1.Click += Slot_Buttons;
            // 
            // K1
            // 
            K1.BackColor = Color.SeaGreen;
            K1.Location = new Point(590, 399);
            K1.Name = "K1";
            K1.Size = new Size(188, 79);
            K1.TabIndex = 17;
            K1.Text = "K1";
            K1.UseVisualStyleBackColor = false;
            K1.Click += Slot_Buttons;
            // 
            // J1
            // 
            J1.BackColor = Color.SeaGreen;
            J1.Location = new Point(590, 314);
            J1.Name = "J1";
            J1.Size = new Size(188, 79);
            J1.TabIndex = 16;
            J1.Text = "J1";
            J1.UseVisualStyleBackColor = false;
            J1.Click += Slot_Buttons;
            // 
            // I1
            // 
            I1.BackColor = Color.SeaGreen;
            I1.Location = new Point(590, 229);
            I1.Name = "I1";
            I1.Size = new Size(188, 79);
            I1.TabIndex = 14;
            I1.Text = "I1";
            I1.UseVisualStyleBackColor = false;
            I1.Click += Slot_Buttons;
            // 
            // MJ1
            // 
            MJ1.BackColor = Color.SeaGreen;
            MJ1.Location = new Point(888, 56);
            MJ1.Name = "MJ1";
            MJ1.Size = new Size(128, 51);
            MJ1.TabIndex = 26;
            MJ1.Text = "MJ1";
            MJ1.UseVisualStyleBackColor = false;
            MJ1.Click += Slot_Buttons;
            // 
            // MK1
            // 
            MK1.BackColor = Color.SeaGreen;
            MK1.Location = new Point(888, 113);
            MK1.Name = "MK1";
            MK1.Size = new Size(128, 51);
            MK1.TabIndex = 27;
            MK1.Text = "MK1";
            MK1.UseVisualStyleBackColor = false;
            MK1.Click += Slot_Buttons;
            // 
            // ML1
            // 
            ML1.BackColor = Color.SeaGreen;
            ML1.Location = new Point(888, 170);
            ML1.Name = "ML1";
            ML1.Size = new Size(128, 51);
            ML1.TabIndex = 28;
            ML1.Text = "ML1";
            ML1.UseVisualStyleBackColor = false;
            ML1.Click += Slot_Buttons;
            // 
            // MM1
            // 
            MM1.BackColor = Color.SeaGreen;
            MM1.Location = new Point(888, 227);
            MM1.Name = "MM1";
            MM1.Size = new Size(128, 51);
            MM1.TabIndex = 29;
            MM1.Text = "MM1";
            MM1.UseVisualStyleBackColor = false;
            MM1.Click += Slot_Buttons;
            // 
            // MN1
            // 
            MN1.BackColor = Color.SeaGreen;
            MN1.Location = new Point(888, 284);
            MN1.Name = "MN1";
            MN1.Size = new Size(128, 51);
            MN1.TabIndex = 30;
            MN1.Text = "MN1";
            MN1.UseVisualStyleBackColor = false;
            MN1.Click += Slot_Buttons;
            // 
            // MO1
            // 
            MO1.BackColor = Color.SeaGreen;
            MO1.Location = new Point(888, 339);
            MO1.Name = "MO1";
            MO1.Size = new Size(128, 51);
            MO1.TabIndex = 31;
            MO1.Text = "MO1";
            MO1.UseVisualStyleBackColor = false;
            MO1.Click += Slot_Buttons;
            // 
            // MP1
            // 
            MP1.BackColor = Color.SeaGreen;
            MP1.Location = new Point(888, 396);
            MP1.Name = "MP1";
            MP1.Size = new Size(128, 51);
            MP1.TabIndex = 32;
            MP1.Text = "MP1";
            MP1.UseVisualStyleBackColor = false;
            MP1.Click += Slot_Buttons;
            // 
            // MQ1
            // 
            MQ1.BackColor = Color.SeaGreen;
            MQ1.Location = new Point(888, 453);
            MQ1.Name = "MQ1";
            MQ1.Size = new Size(128, 51);
            MQ1.TabIndex = 33;
            MQ1.Text = "MQ1";
            MQ1.UseVisualStyleBackColor = false;
            MQ1.Click += Slot_Buttons;
            // 
            // MR1
            // 
            MR1.BackColor = Color.SeaGreen;
            MR1.Location = new Point(888, 510);
            MR1.Name = "MR1";
            MR1.Size = new Size(128, 51);
            MR1.TabIndex = 34;
            MR1.Text = "MR1";
            MR1.UseVisualStyleBackColor = false;
            MR1.Click += Slot_Buttons;
            // 
            // B1
            // 
            B1.BackColor = Color.SeaGreen;
            B1.Location = new Point(294, 144);
            B1.Name = "B1";
            B1.Size = new Size(188, 79);
            B1.TabIndex = 4;
            B1.Text = "B1";
            B1.UseVisualStyleBackColor = false;
            B1.Click += Slot_Buttons;
            // 
            // C1
            // 
            C1.BackColor = Color.SeaGreen;
            C1.Location = new Point(294, 229);
            C1.Name = "C1";
            C1.Size = new Size(188, 79);
            C1.TabIndex = 5;
            C1.Text = "C1";
            C1.UseVisualStyleBackColor = false;
            C1.Click += Slot_Buttons;
            // 
            // D1
            // 
            D1.BackColor = Color.SeaGreen;
            D1.Location = new Point(294, 314);
            D1.Name = "D1";
            D1.Size = new Size(188, 79);
            D1.TabIndex = 7;
            D1.Text = "D1";
            D1.UseVisualStyleBackColor = false;
            D1.Click += Slot_Buttons;
            // 
            // E1
            // 
            E1.BackColor = Color.SeaGreen;
            E1.Location = new Point(294, 399);
            E1.Name = "E1";
            E1.Size = new Size(188, 79);
            E1.TabIndex = 8;
            E1.Text = "E1";
            E1.UseVisualStyleBackColor = false;
            E1.Click += Slot_Buttons;
            // 
            // F1
            // 
            F1.BackColor = Color.SeaGreen;
            F1.Location = new Point(294, 484);
            F1.Name = "F1";
            F1.Size = new Size(188, 79);
            F1.TabIndex = 10;
            F1.Text = "F1";
            F1.UseVisualStyleBackColor = false;
            F1.Click += Slot_Buttons;
            // 
            // MI1
            // 
            MI1.BackColor = Color.SeaGreen;
            MI1.Location = new Point(59, 513);
            MI1.Name = "MI1";
            MI1.Size = new Size(128, 51);
            MI1.TabIndex = 43;
            MI1.Text = "MI1";
            MI1.UseVisualStyleBackColor = false;
            MI1.Click += Slot_Buttons;
            // 
            // MH1
            // 
            MH1.BackColor = Color.SeaGreen;
            MH1.Location = new Point(59, 456);
            MH1.Name = "MH1";
            MH1.Size = new Size(128, 51);
            MH1.TabIndex = 42;
            MH1.Text = "MH1";
            MH1.UseVisualStyleBackColor = false;
            MH1.Click += Slot_Buttons;
            // 
            // MG1
            // 
            MG1.BackColor = Color.SeaGreen;
            MG1.Location = new Point(59, 399);
            MG1.Name = "MG1";
            MG1.Size = new Size(128, 51);
            MG1.TabIndex = 41;
            MG1.Text = "MG1";
            MG1.UseVisualStyleBackColor = false;
            MG1.Click += Slot_Buttons;
            // 
            // MF1
            // 
            MF1.BackColor = Color.SeaGreen;
            MF1.Location = new Point(59, 342);
            MF1.Name = "MF1";
            MF1.Size = new Size(128, 51);
            MF1.TabIndex = 40;
            MF1.Text = "MF1";
            MF1.UseVisualStyleBackColor = false;
            MF1.Click += Slot_Buttons;
            // 
            // ME1
            // 
            ME1.BackColor = Color.SeaGreen;
            ME1.Location = new Point(59, 287);
            ME1.Name = "ME1";
            ME1.Size = new Size(128, 51);
            ME1.TabIndex = 39;
            ME1.Text = "ME1";
            ME1.UseVisualStyleBackColor = false;
            ME1.Click += Slot_Buttons;
            // 
            // MD1
            // 
            MD1.BackColor = Color.SeaGreen;
            MD1.Location = new Point(59, 230);
            MD1.Name = "MD1";
            MD1.Size = new Size(128, 51);
            MD1.TabIndex = 38;
            MD1.Text = "MD1";
            MD1.UseVisualStyleBackColor = false;
            MD1.Click += Slot_Buttons;
            // 
            // MC1
            // 
            MC1.BackColor = Color.SeaGreen;
            MC1.Location = new Point(59, 173);
            MC1.Name = "MC1";
            MC1.Size = new Size(128, 51);
            MC1.TabIndex = 37;
            MC1.Text = "MC1";
            MC1.UseVisualStyleBackColor = false;
            MC1.Click += Slot_Buttons;
            // 
            // MB1
            // 
            MB1.BackColor = Color.SeaGreen;
            MB1.Location = new Point(59, 116);
            MB1.Name = "MB1";
            MB1.Size = new Size(128, 51);
            MB1.TabIndex = 36;
            MB1.Text = "MB1";
            MB1.UseVisualStyleBackColor = false;
            MB1.Click += Slot_Buttons;
            // 
            // MA1
            // 
            MA1.BackColor = Color.SeaGreen;
            MA1.Location = new Point(59, 59);
            MA1.Name = "MA1";
            MA1.Size = new Size(128, 51);
            MA1.TabIndex = 35;
            MA1.Text = "MA1";
            MA1.UseVisualStyleBackColor = false;
            MA1.Click += Slot_Buttons;
            // 
            // A1
            // 
            A1.BackColor = Color.SeaGreen;
            A1.Location = new Point(294, 59);
            A1.Name = "A1";
            A1.Size = new Size(188, 79);
            A1.TabIndex = 44;
            A1.Text = "A1";
            A1.UseVisualStyleBackColor = false;
            A1.Click += Slot_Buttons;

            // 
            // Floor1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(A1);
            Controls.Add(MI1);
            Controls.Add(MH1);
            Controls.Add(MG1);
            Controls.Add(MF1);
            Controls.Add(ME1);
            Controls.Add(MD1);
            Controls.Add(MC1);
            Controls.Add(MB1);
            Controls.Add(MA1);
            Controls.Add(MR1);
            Controls.Add(MQ1);
            Controls.Add(MP1);
            Controls.Add(MO1);
            Controls.Add(MN1);
            Controls.Add(MM1);
            Controls.Add(ML1);
            Controls.Add(MK1);
            Controls.Add(MJ1);
            Controls.Add(L1);
            Controls.Add(K1);
            Controls.Add(J1);
            Controls.Add(I1);
            Controls.Add(H1);
            Controls.Add(G1);
            Controls.Add(F1);
            Controls.Add(E1);
            Controls.Add(D1);
            Controls.Add(C1);
            Controls.Add(B1);
            Controls.Add(Floor2Button);
            Controls.Add(Floor1Button);
            Name = "Floor1";
            Size = new Size(1070, 685);
            Load += Floor1_Load;
            ResumeLayout(false);
        }




        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Button button = sender as Button;
        //    if (button == null)
        //    {
        //        return;
        //    }

        //    if (button.BackColor == Color.SeaGreen)
        //    {
        //        TType = "Park In";
        //        PaymentStatus = "Pending";
        //        PIForm = new ParkInForm();
        //        PIForm.Show();
        //        PIForm.FormClosed += (s, args) => HandleFormClosed(button, PIForm.color, TType, PaymentStatus, PIForm.plateNo, PIForm.Type, PIForm.Brand);
        //    }
        //    else if (button.BackColor == Color.Brown)
        //    {
        //        TType = "Park Out";
        //        PaymentStatus = "Paid";
        //        POForm = new ParkoutForm();
        //        POForm.Name = button.Text;
        //        POForm.Show();
        //        POForm.button2.Click += (s, args) => POHandleFormClosed(button, POForm.color, TType, PaymentStatus, POForm.plateNum, POForm.VType, POForm.VBrand);
        //        POForm.button2.Click += (s, args) => changeColor(button, POForm.color);
        //    }

        //}
        //private string GetUsername()
        //{
        //    string lastUsername = null;
        //    string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True";
        //    string query = "SELECT TOP 1 UserUsername FROM UserLogs ORDER BY UserLoginDate DESC";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                object result = command.ExecuteScalar();
        //                if (result != null)
        //                {
        //                    lastUsername = result.ToString();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error fetching last username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }

        //    return lastUsername;
        //}
        //private void POHandleFormClosed(Button button, bool color, string TType, string Status, string plateNo, string vehicleType, string vehicleBrand)
        //{
        //    if (!string.IsNullOrEmpty(button.Text))
        //    {
        //        Status = "Vacant";
        //        changeColor(button, color);
        //        details(TType, GetUsername(), button.Text, plateNo, vehicleType, vehicleBrand, DateTime.Now, PaymentStatus);
        //        addToParkIn(button.Text, Status);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error: Parking slot information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void HandleFormClosed(Button button, bool color, string TType, string Status, string plateNo, string vehicleType, string vehicleBrand)
        //{
        //    if (PIForm.TypeBox.Text == "" || PIForm.BrandBox.Text == "" || PIForm.PlateBox.Text == "")
        //    {
        //        MessageBox.Show("Error: Parking slot information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else if (!string.IsNullOrEmpty(button.Text))
        //    {
        //        Status = "Occupied";
        //        changeColor(button, color);
        //        details(TType, GetUsername(), button.Text, plateNo, vehicleType, vehicleBrand, DateTime.Now, PaymentStatus);
        //        addToParkIn(button.Text, Status);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error: Parking slot information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    db.AddHistory(button.Text, plateNo, DateTime.Now);
        //    db.UpdateTransactionCount();
        //}

        //private void changeColor(Button button, bool color)
        //{
        //    if (color)
        //    {
        //        button.BackColor = Color.Brown;
        //    }
        //    else
        //    {
        //        button.BackColor = Color.SeaGreen;
        //    }
        //}
        //public void addToParkIn(string slot, string status)
        //{
        //    string sqlQuery = @"UPDATE ParkedIn SET SlotStatus = @SlotStatus WHERE ParkingSlot = @ParkingSlot";
        //    using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
        //    {
        //        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
        //        {
        //            command.Parameters.AddWithValue("@ParkingSlot", slot);
        //            command.Parameters.AddWithValue("@SlotStatus", status);
        //            try
        //            {
        //                connection.Open();
        //                int rowsAffected = command.ExecuteNonQuery();
        //                if (rowsAffected > 0)
        //                {
        //                    MessageBox.Show("Slot status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("No records found for the specified parking slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error updating slot status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}

        //public void details(string transactionType, string transactionUser, string slot, string plateNo, string vehicleType, string vehicleBrand, DateTime time, string status)
        //{
        //    string sqlQuery = @"INSERT INTO TransactionTable (TransactionType, TransactionUser, ParkingSlot, VehiclePlateNumber, VehicleType, VehicleBrand, ParkInParkOut, PaymentStatus)
        //                VALUES (@TransactionType, @TransactionUser, @ParkingSlot, @VehiclePlateNumber, @VehicleType, @VehicleBrand, @ParkInParkOut, @PaymentStatus)";

        //    using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
        //    {
        //        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
        //        {
        //            command.Parameters.AddWithValue("@TransactionType", transactionType);
        //            command.Parameters.AddWithValue("@TransactionUser", transactionUser);
        //            command.Parameters.AddWithValue("@ParkingSlot", slot);
        //            command.Parameters.AddWithValue("@VehiclePlateNumber", plateNo);
        //            command.Parameters.AddWithValue("@VehicleType", vehicleType);
        //            command.Parameters.AddWithValue("@VehicleBrand", vehicleBrand);
        //            command.Parameters.AddWithValue("@ParkInParkOut", time);
        //            command.Parameters.AddWithValue("@PaymentStatus", status);

        //            try
        //            {
        //                connection.Open();
        //                command.ExecuteNonQuery();
        //                MessageBox.Show("Records added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error adding records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}



        #endregion
        public string Status;
        string TType = "";
        string PaymentStatus = "";
        public string slot { get; set; }
        
        private Button H1;
        private Button G1;
        private Button L1;
        private Button K1;
        private Button J1;
        private Button I1;
        private Button MJ1;
        private Button MK1;
        private Button ML1;
        private Button MM1;
        private Button MN1;
        private Button MO1;
        private Button MP1;
        private Button MQ1;
        private Button MR1;
        private Button B1;
        private Button C1;
        private Button D1;
        private Button E1;
        private Button F1;
        private Button MI1;
        private Button MH1;
        private Button MG1;
        private Button MF1;
        private Button ME1;
        private Button MD1;
        private Button MC1;
        private Button MB1;
        private Button MA1;
        private Button A1;
    }
}
