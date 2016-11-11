#define VARIANTE2

using System;
using System.Windows.Forms;

namespace RobotView
{
    public partial class RunTurn : UserControl
    {
        public event EventHandler<EventArgs> RunTurnLengthChagned;
        public event EventHandler<EventArgs> RunTurnStartPressed;

        public float Length
        {
            get { return (float)upDownLength.Value; }
            set { upDownLength.Value = (decimal)value; }
        }

        public RunTurn()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStartOnClick;
            this.upDownLength.ValueChanged += UpDownLengthOnValueChanged;
        }

        private void BtnStartOnClick(object sender, EventArgs eventArgs)
        {
            RunTurnStartPressed?.Invoke(this, eventArgs);
        }

        private void UpDownLengthOnValueChanged(object sender, EventArgs eventArgs)
        {
            //RunTurnLengthChagned?.Invoke(this, eventArgs);
        }

        private void btnSignChanger_Click(object sender, EventArgs e)
        {
            this.upDownLength.Value = this.upDownLength.Value * -1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}