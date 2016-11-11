#define VARIANTE2

using System;
using System.Windows.Forms;

namespace RobotView
{
    public partial class RunArc : UserControl
    {
        public event EventHandler<EventArgs> RunArcStartPressed;

        public float Angle
        {
            get { return (float)upDownRadius.Value / 1000; }
            set { upDownRadius.Value = (decimal)value * 1000; }
        }

        public float Radius
        {
            get { return (float)upDownRadius.Value / 1000; }
            set { upDownRadius.Value = (decimal)value * 1000; }
        }

        public bool TurnLeft
        {
            get { return rdLeft.Checked; }
            set
            {
                rdLeft.Checked = value;
                rdRight.Checked = !value;
            }
        }

        public RunArc()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStartOnClick;
        }

        private void BtnStartOnClick(object sender, EventArgs eventArgs)
        {
            RunArcStartPressed?.Invoke(this, eventArgs);
        }

        private void btnSignChanger_Click(object sender, EventArgs e)
        {
            this.upDownAngle.Value = this.upDownAngle.Value * -1;
        }

        private void btnKeyboardRadius_Click(object sender, EventArgs e)
        {
            NumericKeyboard nk = new NumericKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                this.upDownRadius.Value = nk.GetValue();
            }
        }

        private void btnKeyboardAngle_Click(object sender, EventArgs e)
        {
            NumericKeyboard nk = new NumericKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                this.upDownAngle.Value = nk.GetValue();
            }
        }
    }
}