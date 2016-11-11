namespace RobotView
{
    partial class RunArc
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
            this.label16 = new System.Windows.Forms.Label();
            this.upDownRadius = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnKeyboardRadius = new System.Windows.Forms.Button();
            this.rdLeft = new System.Windows.Forms.RadioButton();
            this.rdRight = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.upDownAngle = new System.Windows.Forms.NumericUpDown();
            this.btnKeyboardAngle = new System.Windows.Forms.Button();
            this.btnSignChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 20);
            this.label16.Text = "RunLine";
            // 
            // upDownRadius
            // 
            this.upDownRadius.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownRadius.Location = new System.Drawing.Point(168, 40);
            this.upDownRadius.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.upDownRadius.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            -2147483648});
            this.upDownRadius.Name = "upDownRadius";
            this.upDownRadius.Size = new System.Drawing.Size(85, 24);
            this.upDownRadius.TabIndex = 21;
            this.upDownRadius.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(0, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 20);
            this.label18.Text = "Radius (+ mm)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(342, 75);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 32);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            // 
            // btnKeyboardRadius
            // 
            this.btnKeyboardRadius.Location = new System.Drawing.Point(259, 37);
            this.btnKeyboardRadius.Name = "btnKeyboardRadius";
            this.btnKeyboardRadius.Size = new System.Drawing.Size(77, 32);
            this.btnKeyboardRadius.TabIndex = 32;
            this.btnKeyboardRadius.Text = "...";
            this.btnKeyboardRadius.Click += new System.EventHandler(this.btnKeyboardRadius_Click);
            // 
            // rdLeft
            // 
            this.rdLeft.Checked = true;
            this.rdLeft.Location = new System.Drawing.Point(168, 3);
            this.rdLeft.Name = "rdLeft";
            this.rdLeft.Size = new System.Drawing.Size(100, 20);
            this.rdLeft.TabIndex = 35;
            this.rdLeft.Text = "Left";
            // 
            // rdRight
            // 
            this.rdRight.Location = new System.Drawing.Point(246, 3);
            this.rdRight.Name = "rdRight";
            this.rdRight.Size = new System.Drawing.Size(100, 20);
            this.rdRight.TabIndex = 35;
            this.rdRight.TabStop = false;
            this.rdRight.Text = "Right";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.Text = "Angle (+ mm)";
            // 
            // upDownAngle
            // 
            this.upDownAngle.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownAngle.Location = new System.Drawing.Point(168, 78);
            this.upDownAngle.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.upDownAngle.Minimum = new decimal(new int[] {
            8000,
            0,
            0,
            -2147483648});
            this.upDownAngle.Name = "upDownAngle";
            this.upDownAngle.Size = new System.Drawing.Size(85, 24);
            this.upDownAngle.TabIndex = 21;
            this.upDownAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // btnKeyboardAngle
            // 
            this.btnKeyboardAngle.Location = new System.Drawing.Point(259, 75);
            this.btnKeyboardAngle.Name = "btnKeyboardAngle";
            this.btnKeyboardAngle.Size = new System.Drawing.Size(77, 32);
            this.btnKeyboardAngle.TabIndex = 32;
            this.btnKeyboardAngle.Text = "...";
            this.btnKeyboardAngle.Click += new System.EventHandler(this.btnKeyboardAngle_Click);
            // 
            // btnSignChanger
            // 
            this.btnSignChanger.Location = new System.Drawing.Point(123, 75);
            this.btnSignChanger.Name = "btnSignChanger";
            this.btnSignChanger.Size = new System.Drawing.Size(39, 32);
            this.btnSignChanger.TabIndex = 29;
            this.btnSignChanger.Text = "+/-";
            this.btnSignChanger.Click += new System.EventHandler(this.btnSignChanger_Click);
            // 
            // RunArc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.rdRight);
            this.Controls.Add(this.rdLeft);
            this.Controls.Add(this.btnKeyboardAngle);
            this.Controls.Add(this.btnKeyboardRadius);
            this.Controls.Add(this.btnSignChanger);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.upDownAngle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upDownRadius);
            this.Controls.Add(this.label18);
            this.Name = "RunArc";
            this.Size = new System.Drawing.Size(421, 118);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown upDownRadius;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnKeyboardRadius;
        private System.Windows.Forms.RadioButton rdLeft;
        private System.Windows.Forms.RadioButton rdRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDownAngle;
        private System.Windows.Forms.Button btnKeyboardAngle;
        private System.Windows.Forms.Button btnSignChanger;
    }
}
