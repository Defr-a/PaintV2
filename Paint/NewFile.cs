using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }
        public int CanvasWidth { get; private set; }
        public int CanvasHeight { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (WidthNUD.Value < 999999 && HeightNUD.Value < 999999)
            {
                CanvasWidth = (int)WidthNUD.Value;
                CanvasHeight = (int)HeightNUD.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for width and height.");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
