using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParkNClick
{
    public partial class Floor1 : UserControl
    {
         event EventHandler ButtonClicked;
         event EventHandler Clicked;
         Button[] buttons;
         ParkInForm PIForm;
         ParkoutForm POForm;
         Button Floor1Button;
         Button Floor2Button;
         DatabaseF dbFunctions = new DatabaseF();
       public void InitializeButtonArray()
        {
            buttons = new Button[] { A1, B1, C1, D1, E1, F1, G1, H1, I1, J1, K1, L1, MA1, MB1, MC1, MD1, ME1, MF1, MG1, MH1, MI1, MJ1, MK1, ML1, MM1, MN1, MO1, MP1, MQ1, MR1 };
        }

        
        public Floor1()
        {
            InitializeComponent();
            InitializeButtonArray();
            CheckParkingStatus();
        
        }



        private void Floor1_Load(object sender, EventArgs e)
        {
            CheckParkingStatus();
        }
        private void Floor2Button_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void Slot_Buttons(object sender, EventArgs e) //Gi ilisan ra konig ngan Button_Clicked
        {
            Button button = sender as Button;
            
            if (button == null)
            {
                return;
            }

            if (button.BackColor == Color.SeaGreen)
            {
                //TType = "Park In";
                //PaymentStatus = "Pending";
                string slotName = button.Text;
                PIForm = new ParkInForm();
                PIForm.SetSlotName(slotName);   
                PIForm.Show();
                PIForm.FormClosed += (s, args) => HandleFormClosed(button, PIForm.color);
            }
            else if (button.BackColor == Color.Brown)
            {
                string slotName = button.Text;
                dbFunctions.ShowDetails(slotName); // shows the Vehicle info
               // POForm.FormClosed += (s, args) => ParkOutFormClosed(button, POForm.color);
            }

        }
        private void HandleFormClosed(Button button, bool color)
        {
            if (PIForm.TypeBox.Text == "" || PIForm.BrandBox.Text == "" || PIForm.PlateBox.Text == "")
            {
                MessageBox.Show("Error: Parking slot information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!string.IsNullOrEmpty(button.Text))
            {
                Status = "Occupied";
                UpdateColorStatus(button, color);
                ParkStatus(button.Text, Status);
                //Details(TType, GetUsername(), button.Text, plateNo, vehicleType, vehicleBrand, DateTime.Now, PaymentStatus
            }
            else
            {
                MessageBox.Show("Error: Parking slot information is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //db.AddHistory(button.Text, plateNo, DateTime.Now);
            //db.UpdateTransactionCount();
        }
        private void ParkOutFormClosed(Button button, bool color)
        {

            UpdateColorStatus(button, color);
            ParkStatus(button.Text, Status);

        }
        // *********************Methods*************************************
        public void ParkStatus(string slot, string status) // *AddToParkin
        {
            dbFunctions.OccupySlot(slot, status);
        }

       

        public void CheckParkingStatus()
        {
            dbFunctions.LoadParkingStatus(buttons);
        }
        private void UpdateColorStatus(Button button, bool color)
        {
            if (color)
            {
                button.BackColor = Color.Brown;
            }
            else
            {
                button.BackColor = Color.SeaGreen;
            }
        }

    }
}
