namespace ParkingApp
{
    partial class sidePanelRight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            gradientPanel1 = new gradientPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 80F;
            gradientPanel1.BottomColor = Color.DarkGray;
            gradientPanel1.Controls.Add(flowLayoutPanel1);
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(530, 682);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.Gainsboro;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(557, 682);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // sidePanelRight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(gradientPanel1);
            Name = "sidePanelRight";
            Size = new Size(530, 682);
            gradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public gradientPanel gradientPanel1;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
