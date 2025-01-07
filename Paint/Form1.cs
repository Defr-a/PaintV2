using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            b = new Bitmap(Canvas_Img.Width, Canvas_Img.Height);
            g = Graphics.FromImage(b);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            Canvas_Img.Image = b;

        }
        protected Bitmap b;
        protected Graphics g;
        protected bool paint = false;
        protected Point px, py;
        protected Pen pen = new Pen(Color.Black, 1);
        protected static int FuncType = 0;
        protected static bool TboxOpen = false;
        private int x, y, cX, cY, Sx, Sy;
        private int orWidth = 1000, orHeight = 750;
        private float zoomFactor = 1.0f;

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TboxOpen)
            {
                ToolBox TBox = new ToolBox();
                TBox.TopMost = true;
                TBox.Show();
                TBox.Canvas_Img.Visible = false;
                TBox.menuStrip1.Visible = false;
                TBox.toolStrip1.Visible = false;
                TBox.colorBox.Visible = false;
                TBox.cLabel.Visible = false;
                TBox.ToolLabel.Visible = false;

                TboxOpen = true;
            }
            else
            {
                MessageBox.Show("Impossibile creare piu di una ToolBox !");
            }
        }

        private void Canvas_Img_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
            if (FuncType == 8)
            {
                BSizeNUD.Visible = false;
                BrushSizeLb.Visible = false;
                Current.Text = "colorPick";
                colorBox.BackColor = b.GetPixel(e.X, e.Y);
            }
        }

        private void Canvas_Img_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Sx = e.X - cX;
            Sy = e.Y - cY;
            if (paint && FuncType == 1)
            {
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "brush";
                pen.Color = colorBox.BackColor;
                px = e.Location;
                g.DrawLine(pen, px, py);
                g.DrawLine(pen, px, py);
                g.DrawLine(pen, px, py);
                py = px;
            }
            if (paint && FuncType == 2)
            {
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "eraser";
                pen.Color = Color.White;
                px = e.Location;
                g.DrawLine(pen, px, py);
                g.DrawLine(pen, px, py);
                g.DrawLine(pen, px, py);
                py = px;
            }
            if (paint && FuncType == 3)
            {
                BSizeNUD.Visible = false;
                BrushSizeLb.Visible = false;
                Current.Text = "bucket";
                pen.Color = colorBox.BackColor;
                Fill(b, e.X, e.Y, b.GetPixel(e.X, e.Y), pen.Color);
                Canvas_Img.Refresh();
            }
            if (paint && FuncType == 7)
            {
            }
            if (paint && FuncType == 9)
            {
                BSizeNUD.Visible = false;
                BrushSizeLb.Visible = false;
                Current.Text = "pencil";
                int pixelSize = 1;
                int snX = e.X / pixelSize * pixelSize;
                int snY = e.Y / pixelSize * pixelSize;
                using (Brush b = new SolidBrush(colorBox.BackColor))
                {
                    g.FillRectangle(b, snX, snY, pixelSize, pixelSize);
                }
            }
            if (paint && FuncType == 10)
            {

            }
            if (paint && FuncType == 11)
            {
                g.DrawEllipse(pen, cX, cY, Sx, Sy);
            }
            Canvas_Img.Refresh();
        }

        private void Canvas_Img_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            Sx = x - cX;
            Sy = y - cY;
            if (FuncType == 4)
            {
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "line";
                pen.Color = colorBox.BackColor;
                g.DrawLine(pen, cX, cY, x, y);
            }
            if (FuncType == 5)
            {
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "ellipse";
                pen.Color = colorBox.BackColor;
                g.DrawEllipse(pen, cX, cY, Sx, Sy);
            }
            if (FuncType == 6)
            {
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "rectangle";
                pen.Color = colorBox.BackColor;
                g.DrawRectangle(pen, cX, cY, Sx, Sy);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Canvas_Img.Refresh();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pen.Color = dlg.Color;
                colorBox.BackColor = dlg.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image importedImage = Image.FromFile(openFileDialog.FileName);
                    g.DrawImage(importedImage, new Point(0, 0)); // Adjust position if needed
                    Canvas_Img.Refresh();
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    b.Save(saveFileDialog.FileName);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSizeNUD_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)BSizeNUD.Value;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile prompt = new NewFile();
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                int newWidth = prompt.CanvasWidth;
                int newHeight = prompt.CanvasHeight;
                WorkPlacePnl.Width = newWidth;
                WorkPlacePnl.Height = newHeight;
                Canvas_Img.Width = newWidth;
                Canvas_Img.Height = newHeight;
                WorkPlacePnl.AutoScroll = true;
            }
            b = new Bitmap(Canvas_Img.Width, Canvas_Img.Height);
            g = Graphics.FromImage(b);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            Canvas_Img.Image = b;
            ReCenter();
            Canvas_Img.Refresh();
            orWidth = Canvas_Img.Width;
            orHeight = Canvas_Img.Height;
        }
        public void Fill(Bitmap bitmap, int x, int y, Color targetColor, Color replacementColor)
        {
            // If target color is the same as replacement color, do nothing
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return;

            // Get the bitmap dimensions
            int width = bitmap.Width;
            int height = bitmap.Height;

            // Lock the bitmap for direct pixel access
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData data = bitmap.LockBits(rect, ImageLockMode.ReadWrite, bitmap.PixelFormat);

            int bpp = Image.GetPixelFormatSize(bitmap.PixelFormat) / 8;
            int stride = data.Stride;
            IntPtr ptr = data.Scan0;
            byte[] pixels = new byte[Math.Abs(stride) * height];
            System.Runtime.InteropServices.Marshal.Copy(ptr, pixels, 0, pixels.Length);

            // Convert colors to bytes for comparison
            byte[] targetColorBytes = { targetColor.B, targetColor.G, targetColor.R, targetColor.A };
            byte[] replacementColorBytes = { replacementColor.B, replacementColor.G, replacementColor.R, replacementColor.A };

            // Initialize the queue
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(x, y));

            while (queue.Count > 0)
            {
                Point p = queue.Dequeue();
                int px = p.X;
                int py = p.Y;

                if (px < 0 || px >= width || py < 0 || py >= height) continue;

                int index = (py * stride) + (px * bpp);

                // Check if the current pixel matches the target color
                if (pixels[index] == targetColorBytes[0] &&  // Blue
                    pixels[index + 1] == targetColorBytes[1] &&  // Green
                    pixels[index + 2] == targetColorBytes[2] &&  // Red
                    pixels[index + 3] == targetColorBytes[3])    // Alpha
                {
                    // Set the replacement color
                    pixels[index] = replacementColorBytes[0];
                    pixels[index + 1] = replacementColorBytes[1];
                    pixels[index + 2] = replacementColorBytes[2];
                    pixels[index + 3] = replacementColorBytes[3];

                    // Enqueue all 8 neighbors
                    queue.Enqueue(new Point(px + 1, py));     // Right
                    queue.Enqueue(new Point(px - 1, py));     // Left
                    queue.Enqueue(new Point(px, py + 1));     // Down
                    queue.Enqueue(new Point(px, py - 1));     // Up
                    queue.Enqueue(new Point(px + 1, py + 1)); // Bottom-Right
                    queue.Enqueue(new Point(px - 1, py + 1)); // Bottom-Left
                    queue.Enqueue(new Point(px + 1, py - 1)); // Top-Right
                    queue.Enqueue(new Point(px - 1, py - 1)); // Top-Left
                }
            }

            // Copy the modified pixels back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, ptr, pixels.Length);
            bitmap.UnlockBits(data);
        }

        private void ReCenter()
        {
            WorkPlacePnl.Location = new Point(((this.ClientSize.Width - WorkPlacePnl.Width) / 2), ((this.ClientSize.Height - WorkPlacePnl.Height)) / 2);
        }
        private void Canvas_Img_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                if (FuncType == 4)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                }
                if (FuncType == 5)
                {
                    graphics.DrawEllipse(pen, cX, cY, Sx, Sy);
                }
                if (FuncType == 6)
                {
                    graphics.DrawRectangle(pen, cX, cY, Sx, Sy);
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FuncType = 11;
        }
    }
}
