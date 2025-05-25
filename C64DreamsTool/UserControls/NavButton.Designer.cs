namespace C64DreamsTool
{
    partial class NavButton
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
            ImagePB = new stigzler.Winforms.Base.UIElements.PictureBox();
            TextLB = new stigzler.Winforms.Base.UIElements.Label();
            ((System.ComponentModel.ISupportInitialize)ImagePB).BeginInit();
            SuspendLayout();
            // 
            // ImagePB
            // 
            ImagePB.BackgroundImage = Properties.Resources.image;
            ImagePB.BackgroundImageLayout = ImageLayout.Center;
            ImagePB.InitialImage = Properties.Resources.InstallPackage;
            ImagePB.Location = new Point(3, 3);
            ImagePB.Name = "ImagePB";
            ImagePB.Size = new Size(36, 36);
            ImagePB.TabIndex = 0;
            ImagePB.TabStop = false;
            // 
            // TextLB
            // 
            TextLB.AutoSize = true;
            TextLB.Font = new Font("Segoe UI", 9F);
            TextLB.FontStyle = FontStyle.Regular;
            TextLB.ForeColor = Color.FromArgb(220, 220, 220);
            TextLB.Location = new Point(45, 13);
            TextLB.Name = "TextLB";
            TextLB.ScaleFont = 100;
            TextLB.Size = new Size(56, 15);
            TextLB.TabIndex = 1;
            TextLB.Text = "Text Here";
            TextLB.ToolTip = null;
            TextLB.ToolTipHorizontalAlignment = HorizontalAlignment.Right;
            TextLB.ToolTipImage = null;
            TextLB.ToolTipText = null;
            TextLB.ToolTipTitle = null;
            // 
            // NavButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(TextLB);
            Controls.Add(ImagePB);
            DarkMode = true;
            DoubleBuffered = true;
            Name = "NavButton";
            Size = new Size(111, 42);
            Load += NavButton_Load;
            MouseEnter += NavButton_MouseEnter;
            MouseLeave += NavButton_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)ImagePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private stigzler.Winforms.Base.UIElements.PictureBox ImagePB;
        private stigzler.Winforms.Base.UIElements.Label TextLB;
    }
}
