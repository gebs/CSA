
using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        #region members
        private Robot robot;
        #endregion
        
        #region constructor & destructor
        public Form1()
        {
            InitializeComponent();

            robot = new Robot();        // neuen Roboter erstellen
            robot.Drive.Power = true;   // Stromversorgung der Motoren (im DriveCtrl) einschalten

            runlineView.Drive = robot.Drive;
            runturnView.Drive = robot.Drive;
            runarcView.Drive = robot.Drive;
            driveView1.Drive = robot.Drive; // DriveView benötigt Drive-Objekt zur Visualisierung
            
            
            Init();
            radarView.Radar = robot.Radar;
            consoleView1.Console = robot.RobotConsole;

            commonRunParameters1.AccelerationChanged += AccelerationChanged;
            commonRunParameters1.SpeedChanged += SpeedChanged;

            SpeedChanged(null, EventArgs.Empty); // Default Wert setzen
            AccelerationChanged(null, EventArgs.Empty); // Default Wert setzen
            this.buttonHalt.Click += ButtonHalt_Click;
            this.buttonStop.Click += ButtonStop_Click;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            robot.Drive.Stop();
        }

        private void ButtonHalt_Click(object sender, EventArgs e)
        {
            robot.Drive.Halt();
        }
        #endregion

        private void Init()
        {
            runlineView.Speed = commonRunParameters1.Speed;
            runlineView.Acceleration = commonRunParameters1.Acceleration;
            runturnView.Speed = commonRunParameters1.Speed;
            runturnView.Acceleration = commonRunParameters1.Acceleration;
            runarcView.Speed = commonRunParameters1.Speed;
            runarcView.Acceleration = commonRunParameters1.Acceleration;
        }

        #region methods
        private void SpeedChanged(object sender, EventArgs e)
        {
            runlineView.Speed = commonRunParameters1.Speed;
            runturnView.Speed = commonRunParameters1.Speed;
            runarcView.Speed = commonRunParameters1.Speed;
          

        }
        private void AccelerationChanged(object sender, EventArgs e)
        {
            runlineView.Acceleration = commonRunParameters1.Acceleration;
            runturnView.Acceleration = commonRunParameters1.Acceleration;
            runarcView.Acceleration = commonRunParameters1.Acceleration;
        }



        #endregion

    }
}
