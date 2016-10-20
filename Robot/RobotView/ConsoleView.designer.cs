namespace RobotView
{
    partial class ConsoleView
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
            this.ledview1 = new RobotView.LedView();
            this.ledview2 = new RobotView.LedView();
            this.ledview3 = new RobotView.LedView();
            this.ledview4 = new RobotView.LedView();
            this.switchview1 = new RobotView.SwitchView();
            this.switchview2 = new RobotView.SwitchView();
            this.switchview3 = new RobotView.SwitchView();
            this.switchview4 = new RobotView.SwitchView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ledview1
            // 
            this.ledview1.Led = null;
            this.ledview1.Location = new System.Drawing.Point(3, 3);
            this.ledview1.Name = "ledview1";
            this.ledview1.Size = new System.Drawing.Size(22, 22);
            this.ledview1.State = true;
            this.ledview1.TabIndex = 1;
            // 
            // ledview2
            // 
            this.ledview2.Led = null;
            this.ledview2.Location = new System.Drawing.Point(31, 3);
            this.ledview2.Name = "ledview2";
            this.ledview2.Size = new System.Drawing.Size(22, 22);
            this.ledview2.State = false;
            this.ledview2.TabIndex = 0;
            // 
            // ledview3
            // 
            this.ledview3.Led = null;
            this.ledview3.Location = new System.Drawing.Point(59, 3);
            this.ledview3.Name = "ledview3";
            this.ledview3.Size = new System.Drawing.Size(22, 22);
            this.ledview3.State = false;
            this.ledview3.TabIndex = 0;
            // 
            // ledview4
            // 
            this.ledview4.Led = null;
            this.ledview4.Location = new System.Drawing.Point(87, 3);
            this.ledview4.Name = "ledview4";
            this.ledview4.Size = new System.Drawing.Size(22, 22);
            this.ledview4.State = false;
            this.ledview4.TabIndex = 0;
            // 
            // switchview1
            // 
            this.switchview1.Location = new System.Drawing.Point(115, 3);
            this.switchview1.Myswitch = null;
            this.switchview1.Name = "switchview1";
            this.switchview1.Size = new System.Drawing.Size(22, 42);
            this.switchview1.State = true;
            this.switchview1.TabIndex = 0;
            // 
            // switchview2
            // 
            this.switchview2.Location = new System.Drawing.Point(143, 3);
            this.switchview2.Myswitch = null;
            this.switchview2.Name = "switchview2";
            this.switchview2.Size = new System.Drawing.Size(22, 42);
            this.switchview2.State = false;
            this.switchview2.TabIndex = 0;
            // 
            // switchview3
            // 
            this.switchview3.Location = new System.Drawing.Point(171, 3);
            this.switchview3.Myswitch = null;
            this.switchview3.Name = "switchview3";
            this.switchview3.Size = new System.Drawing.Size(22, 42);
            this.switchview3.State = false;
            this.switchview3.TabIndex = 0;
            // 
            // switchview4
            // 
            this.switchview4.Location = new System.Drawing.Point(199, 3);
            this.switchview4.Myswitch = null;
            this.switchview4.Name = "switchview4";
            this.switchview4.Size = new System.Drawing.Size(22, 42);
            this.switchview4.State = false;
            this.switchview4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 22);
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 22);
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(59, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 22);
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(87, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 22);
            this.label4.Text = "3";
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ledview1);
            this.Controls.Add(this.ledview2);
            this.Controls.Add(this.ledview3);
            this.Controls.Add(this.ledview4);
            this.Controls.Add(this.switchview1);
            this.Controls.Add(this.switchview2);
            this.Controls.Add(this.switchview3);
            this.Controls.Add(this.switchview4);
            this.Name = "ConsoleView";
            this.Size = new System.Drawing.Size(228, 52);
            this.ResumeLayout(false);

        }

        #endregion
        private LedView ledview1;
        private LedView ledview2;
        private LedView ledview3;
        private LedView ledview4;

        private SwitchView switchview1;
        private SwitchView switchview2;
        private SwitchView switchview3;
        private SwitchView switchview4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
