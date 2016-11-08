using RobotView;

namespace TestMotor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.motorleft = new RobotView.MotorCtrlView();
            this.motorright = new RobotView.MotorCtrlView();
            this.driveControl = new RobotView.DriveCtrlView();
            this.SuspendLayout();
            // 
            // motorleft
            // 
            this.motorleft.Location = new System.Drawing.Point(0, 0);
            this.motorleft.MotorCtrl = null;
            this.motorleft.Name = "motorleft";
            this.motorleft.Size = new System.Drawing.Size(427, 252);
            this.motorleft.TabIndex = 1;
            // 
            // motorright
            // 
            this.motorright.Location = new System.Drawing.Point(433, 3);
            this.motorright.MotorCtrl = null;
            this.motorright.Name = "motorright";
            this.motorright.Size = new System.Drawing.Size(427, 249);
            this.motorright.TabIndex = 5;
            // 
            // driveControl
            // 
            this.driveControl.DriveCtrl = null;
            this.driveControl.Location = new System.Drawing.Point(231, 259);
            this.driveControl.Name = "driveControl";
            this.driveControl.Size = new System.Drawing.Size(342, 71);
            this.driveControl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(864, 335);
            this.Controls.Add(this.motorleft);
            this.Controls.Add(this.motorright);
            this.Controls.Add(this.driveControl);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveCtrlView driveControl;
        private RobotView.MotorCtrlView motorleft;
        private RobotView.MotorCtrlView motorright;

    }
}

