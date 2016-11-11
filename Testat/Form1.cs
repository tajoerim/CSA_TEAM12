﻿using System;
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

            robot = new Robot();        // neuen Roboter erstellen
            robot.Drive.Power = true;   // Stromversorgung der Motoren (im DriveCtrl) einschalten

            driveView1.Drive = robot.Drive; // DriveView benötigt Drive-Objekt zur Visualisierung
            //radarView1.Radar = robot.Radar;
            consoleView1.RobotConsole = robot.RobotConsole;

            commonRunParameters1.AccelerationChanged += AccelerationChanged;
            commonRunParameters1.SpeedChanged += SpeedChanged;
            runLineParameter.RunLineStartPressed += RunLineStartPressed;
            SpeedChanged(null, EventArgs.Empty); // Default Wert setzen
            AccelerationChanged(null, EventArgs.Empty); // Default Wert setzen

            consoleView1.RobotConsole[Switches.Switch1].SwitchStateChanged += SwitchStateChanged;
            consoleView1.RobotConsole[Switches.Switch2].SwitchStateChanged += SwitchStateChanged;
            consoleView1.RobotConsole[Switches.Switch3].SwitchStateChanged += SwitchStateChanged;
            consoleView1.RobotConsole[Switches.Switch4].SwitchStateChanged += SwitchStateChanged;
        }

        #endregion

        #region methods

        private void SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            consoleView1.RobotConsole[(Leds)(int)e.Swi].LedEnabled = e.SwitchEnabled;
        }

        private void SpeedChanged(object sender, EventArgs e)
        {
            robot.Drive.MotorCtrlLeft.Speed = commonRunParameters1.Speed;
            robot.Drive.MotorCtrlRight.Speed = commonRunParameters1.Speed;
        }

        private void AccelerationChanged(object sender, EventArgs e)
        {
            robot.Drive.MotorCtrlLeft.Acceleration = commonRunParameters1.Acceleration;
            robot.Drive.MotorCtrlRight.Acceleration = commonRunParameters1.Acceleration;
        }

        private void RunLineStartPressed(object sender, EventArgs eventArgs)
        {
            robot.Drive.RunLine(runLineParameter.Length, commonRunParameters1.Speed, commonRunParameters1.Acceleration);
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
    }
}
