using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkNClick
{
    public partial class NewReceipt : Form
    {
        DateTime TimeOut;
        int totalAmount;
        int th;
        public string slot { get; set; }
        DatabaseFunctions db = new DatabaseFunctions();
        private SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=ParkingSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        public static int FlagDown(string type)
        {
            switch (type)
            {
                case "Motorbike": return 20;
                case "SUV": return 40;
                case "Van": return 40;
                case "Sedan": return 30;
                default: return 0;
            }
        }

        public static int Rate(string type)
        {
            switch (type)
            {
                case "Motorbike": return 5;
                case "SUV": return 20;
                case "Van": return 20;
                case "Sedan": return 15;
                default: return 0;
            }
        }
        public NewReceipt(string Plate, string Type, string Brand, DateTime Ti)
        {
            TimeOut = DateTime.Now;
            InitializeComponent();
            int FD = FlagDown(Type);
            int R = Rate(Type);
            DisplayDetails(Plate, Type, Brand, Ti, FD, R);
        }

        private void DisplayDetails(string Plate, string Type, string Brand, DateTime Ti, int flagdown, int rate)
        {
            TimeSpan total = DateTime.Now.Subtract(Ti);
            th = total.Hours + (total.Days * 24);
            if (total.Minutes > 30)
            {
                th++;
            }
            totalAmount = th * rate + flagdown;

            PNReceipt.Text = Plate;
            VTReceipt.Text = Type;
            VBReceipt.Text = Brand;
            TIReceipt.Text = Ti.ToString();
            TOReceipt.Text = DateTime.Now.ToString();
            FDReceipt.Text = flagdown.ToString();
            RRate.Text = rate.ToString();
            HRate.Text = th.ToString();
            TReceipt.Text = totalAmount.ToString();
            InsertPayment(TransactionID(), DateTime.Now, totalAmount);
        }

        private string TransactionID()
        {
            string TransactionID = "";

            try
            {
                connection.Open();

                string query = "SELECT TOP 1 TransactionID FROM TransactionTable ORDER BY TransactionID DESC";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TransactionID = reader["TransactionID"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving latest TransactionID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return TransactionID;
        }
        public void InsertPayment(string transactionID, DateTime transactionDate, int amount)
        {
            try
            {
                connection.Open();

                string query = "INSERT INTO PaymentsTable (TransactionID, TransactionDate, Amount) " +
                               "VALUES (@TransactionID, @TransactionDate, @Amount)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TransactionID", transactionID);
                command.Parameters.AddWithValue("@TransactionDate", transactionDate);
                command.Parameters.AddWithValue("@Amount", amount);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Payment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            db.AddHistory2(DateTime.Now, th, slot, PNReceipt.Text);
        }
    }
}
