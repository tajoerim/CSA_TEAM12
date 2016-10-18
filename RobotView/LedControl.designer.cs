using System.Reflection;
using System.Resources;

namespace RobotView
{
    partial class LedControl
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
            this.ledPictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // ledPictureBox
            // 
            this.ledPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledPictureBox.Image = global::RobotView.RobotViewResource.LedOff;
            this.ledPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ledPictureBox.Name = "ledPictureBox";
            this.ledPictureBox.Size = new System.Drawing.Size(20, 20);
            // 
            // LedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ledPictureBox);
            this.Name = "LedControl";
            this.Size = new System.Drawing.Size(20, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ledPictureBox;
    }
}
