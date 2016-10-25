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
    public partial class SwitchControl : UserControl
    {
        private Switch switchRobotControl;
        private bool switchState;

        public SwitchControl()
        {
            InitializeComponent();
        }

        public bool SwitchState
        {
            get { return this.switchState; }
            set
            {
                this.switchState = value;
                switchPictureBox.Image = (value ? RobotViewResource.SwitchOn : RobotViewResource.SwitchOff);
            }
        }

        public Switch SwitchRobotControl
        {
            get { return this.switchRobotControl; }
            set
            {
                if (this.switchRobotControl != null)
                {
                    this.switchRobotControl.SwitchStateChanged -= this.SwitchStateChanged;
                }
                this.switchRobotControl = value;
                if (this.switchRobotControl != null)
                {
                    this.switchRobotControl.SwitchStateChanged += this.SwitchStateChanged;
                }
            }
        }

        private void SwitchStateChanged(object sender, SwitchEventArgs eventArgs)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(SwitchStateChanged), sender, eventArgs);
            }
            else
            {
                this.SwitchState = eventArgs.SwitchEnabled;
            }
        }
    }
}