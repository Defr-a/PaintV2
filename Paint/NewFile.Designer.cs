namespace Paint
{
    partial class NewFile
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
            CancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            HeightNUD = new NumericUpDown();
            WidthNUD = new NumericUpDown();
            OkBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)HeightNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WidthNUD).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(103, 236);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 2;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Height";
            // 
            // HeightNUD
            // 
            HeightNUD.Location = new Point(90, 150);
            HeightNUD.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            HeightNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HeightNUD.Name = "HeightNUD";
            HeightNUD.Size = new Size(77, 27);
            HeightNUD.TabIndex = 5;
            HeightNUD.Value = new decimal(new int[] { 700, 0, 0, 0 });
            // 
            // WidthNUD
            // 
            WidthNUD.Location = new Point(90, 73);
            WidthNUD.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            WidthNUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WidthNUD.Name = "WidthNUD";
            WidthNUD.Size = new Size(77, 27);
            WidthNUD.TabIndex = 6;
            WidthNUD.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(3, 236);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(94, 29);
            OkBtn.TabIndex = 7;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += btnOK_Click;
            // 
            // NewFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 277);
            Controls.Add(OkBtn);
            Controls.Add(WidthNUD);
            Controls.Add(HeightNUD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewFile";
            Text = "New File";
            ((System.ComponentModel.ISupportInitialize)HeightNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)WidthNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelBtn;
        private Label label1;
        private Label label2;
        private NumericUpDown HeightNUD;
        private NumericUpDown WidthNUD;
        private Button OkBtn;
    }
}