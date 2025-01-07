namespace Paint
{
    partial class ToolBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBox));
            Brush_Pb = new PictureBox();
            pictureBox1 = new PictureBox();
            FillPb = new PictureBox();
            ElipsePb = new PictureBox();
            TextPb = new PictureBox();
            PencilPb = new PictureBox();
            LinePb = new PictureBox();
            RectanglePb = new PictureBox();
            ColoPickPb = new PictureBox();
            MovePb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Brush_Pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FillPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ElipsePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PencilPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LinePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RectanglePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColoPickPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovePb).BeginInit();
            SuspendLayout();
            // 
            // Brush_Pb
            // 
            Brush_Pb.AccessibleDescription = "";
            Brush_Pb.AccessibleName = "Brush (B)";
            Brush_Pb.AccessibleRole = AccessibleRole.ToolTip;
            Brush_Pb.BackgroundImage = (Image)resources.GetObject("Brush_Pb.BackgroundImage");
            Brush_Pb.BackgroundImageLayout = ImageLayout.Stretch;
            Brush_Pb.InitialImage = (Image)resources.GetObject("Brush_Pb.InitialImage");
            Brush_Pb.Location = new Point(12, 12);
            Brush_Pb.Name = "Brush_Pb";
            Brush_Pb.Size = new Size(40, 40);
            Brush_Pb.TabIndex = 0;
            Brush_Pb.TabStop = false;
            Brush_Pb.Tag = "Brush";
            Brush_Pb.Click += Brush_Pb_Click;
            Brush_Pb.MouseLeave += PictureBox_MouseLeave;
            Brush_Pb.MouseHover += PictureBox_MouseEnter;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "Eraser (N)";
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(96, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseLeave += PictureBox_MouseLeave;
            pictureBox1.MouseHover += PictureBox_MouseEnter;
            // 
            // FillPb
            // 
            FillPb.AccessibleName = "Bucket (F)";
            FillPb.BackgroundImage = (Image)resources.GetObject("FillPb.BackgroundImage");
            FillPb.BackgroundImageLayout = ImageLayout.Stretch;
            FillPb.Location = new Point(12, 70);
            FillPb.Name = "FillPb";
            FillPb.Size = new Size(40, 40);
            FillPb.SizeMode = PictureBoxSizeMode.CenterImage;
            FillPb.TabIndex = 3;
            FillPb.TabStop = false;
            FillPb.Click += FillPb_Click;
            FillPb.MouseLeave += PictureBox_MouseLeave;
            FillPb.MouseHover += PictureBox_MouseEnter;
            // 
            // ElipsePb
            // 
            ElipsePb.AccessibleName = "Ellipse (E)";
            ElipsePb.BackgroundImage = (Image)resources.GetObject("ElipsePb.BackgroundImage");
            ElipsePb.Location = new Point(12, 125);
            ElipsePb.Name = "ElipsePb";
            ElipsePb.Size = new Size(43, 40);
            ElipsePb.TabIndex = 4;
            ElipsePb.TabStop = false;
            ElipsePb.Click += ElipsePb_Click;
            ElipsePb.MouseEnter += PictureBox_MouseEnter;
            ElipsePb.MouseLeave += PictureBox_MouseLeave;
            // 
            // TextPb
            // 
            TextPb.AccessibleName = "Text(T)";
            TextPb.BackgroundImage = (Image)resources.GetObject("TextPb.BackgroundImage");
            TextPb.Location = new Point(12, 180);
            TextPb.Name = "TextPb";
            TextPb.Size = new Size(40, 40);
            TextPb.TabIndex = 5;
            TextPb.TabStop = false;
            TextPb.Click += TextPb_Click;
            TextPb.MouseEnter += PictureBox_MouseEnter;
            TextPb.MouseLeave += PictureBox_MouseLeave;
            // 
            // PencilPb
            // 
            PencilPb.AccessibleName = "Pencil (P)";
            PencilPb.BackgroundImage = (Image)resources.GetObject("PencilPb.BackgroundImage");
            PencilPb.Location = new Point(12, 240);
            PencilPb.Name = "PencilPb";
            PencilPb.Size = new Size(40, 40);
            PencilPb.TabIndex = 6;
            PencilPb.TabStop = false;
            PencilPb.Click += PencilPb_Click;
            PencilPb.MouseEnter += PictureBox_MouseEnter;
            PencilPb.MouseLeave += PictureBox_MouseLeave;
            // 
            // LinePb
            // 
            LinePb.AccessibleName = "Line (L)";
            LinePb.BackgroundImage = (Image)resources.GetObject("LinePb.BackgroundImage");
            LinePb.Location = new Point(96, 70);
            LinePb.Name = "LinePb";
            LinePb.Size = new Size(40, 40);
            LinePb.TabIndex = 8;
            LinePb.TabStop = false;
            LinePb.Click += LinePb_Click;
            LinePb.MouseEnter += PictureBox_MouseEnter;
            LinePb.MouseLeave += PictureBox_MouseLeave;
            // 
            // RectanglePb
            // 
            RectanglePb.AccessibleName = "Polygon (R)";
            RectanglePb.BackgroundImage = (Image)resources.GetObject("RectanglePb.BackgroundImage");
            RectanglePb.Location = new Point(96, 125);
            RectanglePb.Name = "RectanglePb";
            RectanglePb.Size = new Size(40, 40);
            RectanglePb.TabIndex = 9;
            RectanglePb.TabStop = false;
            RectanglePb.Click += RectanglePb_Click;
            RectanglePb.MouseEnter += PictureBox_MouseEnter;
            RectanglePb.MouseLeave += PictureBox_MouseLeave;
            // 
            // ColoPickPb
            // 
            ColoPickPb.AccessibleName = "Color Picker (K)";
            ColoPickPb.BackgroundImage = (Image)resources.GetObject("ColoPickPb.BackgroundImage");
            ColoPickPb.Location = new Point(96, 180);
            ColoPickPb.Name = "ColoPickPb";
            ColoPickPb.Size = new Size(40, 40);
            ColoPickPb.TabIndex = 10;
            ColoPickPb.TabStop = false;
            ColoPickPb.Click += ColoPickPb_Click;
            ColoPickPb.MouseEnter += PictureBox_MouseEnter;
            ColoPickPb.MouseLeave += PictureBox_MouseLeave;
            // 
            // MovePb
            // 
            MovePb.AccessibleName = "Move (M)";
            MovePb.BackgroundImage = (Image)resources.GetObject("MovePb.BackgroundImage");
            MovePb.Location = new Point(96, 240);
            MovePb.Name = "MovePb";
            MovePb.Size = new Size(40, 40);
            MovePb.TabIndex = 11;
            MovePb.TabStop = false;
            MovePb.Click += MovePb_Click;
            MovePb.MouseEnter += PictureBox_MouseEnter;
            MovePb.MouseLeave += PictureBox_MouseLeave;
            // 
            // ToolBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(148, 303);
            Controls.Add(MovePb);
            Controls.Add(ColoPickPb);
            Controls.Add(RectanglePb);
            Controls.Add(LinePb);
            Controls.Add(PencilPb);
            Controls.Add(TextPb);
            Controls.Add(ElipsePb);
            Controls.Add(FillPb);
            Controls.Add(pictureBox1);
            Controls.Add(Brush_Pb);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(166, 350);
            MinimumSize = new Size(166, 350);
            Name = "ToolBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Tools";
            FormClosed += ToolBox_FormClosed;
            Controls.SetChildIndex(Brush_Pb, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            Controls.SetChildIndex(FillPb, 0);
            Controls.SetChildIndex(ElipsePb, 0);
            Controls.SetChildIndex(TextPb, 0);
            Controls.SetChildIndex(PencilPb, 0);
            Controls.SetChildIndex(LinePb, 0);
            Controls.SetChildIndex(RectanglePb, 0);
            Controls.SetChildIndex(ColoPickPb, 0);
            Controls.SetChildIndex(MovePb, 0);
            ((System.ComponentModel.ISupportInitialize)Brush_Pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)FillPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ElipsePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)PencilPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)LinePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)RectanglePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColoPickPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovePb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Brush_Pb;
        private PictureBox pictureBox1;
        private PictureBox FillPb;
        private PictureBox ElipsePb;
        private PictureBox TextPb;
        private PictureBox PencilPb;
        private PictureBox LinePb;
        private PictureBox RectanglePb;
        private PictureBox ColoPickPb;
        private PictureBox MovePb;
    }
}