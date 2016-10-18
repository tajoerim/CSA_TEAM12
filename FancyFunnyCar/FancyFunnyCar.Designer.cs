using RobotView;

namespace FancyFunnyCar
{
    partial class FancyFunnyCar
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
            this.consoleControl = new ConsoleControl();
            this.SuspendLayout();
            // 
            // FancyFunnyCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(607, 127);
            this.Name = "FancyFunnyCar";
            this.Text = "FancFunnyCar - EPIC Robot";
            this.Controls.Add(this.consoleControl);
            this.ResumeLayout(false);

        }

        #endregion

        private ConsoleControl consoleControl;
    }
}

