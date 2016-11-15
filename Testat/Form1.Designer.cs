
using RobotView;

namespace Testat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private RobotView.DriveView driveView;
        private RobotView.CommonRunParameters commonRunParameters;

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
            this.timerRadar = new System.Windows.Forms.Timer();
            this.progressSensor = new System.Windows.Forms.ProgressBar();
            this.driveView1 = new RobotView.DriveView();
            this.consoleView1 = new RobotView.ConsoleView();
            this.commonRunParameters1 = new RobotView.CommonRunParameters();
            this.runTurnParameter = new RobotView.RunTurn();
            this.runLineParameter = new RobotView.RunLine();
            this.runArcParameter = new RobotView.RunArc();
            this.SuspendLayout();
            // 
            // buttonHalt
            // 
            this.buttonHalt.Location = new System.Drawing.Point(251, 357);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(70, 40);
            this.buttonHalt.TabIndex = 0;
            this.buttonHalt.Text = "Halt";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(251, 403);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 40);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            // 
            // timerRadar
            // 
            this.timerRadar.Enabled = true;
            this.timerRadar.Tick += new System.EventHandler(this.timerRadar_Tick);
            // 
            // progressSensor
            // 
            this.progressSensor.Location = new System.Drawing.Point(15, 323);
            this.progressSensor.Maximum = 300;
            this.progressSensor.Name = "progressSensor";
            this.progressSensor.Size = new System.Drawing.Size(306, 20);
            // 
            // driveView1
            // 
            this.driveView1.Drive = null;
            this.driveView1.Location = new System.Drawing.Point(3, 28);
            this.driveView1.Name = "driveView1";
            this.driveView1.Size = new System.Drawing.Size(292, 315);
            this.driveView1.TabIndex = 1;
            // 
            // consoleView1
            // 
            this.consoleView1.BackColor = System.Drawing.Color.Black;
            this.consoleView1.Location = new System.Drawing.Point(15, 369);
            this.consoleView1.Name = "consoleView1";
            this.consoleView1.RobotConsole = null;
            this.consoleView1.Size = new System.Drawing.Size(209, 46);
            this.consoleView1.TabIndex = 2;
            // 
            // commonRunParameters1
            // 
            this.commonRunParameters1.Acceleration = 0.3F;
            this.commonRunParameters1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.commonRunParameters1.Location = new System.Drawing.Point(353, 25);
            this.commonRunParameters1.Name = "commonRunParameters1";
            this.commonRunParameters1.Size = new System.Drawing.Size(429, 95);
            this.commonRunParameters1.Speed = 0.5F;
            this.commonRunParameters1.TabIndex = 4;
            // 
            // runTurnParameter
            // 
            this.runTurnParameter.Acceleration = 0F;
            this.runTurnParameter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runTurnParameter.Drive = null;
            this.runTurnParameter.Location = new System.Drawing.Point(353, 193);
            this.runTurnParameter.Name = "runTurnParameter";
            this.runTurnParameter.Size = new System.Drawing.Size(429, 62);
            this.runTurnParameter.Speed = 0F;
            this.runTurnParameter.TabIndex = 5;
            // 
            // runLineParameter
            // 
            this.runLineParameter.Acceleration = 0F;
            this.runLineParameter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runLineParameter.Drive = null;
            this.runLineParameter.Length = 1F;
            this.runLineParameter.Location = new System.Drawing.Point(353, 137);
            this.runLineParameter.Name = "runLineParameter";
            this.runLineParameter.Size = new System.Drawing.Size(528, 62);
            this.runLineParameter.Speed = 0F;
            this.runLineParameter.TabIndex = 5;
            
            // 
            // runArcParameter
            // 
            this.runArcParameter.Acceleration = 0F;
            this.runArcParameter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runArcParameter.Drive = null;
            this.runArcParameter.Location = new System.Drawing.Point(353, 261);
            this.runArcParameter.Name = "runArcParameter";
            this.runArcParameter.Size = new System.Drawing.Size(429, 118);
            this.runArcParameter.Speed = 0F;
            this.runArcParameter.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(885, 461);
            this.Controls.Add(this.progressSensor);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.driveView1);
            this.Controls.Add(this.consoleView1);
            this.Controls.Add(this.commonRunParameters1);
            this.Controls.Add(this.runTurnParameter);
            this.Controls.Add(this.runLineParameter);
            this.Controls.Add(this.runArcParameter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHalt;
        private DriveView driveView1;
        private ConsoleView consoleView1;
        private CommonRunParameters commonRunParameters1;
        private RunLine runLineParameter;
        private System.Windows.Forms.Button buttonStop;
        private RunTurn runTurnParameter;
        private RunArc runArcParameter;
        private System.Windows.Forms.Timer timerRadar;
        private System.Windows.Forms.ProgressBar progressSensor;
    }
}

