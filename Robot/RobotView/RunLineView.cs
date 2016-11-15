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
    public partial class RunLineView : UserControl
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

        public RunLineView()
        {
            InitializeComponent();
            this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NumericKeyBoard nk = new NumericKeyBoard(Convert.ToDouble(this.npDistance.Value));
            nk.MaxValue = Convert.ToDouble(this.npDistance.Maximum);


            if (nk.ShowDialog() == DialogResult.OK)
            {
               this.npDistance.Value = (decimal)nk.FormValue;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Drive.RunLine((float)this.npDistance.Value / 1000, this.speed, this.acceleration);
        }
    }
}