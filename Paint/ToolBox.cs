using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paint
{
    public partial class ToolBox : Form1
    {
        public ToolBox()
        {
            InitializeComponent();
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.BackColor = Color.AliceBlue;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(pictureBox, pictureBox.AccessibleName);
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                pictureBox.BackColor = Color.White;
                pictureBox.BorderStyle = BorderStyle.None;
            }
        }

        private void ToolBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            TboxOpen = false;
        }
        private void Brush_Pb_Click(object sender, EventArgs e)
        {
            FuncType = 1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FuncType = 2;
        }
        private void FillPb_Click(object sender, EventArgs e)
        {
            FuncType = 3;
        }

        private void LinePb_Click(object sender, EventArgs e)
        {
            FuncType = 4;
        }

        private void ElipsePb_Click(object sender, EventArgs e)
        {
            FuncType = 5;
        }

        private void RectanglePb_Click(object sender, EventArgs e)
        {
            FuncType = 6;
        }

        private void TextPb_Click(object sender, EventArgs e)
        {
            FuncType = 7;

        }

        private void ColoPickPb_Click(object sender, EventArgs e)
        {
            FuncType = 8;
        }

        private void PencilPb_Click(object sender, EventArgs e)
        {
            FuncType = 9;
        }

        private void MovePb_Click(object sender, EventArgs e)
        {
            FuncType = 10;
        }

        private void ToolBox_Load(object sender, EventArgs e)
        {
            
        }
    }
}
