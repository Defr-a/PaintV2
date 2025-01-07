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
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            rulersToolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            Canvas_Img = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
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
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSizeNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorBox).BeginInit();
            WorkPlacePnl.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, printToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(128, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(128, 26);
            printToolStripMenuItem.Text = "Print";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolsToolStripMenuItem, rulersToolStripMenuItem, colorsToolStripMenuItem });
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
            // rulersToolStripMenuItem
            // 
            rulersToolStripMenuItem.Name = "rulersToolStripMenuItem";
            rulersToolStripMenuItem.Size = new Size(177, 26);
            rulersToolStripMenuItem.Text = "Rulers";
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
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(128, 26);
            redoToolStripMenuItem.Text = "Redo";
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
            toolStripMenuItem3.Size = new Size(224, 26);
            toolStripMenuItem3.Text = "\\";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // Canvas_Img
            // 
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
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1902, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(39, 24);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // panel1
            // 
            panel1.Controls.Add(BSizeNUD);
            panel1.Controls.Add(BrushSizeLb);
            panel1.Controls.Add(Current);
            panel1.Controls.Add(ToolLabel);
            panel1.Controls.Add(colorBox);
            panel1.Controls.Add(cLabel);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 34);
            panel1.TabIndex = 3;
            // 
            // BSizeNUD
            // 
            BSizeNUD.Location = new Point(466, 5);
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
            BrushSizeLb.Location = new Point(381, 8);
            BrushSizeLb.Name = "BrushSizeLb";
            BrushSizeLb.Size = new Size(79, 20);
            BrushSizeLb.TabIndex = 4;
            BrushSizeLb.Text = "Brush Size:";
            // 
            // Current
            // 
            Current.AutoSize = true;
            Current.Location = new Point(311, 8);
            Current.Name = "Current";
            Current.Size = new Size(42, 20);
            Current.TabIndex = 3;
            Current.Text = "none";
            // 
            // ToolLabel
            // 
            ToolLabel.AutoSize = true;
            ToolLabel.Location = new Point(218, 8);
            ToolLabel.Name = "ToolLabel";
            ToolLabel.Size = new Size(97, 20);
            ToolLabel.TabIndex = 2;
            ToolLabel.Text = "Current Tool :";
            // 
            // colorBox
            // 
            colorBox.BackColor = Color.Black;
            colorBox.BorderStyle = BorderStyle.FixedSingle;
            colorBox.Location = new Point(68, 3);
            colorBox.Name = "colorBox";
            colorBox.Size = new Size(125, 29);
            colorBox.TabIndex = 1;
            colorBox.TabStop = false;
            colorBox.Click += colorsToolStripMenuItem_Click;
            // 
            // cLabel
            // 
            cLabel.AutoSize = true;
            cLabel.Location = new Point(3, 8);
            cLabel.Name = "cLabel";
            cLabel.Size = new Size(52, 20);
            cLabel.TabIndex = 0;
            cLabel.Text = "Color :";
            // 
            // WorkPlacePnl
            // 
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
            ClientSize = new Size(1902, 1033);
            Controls.Add(WorkPlacePnl);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Paint.Df";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas_Img).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem rulersToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private PictureBox Canvas_Img;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private ToolStripSplitButton toolStripSplitButton1;
        private PictureBox colorBox;
        private Label cLabel;
        private Label ToolLabel;
        private Label Current;
        private Label BrushSizeLb;
        private NumericUpDown BSizeNUD;
        private Panel WorkPlacePnl;
    }
}
