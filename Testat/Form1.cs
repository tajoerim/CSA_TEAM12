using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace Testat
{
    public partial class Form1 : Form
    {
        #region members

        private Robot robot;

        #endregion

        #region constructor & destructor

        public Form1()
        {
            InitializeComponent();

            robot = new Robot(); // neuen Roboter erstellen
            robot.Drive.Power = true; // Stromversorgung der Motoren (im DriveCtrl) einschalten

            driveView1.Drive = robot.Drive; // DriveView benötigt Drive-Objekt zur Visualisierung
            //radarView1.Radar = robot.Radar;
            consoleView1.RobotConsole = robot.RobotConsole;

            commonRunParameters1.AccelerationChanged += AccelerationChanged;
            commonRunParameters1.SpeedChanged += SpeedChanged;
            runLineParameter.RunLineStartPressed += RunLineStartPressed;
            runTurnParameter.RunTurnStartPressed += RunTurnStartPressed;
            runArcParameter.RunArcStartPressed += RunArcStartPressed;
            SpeedChanged(null, EventArgs.Empty); // Default Wert setzen
            AccelerationChanged(null, EventArgs.Empty); // Default Wert setzen
        }

        #endregion

        #region methods

        private void SpeedChanged(object sender, EventArgs e)
        {
            driveView1.Drive.MotorCtrlLeft.Speed = commonRunParameters1.Speed;
            driveView1.Drive.MotorCtrlRight.Speed = commonRunParameters1.Speed;
        }

        private void AccelerationChanged(object sender, EventArgs e)
        {
            driveView1.Drive.MotorCtrlLeft.Acceleration = commonRunParameters1.Acceleration;
            driveView1.Drive.MotorCtrlRight.Acceleration = commonRunParameters1.Acceleration;
        }

        private void RunLineStartPressed(object sender, EventArgs eventArgs)
        {
            driveView1.Drive.RunLine(runLineParameter.Length, commonRunParameters1.Speed,
                commonRunParameters1.Acceleration);
        }

        private void RunTurnStartPressed(object sender, EventArgs eventArgs)
        {
            driveView1.Drive.RunTurn(runTurnParameter.Angle, commonRunParameters1.Speed,
                commonRunParameters1.Acceleration);
        }

        private void RunArcStartPressed(object sender, EventArgs eventArgs)
        {
            if (runArcParameter.TurnLeft)
            {
                driveView1.Drive.RunArcLeft(runArcParameter.Radius, runArcParameter.Angle, commonRunParameters1.Speed,
                    commonRunParameters1.Acceleration);
            }
            else
            {
                driveView1.Drive.RunArcRight(runArcParameter.Radius, runArcParameter.Angle, commonRunParameters1.Speed,
                    commonRunParameters1.Acceleration);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            robot.Drive.Stop();
        }

        private void buttonHalt_Click(object sender, EventArgs e)
        {
            robot.Drive.Halt();
        }

        #endregion

        private void timerRadar_Tick(object sender, EventArgs e)
        {

            this.progressSensor.Value = (int)(robot.Radar.Distance * 100);

            if (robot.Radar.Distance < 0.2)
            {
                robot.Drive.Halt();
            }
        }
    }
}
