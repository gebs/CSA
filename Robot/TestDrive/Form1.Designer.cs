using RobotCtrl;
using RobotView;

namespace TestDrive
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHalt = new System.Windows.Forms.Button();
            this.driveView1 = new RobotView.DriveView();
            this.consoleView1 = new RobotView.ConsoleView();
            this.buttonStop = new System.Windows.Forms.Button();
            this.commonRunParameters1 = new RobotView.CommonRunParameters();
            this.runlineView = new RobotView.RunLineView();
            this.runturnView = new RobotView.RunTurnView();
            this.runarcView = new RobotView.RunArcView();
            this.radarView = new RobotView.RadarView();
            this.SuspendLayout();
            // 
            // buttonHalt
            // 
            this.buttonHalt.Location = new System.Drawing.Point(248, 335);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(70, 40);
            this.buttonHalt.TabIndex = 0;
            this.buttonHalt.Text = "Halt";
       
            // 
            // driveView1
            // 
            this.driveView1.Drive = null;
            this.driveView1.Location = new System.Drawing.Point(12, 4);
            this.driveView1.Name = "driveView1";
            this.driveView1.Size = new System.Drawing.Size(292, 315);
            this.driveView1.TabIndex = 1;
            // 
            // consoleView1
            // 
            this.consoleView1.BackColor = System.Drawing.Color.Black;
            this.consoleView1.Console = null;
            this.consoleView1.Location = new System.Drawing.Point(12, 347);
            this.consoleView1.Name = "consoleView1";
            this.consoleView1.Size = new System.Drawing.Size(209, 46);
            this.consoleView1.TabIndex = 2;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(248, 381);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 40);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
           
            // 
            // commonRunParameters1
            // 
            this.commonRunParameters1.Acceleration = 0.3F;
            this.commonRunParameters1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.commonRunParameters1.Location = new System.Drawing.Point(350, 3);
            this.commonRunParameters1.Name = "commonRunParameters1";
            this.commonRunParameters1.Size = new System.Drawing.Size(351, 84);
            this.commonRunParameters1.Speed = 0.5F;
            this.commonRunParameters1.TabIndex = 4;
            // 
            // runlineView
            // 
            this.runlineView.Acceleration = 0F;
            this.runlineView.Drive = null;
            this.runlineView.Location = new System.Drawing.Point(350, 94);
            this.runlineView.Name = "runlineView";
            this.runlineView.Size = new System.Drawing.Size(351, 56);
            this.runlineView.Speed = 0F;
            this.runlineView.TabIndex = 5;
            // 
            // runturnView
            // 
            this.runturnView.Acceleration = 0F;
            this.runturnView.Drive = null;
            this.runturnView.Location = new System.Drawing.Point(350, 156);
            this.runturnView.Name = "runturnView";
            this.runturnView.Size = new System.Drawing.Size(351, 55);
            this.runturnView.Speed = 0F;
            this.runturnView.TabIndex = 6;
            // 
            // runarcView
            // 
            this.runarcView.Acceleration = 0F;
            this.runarcView.Drive = null;
            this.runarcView.Location = new System.Drawing.Point(350, 217);
            this.runarcView.Name = "runarcView";
            this.runarcView.Size = new System.Drawing.Size(351, 107);
            this.runarcView.Speed = 0F;
            this.runarcView.TabIndex = 7;
            // 
            // radarView
            // 
            this.radarView.Location = new System.Drawing.Point(350, 335);
            this.radarView.Name = "radarView";
            this.radarView.Size = new System.Drawing.Size(351, 52);
            this.radarView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(798, 435);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.driveView1);
            this.Controls.Add(this.consoleView1);
            this.Controls.Add(this.commonRunParameters1);
            this.Controls.Add(this.runlineView);
            this.Controls.Add(this.runturnView);
            this.Controls.Add(this.runarcView);
            this.Controls.Add(this.radarView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button buttonHalt;
        private DriveView driveView1;
        private ConsoleView consoleView1;
        private CommonRunParameters commonRunParameters1;
        private System.Windows.Forms.Button buttonStop;
        private RunLineView runlineView;
        private RunTurnView runturnView;
        private RunArcView runarcView;
        private RadarView radarView;
    }
}

