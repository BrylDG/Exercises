using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParkingApp
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent(string IPlate, string IType, string IBrand, string ITi, int IFlagDown, int IRate, int IHours, int ITotal)
        {
            receiptPanel1 = new receiptPanel(IPlate, IType, IBrand, ITi, IFlagDown, IRate, IHours, ITotal);
            button1 = new Button();
            SuspendLayout();
            // 
            // receiptPanel1
            // 
            receiptPanel1.BackColor = Color.White;
            receiptPanel1.Location = new Point(0, -2);
            receiptPanel1.Name = "receiptPanel1";
            receiptPanel1.Size = new Size(271, 400);
            receiptPanel1.TabIndex = 0;
            receiptPanel1.Load += receiptPanel1_Load;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(92, 363);
            button1.Name = "button1";
            button1.Size = new Size(81, 23);
            button1.TabIndex = 30;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 398);
            Controls.Add(button1);
            Controls.Add(receiptPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        public receiptPanel receiptPanel1;
        public Button button1;
    }
}