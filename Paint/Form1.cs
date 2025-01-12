using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            New();
        }
        //Variables
        #region
        protected static bool TboxOpen = false;
        protected bool saved = false;
        protected bool paint = false;
        protected static int FuncType = 0;
        private int x, y, cX, cY, Sx, Sy;
        private int orWidth = 1000, orHeight = 750;
        protected Point px, py;
        protected Bitmap b;
        protected Graphics g;
        protected Pen pen = new Pen(Color.Black, 1);
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();
        #endregion
        //Functions
        #region
        private void OpenTBox()
        {
            if (!TboxOpen)
            {
                ToolBox TBox = new ToolBox();
                TBox.TopMost = true;
                TBox.WindowState = FormWindowState.Normal;
                TBox.Show();
                TBox.Canvas_Img.Visible = false;
                TBox.menuStrip1.Visible = false;
                TBox.colorBox.Visible = false;
                TBox.cLabel.Visible = false;
                TBox.panel1.Visible = false;
                TBox.ToolLabel.Visible = false;
                TboxOpen = true;
            }
            else
            {
                MessageBox.Show("Impossibile creare piu di una ToolBox !");
            }
        }
        private void Add()
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
        private void Save()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    b.Save(saveFileDialog.FileName);
                    saved = true;
                }
            }
        }
        private void New()
        {
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
            saved = false;
        }
        private void NewF()
        {
            DialogResult d;
            NewFile prompt = new NewFile();
            d = prompt.ShowDialog();
            if (d == DialogResult.OK && saved)
            {
                int newWidth = prompt.CanvasWidth;
                int newHeight = prompt.CanvasHeight;
                CheckSize(newWidth, newHeight);
                New();
                return;
            }
            else if (d == DialogResult.OK)
            {
                SaveDialog sv = new SaveDialog();
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    Save();
                }
                int newWidth = prompt.CanvasWidth;
                int newHeight = prompt.CanvasHeight;
                CheckSize(newWidth, newHeight);
                New();
            }
            else if (d == DialogResult.Cancel)
            {
                return;
            }
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
        private void CheckSize(int newWt, int newHt)
        {
            if (newWt > this.Width || newHt > this.Height)
            {
                WorkPlacePnl.Width = 1000;
                WorkPlacePnl.Height = 750;
                WorkPlacePnl.AutoScroll = true;
                WorkPlacePnl.AutoScrollMinSize = new Size(newWt, newHt);
            }
            else
            {
                WorkPlacePnl.Width = newWt;
                WorkPlacePnl.Height = newHt;
            }
            Canvas_Img.Width = newWt;
            Canvas_Img.Height = newHt;
        }
        private void Open()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image importedImage = Image.FromFile(openFileDialog.FileName);
                    b = new Bitmap(importedImage.Width, importedImage.Height);
                    g = Graphics.FromImage(b);
                    WorkPlacePnl.AutoScroll = false;
                    WorkPlacePnl.Width = importedImage.Width;
                    WorkPlacePnl.Height = importedImage.Height;
                    Canvas_Img.Width = importedImage.Width;
                    Canvas_Img.Height = importedImage.Height;
                    Canvas_Img.Image = b;
                    ReCenter();
                    g.Clear(Color.White);
                    g.DrawImage(importedImage, new Rectangle(0, 0, b.Width, b.Height));
                    Canvas_Img.Refresh();
                }
            }
        }
        private void SaveState()
        {
            if (b != null)
            {
                undoStack.Push(new Bitmap(b));
                redoStack.Clear(); // Reset redo history
            }
        }
        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(new Bitmap(b)); // Save current state for redo
                b = undoStack.Pop();           // Restore the last saved state
                g = Graphics.FromImage(b);
                Canvas_Img.Image = b;
                Canvas_Img.Refresh();
            }
            else
            {
                MessageBox.Show("No more actions to undo.");
            }
        }
        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(new Bitmap(b)); // Save current state for undo
                b = redoStack.Pop();           // Restore the last undone state
                g = Graphics.FromImage(b);
                Canvas_Img.Image = b;
                Canvas_Img.Refresh();
            }
            else
            {
                MessageBox.Show("No more actions to redo.");
            }
        }
        #endregion
        //Form-Realted Functions
        #region
        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTBox();
        }
        private void Canvas_Img_MouseDown(object sender, MouseEventArgs e)
        {
            SaveState();
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
            if (FuncType == 10)
            {
                Cursor.Current = Cursors.Hand;
                Current.Text = "panning";
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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                BSizeNUD.Visible = false;
                BrushSizeLb.Visible = false;
                Current.Text = "bucket";
                pen.Color = colorBox.BackColor;
                Fill(b, e.X, e.Y, b.GetPixel(e.X, e.Y), pen.Color);
                Canvas_Img.Refresh();
            }
            if (paint && FuncType == 9)
            {
                BSizeNUD.Visible = false;
                BrushSizeLb.Visible = false;
                Current.Text = "pencil";
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
                pen.Width = 1;
                px = e.Location;
                g.DrawLine(pen, px, py);
                py = px;
            }
            if (paint && FuncType == 10 && WorkPlacePnl.AutoScroll)
            {
                Point currentMousePoint = e.Location;
                int offsetX = currentMousePoint.X - py.X;
                int offsetY = currentMousePoint.Y - py.Y;
                WorkPlacePnl.AutoScrollPosition = new Point(
                    -WorkPlacePnl.AutoScrollPosition.X - offsetX,
                    -WorkPlacePnl.AutoScrollPosition.Y - offsetY
                );

                py = currentMousePoint;
            }
            if (paint && FuncType == 11)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
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
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "line";
                pen.Color = colorBox.BackColor;
                g.DrawLine(pen, cX, cY, x, y);
            }
            if (FuncType == 5)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "ellipse";
                pen.Color = colorBox.BackColor;
                g.DrawEllipse(pen, cX, cY, Sx, Sy);
            }
            if (FuncType == 6)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                BSizeNUD.Visible = true;
                BrushSizeLb.Visible = true;
                Current.Text = "rectangle";
                pen.Color = colorBox.BackColor;
                g.DrawRectangle(pen, cX, cY, Sx, Sy);
            }
            if (FuncType == 10)
            {
                Cursor.Current = Cursors.Default;
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
            Add();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
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
            NewF();
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

        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = this.Width;
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height -this.Height);
            ReCenter();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }
        #endregion
        //Keys
        #region
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                Undo();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.Y))
            {
                Redo();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.H))
            {
                g.Clear(Color.White);
                Canvas_Img.Refresh();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                Save();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                Open();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                Add();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.N))
            {
                NewF();
                return true;
            }
            else if (keyData == Keys.B)
            {
                FuncType = 1;
                return true;
            }
            else if (keyData == Keys.N)
            {
                FuncType = 2;
                return true;
            }
            else if (keyData == Keys.F)
            {
                FuncType = 3;
                return true;
            }
            else if (keyData == Keys.L)
            {
                FuncType = 4;
                return true;
            }
            else if (keyData == Keys.E)
            {
                FuncType = 5;
                return true;
            }
            else if (keyData == Keys.R)
            {
                FuncType = 6;
                return true;
            }
            else if (keyData == Keys.K)
            {
                FuncType = 8;
                return true;
            }
            else if (keyData == Keys.P)
            {
                FuncType = 9;
                return true;
            }
            else if (keyData == Keys.M)
            {
                FuncType = 10;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
