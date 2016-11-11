#define VARIANTE2

using System;
using System.Windows.Forms;

namespace RobotView
{
    public partial class RunTurn : UserControl
    {
        public event EventHandler<EventArgs> RunTurnStartPressed;

        public float Angle
        {
            get { return (float)upDownAngle.Value; }
            set { upDownAngle.Value = (decimal)value; }
        }

        public RunTurn()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStartOnClick;
        }

        private void BtnStartOnClick(object sender, EventArgs eventArgs)
        {
            RunTurnStartPressed?.Invoke(this, eventArgs);
        }

        private void btnSignChanger_Click(object sender, EventArgs e)
        {
            this.upDownAngle.Value = this.upDownAngle.Value * -1;
        }
    }
}