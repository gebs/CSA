using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RobotCtrl;

namespace RobotView
{
    public partial class RunArcView : UserControl
    {
        private float speed;

        public Drive Drive { get; set; }

        public float Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public float Acceleration
        {
            get
            {
                return acceleration;
            }

            set
            {
                acceleration = value;
            }
        }

        private float acceleration;
        public RunArcView()
        {
            InitializeComponent();
        }



        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (rbLeft.Checked)
                this.Drive.RunArcLeft((float)this.npRadius.Value / 1000, (float)this.npAngle.Value, this.speed, this.acceleration);
            else
                this.Drive.RunArcRight((float)this.npRadius.Value / 1000, (float)this.npAngle.Value, this.speed, this.acceleration);
        }
    }
}