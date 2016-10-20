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
    public partial class LedView : UserControl
    {
        private bool state;
        private RobotCtrl.Led led;
        public LedView()
        {
            InitializeComponent();
            pictureBox1.Image = Resource.LedOff;
        }

        public bool State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                pictureBox1.Image = (value ? Resource.LedOn : Resource.LedOff);

            }
        }

        public Led Led
        {
            get
            {
                return led;
            }

            set
            {
                led = value;
                if (led != null)
                    led.LedStateChanged += Led_LedStateChanged;
            }
        }

        private void Led_LedStateChanged(object sender, LedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<LedEventArgs>(Led_LedStateChanged), sender, e);
            }
            else { State = e.LedEnabled; }
        }
    }
}