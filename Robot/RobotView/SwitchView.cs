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
    public partial class SwitchView : UserControl
    {
        private bool state;
        private RobotCtrl.Switch myswitch;
        public SwitchView()
        {
            InitializeComponent();
            pictureBox1.Image = Resource.SwitchOff;
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

                pictureBox1.Image = (value ? Resource.SwitchOn : Resource.SwitchOff);
            }
        }

        public Switch Myswitch
        {
            get
            {
                return myswitch;
            }

            set
            {
                myswitch = value;
                if (myswitch != null)
                myswitch.SwitchStateChanged += Myswitch_SwitchStateChanged;
            }
        }

        private void Myswitch_SwitchStateChanged(object sender, SwitchEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(Myswitch_SwitchStateChanged),
                    sender, e);
            }
            else State = e.SwitchEnabled;
        }
    }
}