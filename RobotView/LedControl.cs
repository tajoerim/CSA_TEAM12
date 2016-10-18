using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class LedControl : UserControl
    {
        public LedControl()
        {
            InitializeComponent();
            this.LedState = false;
        }

        public bool LedState { get; private set; }

        public Led LedRobotControl;
    }
}