#define VARIANTE2

using System;
using System.Windows.Forms;

namespace RobotView
{
    public partial class RunLine : UserControl
    {
        public event EventHandler<EventArgs> RunLineStartPressed;

        public float Length
        {
            get { return (float)upDownLength.Value / 1000; }
            set { upDownLength.Value = (decimal)value * 1000; }
        }

        public RunLine()
        {
            InitializeComponent();
            this.btnStart.Click += BtnStartOnClick;
        }

        private void BtnStartOnClick(object sender, EventArgs eventArgs)
        {
            RunLineStartPressed?.Invoke(this, eventArgs);
        }

        private void btnSignChanger_Click(object sender, EventArgs e)
        {
            this.upDownLength.Value = this.upDownLength.Value * -1;
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            NumericKeyboard nk = new NumericKeyboard();
            if (nk.ShowDialog() == DialogResult.OK)
            {
                this.upDownLength.Value = nk.GetValue();
            }
        }
    }
}