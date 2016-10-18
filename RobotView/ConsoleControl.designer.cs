namespace RobotView
{
    partial class ConsoleControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftLedControl = new RobotView.LedControl();
            this.rightMiddleLedControl = new RobotView.LedControl();
            this.leftMiddleLedControl = new RobotView.LedControl();
            this.rightLedControl = new RobotView.LedControl();
            this.leftSwitchControl = new RobotView.SwitchControl();
            this.leftMiddleSwitchControl = new RobotView.SwitchControl();
            this.rightMiddleSwitchControl = new RobotView.SwitchControl();
            this.rightSwitchControl = new RobotView.SwitchControl();
            this.leftLedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftLedControl
            // 
            this.leftLedControl.Location = new System.Drawing.Point(0, 0);
            this.leftLedControl.Name = "leftLedControl";
            this.leftLedControl.Size = new System.Drawing.Size(80, 80);
            this.leftLedControl.TabIndex = 8;
            // 
            // rightMiddleLedControl
            // 
            this.rightMiddleLedControl.Location = new System.Drawing.Point(172, 0);
            this.rightMiddleLedControl.Name = "rightMiddleLedControl";
            this.rightMiddleLedControl.Size = new System.Drawing.Size(80, 80);
            this.rightMiddleLedControl.TabIndex = 10;
            // 
            // leftMiddleLedControl
            // 
            this.leftMiddleLedControl.Location = new System.Drawing.Point(258, 0);
            this.leftMiddleLedControl.Name = "leftMiddleLedControl";
            this.leftMiddleLedControl.Size = new System.Drawing.Size(80, 80);
            this.leftMiddleLedControl.TabIndex = 9;
            // 
            // rightLedControl
            // 
            this.rightLedControl.Location = new System.Drawing.Point(86, 0);
            this.rightLedControl.Name = "rightLedControl";
            this.rightLedControl.Size = new System.Drawing.Size(80, 80);
            this.rightLedControl.TabIndex = 11;
            // 
            // leftSwitchControl
            // 
            this.leftSwitchControl.Location = new System.Drawing.Point(344, 0);
            this.leftSwitchControl.Name = "leftSwitchControl";
            this.leftSwitchControl.Size = new System.Drawing.Size(60, 120);
            this.leftSwitchControl.TabIndex = 12;
            // 
            // leftMiddleSwitchControl
            // 
            this.leftMiddleSwitchControl.Location = new System.Drawing.Point(410, 0);
            this.leftMiddleSwitchControl.Name = "leftMiddleSwitchControl";
            this.leftMiddleSwitchControl.Size = new System.Drawing.Size(60, 120);
            this.leftMiddleSwitchControl.TabIndex = 13;
            // 
            // rightMiddleSwitchControl
            // 
            this.rightMiddleSwitchControl.Location = new System.Drawing.Point(476, 0);
            this.rightMiddleSwitchControl.Name = "rightMiddleSwitchControl";
            this.rightMiddleSwitchControl.Size = new System.Drawing.Size(60, 120);
            this.rightMiddleSwitchControl.TabIndex = 14;
            // 
            // rightSwitchControl
            // 
            this.rightSwitchControl.Location = new System.Drawing.Point(542, 0);
            this.rightSwitchControl.Name = "rightSwitchControl";
            this.rightSwitchControl.Size = new System.Drawing.Size(60, 120);
            this.rightSwitchControl.TabIndex = 15;
            // 
            // leftLedLabel
            // 
            this.leftLedLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftLedLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftLedLabel.Location = new System.Drawing.Point(29, 83);
            this.leftLedLabel.Name = "leftLedLabel";
            this.leftLedLabel.Size = new System.Drawing.Size(17, 24);
            this.leftLedLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(118, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 24);
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(201, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 24);
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(290, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.Text = "3";
            // 
            // ConsolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftLedLabel);
            this.Controls.Add(this.leftLedControl);
            this.Controls.Add(this.rightMiddleLedControl);
            this.Controls.Add(this.leftMiddleLedControl);
            this.Controls.Add(this.rightLedControl);
            this.Controls.Add(this.leftSwitchControl);
            this.Controls.Add(this.leftMiddleSwitchControl);
            this.Controls.Add(this.rightMiddleSwitchControl);
            this.Controls.Add(this.rightSwitchControl);
            this.Name = "ConsolControl";
            this.Size = new System.Drawing.Size(603, 122);
            this.ResumeLayout(false);

        }

        #endregion

        private LedControl leftLedControl;
        private LedControl rightMiddleLedControl;
        private LedControl leftMiddleLedControl;
        private LedControl rightLedControl;
        private SwitchControl leftSwitchControl;
        private SwitchControl leftMiddleSwitchControl;
        private SwitchControl rightMiddleSwitchControl;
        private SwitchControl rightSwitchControl;
        private System.Windows.Forms.Label leftLedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
