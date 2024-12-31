namespace WinFormsApp1
{
    partial class UserControl1
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
            typeDisplay = new TextBox();
            TIDisplay = new TextBox();
            TODisplay = new TextBox();
            SuspendLayout();
            // 
            // typeDisplay
            // 
            typeDisplay.Location = new Point(16, 16);
            typeDisplay.Name = "typeDisplay";
            typeDisplay.Size = new Size(125, 27);
            typeDisplay.TabIndex = 0;
            typeDisplay.TextChanged += typeDisplay_TextChanged;
            // 
            // TIDisplay
            // 
            TIDisplay.Location = new Point(16, 73);
            TIDisplay.Name = "TIDisplay";
            TIDisplay.Size = new Size(307, 27);
            TIDisplay.TabIndex = 1;
            TIDisplay.TextChanged += TIDisplay_TextChanged;
            // 
            // TODisplay
            // 
            TODisplay.Location = new Point(16, 129);
            TODisplay.Name = "TODisplay";
            TODisplay.Size = new Size(307, 27);
            TODisplay.TabIndex = 2;
            TODisplay.TextChanged += TODisplay_TextChanged;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(TODisplay);
            Controls.Add(TIDisplay);
            Controls.Add(typeDisplay);
            Name = "UserControl1";
            Size = new Size(482, 196);
            Load += UserControl1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox typeDisplay;
        public TextBox TIDisplay;
        public TextBox TODisplay;
    }
}
