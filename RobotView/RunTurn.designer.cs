namespace RobotView
{
    partial class RunTurn
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
            this.upDownAngle = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSignChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 20);
            this.label16.Text = "RunTurn";
            // 
            // upDownAngle
            // 
            this.upDownAngle.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownAngle.Location = new System.Drawing.Point(233, 24);
            this.upDownAngle.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.upDownAngle.Name = "upDownAngle";
            this.upDownAngle.Size = new System.Drawing.Size(85, 24);
            this.upDownAngle.TabIndex = 21;
            this.upDownAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.label18.Location = new System.Drawing.Point(3, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 20);
            this.label18.Text = "Angle (+/- degrees)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(330, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 32);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            // 
            // btnSignChanger
            // 
            this.btnSignChanger.Location = new System.Drawing.Point(181, 20);
            this.btnSignChanger.Name = "btnSignChanger";
            this.btnSignChanger.Size = new System.Drawing.Size(39, 32);
            this.btnSignChanger.TabIndex = 29;
            this.btnSignChanger.Text = "+/-";
            this.btnSignChanger.Click += new System.EventHandler(this.btnSignChanger_Click);
            // 
            // RunTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnSignChanger);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.upDownAngle);
            this.Controls.Add(this.label18);
            this.Name = "RunTurn";
            this.Size = new System.Drawing.Size(421, 62);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown upDownAngle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSignChanger;
    }
}
