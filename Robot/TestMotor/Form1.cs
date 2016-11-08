using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace TestMotor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.motorright.MotorCtrl = new MotorCtrl(Constants.IOMotorCtrlRight);
            this.motorleft.MotorCtrl = new MotorCtrl(Constants.IOMotorCtrlLeft);
            this.driveControl.DriveCtrl = new DriveCtrl(Constants.IODriveCtrl);
        }
    }
}
