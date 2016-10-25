using System;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class LedControl : UserControl
    {
        private Led led;
        private bool ledState;

        public LedControl()
        {
            InitializeComponent();
            this.LedState = false;
        }

        public bool LedState
        {
            get { return this.ledState; }
            set
            {
                this.ledState = value;
                ledPictureBox.Image = (value ? RobotViewResource.LedOn : RobotViewResource.LedOff);
            }
        }

        public Led LedRobotControl
        {
            get { return this.led; }
            set
            {
                if(this.led != null)
                {
                    this.led.LedStateChanged -= this.LedStateChanged;
                }
                this.led = value;
                if(this.led != null)
                {
                    this.led.LedStateChanged += this.LedStateChanged;
                }
            }
        }

        private void LedStateChanged(object sender, LedEventArgs eventArgs)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<LedEventArgs>(LedStateChanged), sender, eventArgs);
            }
            {
                this.LedState = eventArgs.LedEnabled;
            }
        }
    }
}