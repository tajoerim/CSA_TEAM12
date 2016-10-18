namespace RobotView
{
    partial class SwitchControl
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
            this.switchPictureBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // switchPictureBox
            // 
            this.switchPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchPictureBox.Image = global::RobotView.RobotViewResource.SwitchOff;
            this.switchPictureBox.Location = new System.Drawing.Point(0, 0);
            this.switchPictureBox.Name = "switchPictureBox";
            this.switchPictureBox.Size = new System.Drawing.Size(20, 40);
            // 
            // SwitchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.switchPictureBox);
            this.Name = "SwitchControl";
            this.Size = new System.Drawing.Size(20, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox switchPictureBox;
    }
}
