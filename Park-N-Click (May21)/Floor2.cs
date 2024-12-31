using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkNClick
{
    public partial class Floor2 : UserControl
    {
        public event EventHandler ButtonClicked;
        public Floor2()
        {
            InitializeComponent();
        }

        private void Floor1_Load(object sender, EventArgs e)
        {

        }

        private void Floor2Button_Click(object sender, EventArgs e)
        {
            return;
        }

        private void Floor1Button_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MA2_Click(object sender, EventArgs e)
        {

        }
    }
}
