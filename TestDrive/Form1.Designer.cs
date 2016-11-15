﻿using RobotCtrl;
using RobotView;

namespace TestDrive
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
            this.buttonHalt = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.driveView1 = new RobotView.DriveView();
            this.consoleView1 = new RobotView.ConsoleView();
            this.commonRunParameters1 = new RobotView.CommonRunParameters();
            this.runLine1 = new RobotView.RunLine();
            this.runTurn1 = new RobotView.RunTurn();
            this.runArc1 = new RobotView.RunArc();
            this.radarView1 = new RobotView.RadarView();
            this.SuspendLayout();
            // 
            // buttonHalt
            // 
            this.buttonHalt.Location = new System.Drawing.Point(248, 335);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(70, 40);
            this.buttonHalt.TabIndex = 0;
            this.buttonHalt.Text = "Halt";
            this.buttonHalt.Click += new System.EventHandler(this.buttonHalt_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(248, 381);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 40);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // driveView1
            // 
            this.driveView1.Drive = null;
            this.driveView1.Location = new System.Drawing.Point(0, 6);
            this.driveView1.Name = "driveView1";
            this.driveView1.Size = new System.Drawing.Size(292, 315);
            this.driveView1.TabIndex = 1;
            // 
            // consoleView1
            // 
            this.consoleView1.BackColor = System.Drawing.Color.Black;
            this.consoleView1.Location = new System.Drawing.Point(12, 347);
            this.consoleView1.Name = "consoleView1";
            this.consoleView1.RobotConsole = null;
            this.consoleView1.Size = new System.Drawing.Size(209, 46);
            this.consoleView1.TabIndex = 2;
            // 
            // commonRunParameters1
            // 
            this.commonRunParameters1.Acceleration = 0.3F;
            this.commonRunParameters1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.commonRunParameters1.Location = new System.Drawing.Point(350, 3);
            this.commonRunParameters1.Name = "commonRunParameters1";
            this.commonRunParameters1.Size = new System.Drawing.Size(351, 84);
            this.commonRunParameters1.Speed = 0.5F;
            this.commonRunParameters1.TabIndex = 4;
            // 
            // runLine1
            // 
            this.runLine1.Acceleration = 0F;
            this.runLine1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runLine1.Drive = null;
            this.runLine1.Length = 1F;
            this.runLine1.Location = new System.Drawing.Point(350, 93);
            this.runLine1.Name = "runLine1";
            this.runLine1.Size = new System.Drawing.Size(351, 46);
            this.runLine1.Speed = 0F;
            this.runLine1.TabIndex = 5;
            // 
            // runTurn1
            // 
            this.runTurn1.Acceleration = 0F;
            this.runTurn1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runTurn1.Drive = null;
            this.runTurn1.Location = new System.Drawing.Point(350, 145);
            this.runTurn1.Name = "runTurn1";
            this.runTurn1.Size = new System.Drawing.Size(353, 45);
            this.runTurn1.Speed = 0F;
            this.runTurn1.TabIndex = 6;
            // 
            // runArc1
            // 
            this.runArc1.Acceleration = 0F;
            this.runArc1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runArc1.Drive = null;
            this.runArc1.Location = new System.Drawing.Point(350, 196);
            this.runArc1.Name = "runArc1";
            this.runArc1.Size = new System.Drawing.Size(351, 90);
            this.runArc1.Speed = 0F;
            this.runArc1.TabIndex = 7;
            // 
            // radarView1
            // 
            this.radarView1.Location = new System.Drawing.Point(350, 335);
            this.radarView1.Name = "radarView1";
            this.radarView1.Radar = null;
            this.radarView1.Size = new System.Drawing.Size(353, 42);
            this.radarView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(798, 435);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.driveView1);
            this.Controls.Add(this.consoleView1);
            this.Controls.Add(this.commonRunParameters1);
            this.Controls.Add(this.runLine1);
            this.Controls.Add(this.runTurn1);
            this.Controls.Add(this.runArc1);
            this.Controls.Add(this.radarView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHalt;
        private DriveView driveView1;
        private ConsoleView consoleView1;
        private CommonRunParameters commonRunParameters1;
        private RunLine runLine1;
        private RunTurn runTurn1;
        private RunArc runArc1;
        private System.Windows.Forms.Button buttonStop;
        private RadarView radarView1;
    }
}

