namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            addFileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            Canvas_Img = new PictureBox();
            panel1 = new Panel();
            BSizeNUD = new NumericUpDown();
            BrushSizeLb = new Label();
            Current = new Label();
            ToolLabel = new Label();
            colorBox = new PictureBox();
            cLabel = new Label();
            WorkPlacePnl = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas_Img).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSizeNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorBox).BeginInit();
            WorkPlacePnl.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GrayText;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, editToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, addFileToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(147, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // addFileToolStripMenuItem
            // 
            addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            addFileToolStripMenuItem.Size = new Size(147, 26);
            addFileToolStripMenuItem.Text = "Open";
            addFileToolStripMenuItem.Click += addFileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(147, 26);
            openToolStripMenuItem.Text = "Add File";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(147, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(147, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolsToolStripMenuItem, colorsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(177, 26);
            toolsToolStripMenuItem.Text = "Tools";
            toolsToolStripMenuItem.Click += toolsToolStripMenuItem_Click;
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(177, 26);
            colorsToolStripMenuItem.Text = "Color Palette";
            colorsToolStripMenuItem.Click += colorsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(128, 26);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(128, 26);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(128, 26);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(30, 24);
            toolStripMenuItem1.Text = "?";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(98, 26);
            toolStripMenuItem3.Text = "\\";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // Canvas_Img
            // 
            Canvas_Img.BackColor = Color.White;
            Canvas_Img.Dock = DockStyle.Fill;
            Canvas_Img.Location = new Point(0, 0);
            Canvas_Img.MinimumSize = new Size(10, 10);
            Canvas_Img.Name = "Canvas_Img";
            Canvas_Img.Size = new Size(1000, 750);
            Canvas_Img.TabIndex = 1;
            Canvas_Img.TabStop = false;
            Canvas_Img.Paint += Canvas_Img_Paint;
            Canvas_Img.MouseDown += Canvas_Img_MouseDown;
            Canvas_Img.MouseMove += Canvas_Img_MouseMove;
            Canvas_Img.MouseUp += Canvas_Img_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(BSizeNUD);
            panel1.Controls.Add(BrushSizeLb);
            panel1.Controls.Add(Current);
            panel1.Controls.Add(ToolLabel);
            panel1.Controls.Add(colorBox);
            panel1.Controls.Add(cLabel);
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 40);
            panel1.TabIndex = 3;
            // 
            // BSizeNUD
            // 
            BSizeNUD.Location = new Point(466, 7);
            BSizeNUD.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            BSizeNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            BSizeNUD.Name = "BSizeNUD";
            BSizeNUD.Size = new Size(43, 27);
            BSizeNUD.TabIndex = 5;
            BSizeNUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            BSizeNUD.ValueChanged += BSizeNUD_ValueChanged;
            // 
            // BrushSizeLb
            // 
            BrushSizeLb.AutoSize = true;
            BrushSizeLb.ForeColor = Color.White;
            BrushSizeLb.Location = new Point(381, 12);
            BrushSizeLb.Name = "BrushSizeLb";
            BrushSizeLb.Size = new Size(79, 20);
            BrushSizeLb.TabIndex = 4;
            BrushSizeLb.Text = "Brush Size:";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.ForeColor = Color.White;
            Current.Location = new Point(321, 12);
            Current.Name = "Current";
            Current.Size = new Size(42, 20);
            Current.TabIndex = 3;
            Current.Text = "none";
            // 
            // ToolLabel
            // 
            ToolLabel.AutoSize = true;
            ToolLabel.ForeColor = Color.White;
            ToolLabel.Location = new Point(218, 12);
            ToolLabel.Name = "ToolLabel";
            ToolLabel.Size = new Size(97, 20);
            ToolLabel.TabIndex = 2;
            ToolLabel.Text = "Current Tool :";
            // 
            // colorBox
            // 
            colorBox.BackColor = Color.Black;
            colorBox.BorderStyle = BorderStyle.Fixed3D;
            colorBox.Location = new Point(70, 7);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(125, 29);
            colorBox.TabIndex = 1;
            colorBox.TabStop = false;
            colorBox.Click += colorsToolStripMenuItem_Click;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.ForeColor = Color.White;
            cLabel.Location = new Point(12, 12);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(52, 20);
            cLabel.TabIndex = 0;
            cLabel.Text = "Color :";
            // 
            // WorkPlacePnl
            // 
            WorkPlacePnl.AutoScroll = true;
            WorkPlacePnl.AutoScrollMinSize = new Size(1000, 750);
            WorkPlacePnl.Controls.Add(Canvas_Img);
            WorkPlacePnl.Location = new Point(460, 165);
            WorkPlacePnl.Name = "WorkPlacePnl";
            WorkPlacePnl.Size = new Size(1000, 750);
            WorkPlacePnl.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(WorkPlacePnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Paint.Df";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas_Img).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BSizeNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorBox).EndInit();
            WorkPlacePnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private PictureBox Canvas_Img;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private Panel panel1;
        private PictureBox colorBox;
        private Label cLabel;
        private Label ToolLabel;
        private Label Current;
        private Label BrushSizeLb;
        private NumericUpDown BSizeNUD;
        private Panel WorkPlacePnl;
        private ToolStripMenuItem addFileToolStripMenuItem;
    }
}
