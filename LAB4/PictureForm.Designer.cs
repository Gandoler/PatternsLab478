namespace LAB4
{
    partial class PictureForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.BackColor = SystemColors.InactiveCaptionText;
            PictureBox.CustomizableEdges = customizableEdges1;
            PictureBox.FillColor = Color.Black;
            PictureBox.ImageRotate = 0F;
            PictureBox.Location = new Point(536, 106);
            PictureBox.Name = "PictureBox";
            PictureBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PictureBox.Size = new Size(300, 200);
            PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // PictureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1784, 661);
            Controls.Add(PictureBox);
            Name = "PictureForm";
            Text = "PictureForm";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureBox;
    }
}