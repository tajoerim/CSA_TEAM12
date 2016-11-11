using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class NumericKeyboard : Form
    {
        public NumericKeyboard()
        {
            InitializeComponent();
        }

        public decimal GetValue()
        {
            try
            {
                return decimal.Parse(this.txtValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to parse value to decimal!");
            }

            return 0;
        }

        private void AddValue(int val)
        {
            this.txtValue.Text = (GetValue() + val).ToString();
        }

        private void SubValue(int val)
        {
            AddValue(val * -1);
        }

        private void ConcatValue(int val)
        {
            this.txtValue.Text = GetValue() == 0 ? val.ToString() : this.txtValue.Text += val.ToString();
        }

        private void ClearValue()
        {
            this.txtValue.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ConcatValue(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ConcatValue(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ConcatValue(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ConcatValue(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ConcatValue(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ConcatValue(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ConcatValue(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ConcatValue(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ConcatValue(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ConcatValue(0);
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            this.txtValue.Text = (GetValue() * -1).ToString();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            SubValue(1);
        }

        private void btnSub10_Click(object sender, EventArgs e)
        {
            SubValue(10);
        }

        private void btnSub100_Click(object sender, EventArgs e)
        {
            SubValue(100);
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            AddValue(1);
        }

        private void btnAdd10_Click(object sender, EventArgs e)
        {
            AddValue(10);
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            AddValue(100);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (GetValue() == 0) { return; }
            if (GetValue() < 10) { ClearValue(); }
            this.txtValue.Text = this.txtValue.Text.Substring(0, this.txtValue.Text.Length - 1);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ClearValue();
        }
    }
}