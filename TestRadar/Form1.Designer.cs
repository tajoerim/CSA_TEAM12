﻿using RobotCtrl;
using RobotView;

namespace TestRadar
{
    partial class Form1
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
            this.radarView1 = new RobotView.RadarView();
            this.SuspendLayout();
            // 
            // radarView1
            // 
            this.radarView1.Location = new System.Drawing.Point(0, 0);
            this.radarView1.Name = "radarView1";
            this.radarView1.Radar = null;
            this.radarView1.Size = new System.Drawing.Size(635, 42);
            this.radarView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 58);
            this.Controls.Add(this.radarView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RadarView radarView1;
    }
}

