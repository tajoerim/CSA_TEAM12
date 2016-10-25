using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class ConsoleControl : UserControl
    {
        private RobotConsole robotConsole;

        public ConsoleControl()
        {
            InitializeComponent();
        }

        public RobotConsole RobotConsole
        {
            get { return this.robotConsole; }
            set
            {
                this.robotConsole = value;
                if (value != null)
                {
                    leftLedControl.LedRobotControl = robotConsole[Leds.Led1];
                    leftMiddleLedControl.LedRobotControl = robotConsole[Leds.Led2];
                    rightMiddleLedControl.LedRobotControl = robotConsole[Leds.Led3];
                    rightLedControl.LedRobotControl = robotConsole[Leds.Led4];

                    leftSwitchControl.SwitchRobotControl = robotConsole[Switches.Switch1];
                    leftMiddleSwitchControl.SwitchRobotControl = robotConsole[Switches.Switch2];
                    rightSwitchControl.SwitchRobotControl = robotConsole[Switches.Switch3];
                    rightMiddleSwitchControl.SwitchRobotControl = robotConsole[Switches.Switch4];
                }
            }
        }
    }
}