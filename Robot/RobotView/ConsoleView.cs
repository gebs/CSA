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
    public partial class ConsoleView : UserControl
    {
        private RobotCtrl.RobotConsole console;

        public ConsoleView()
        {
            InitializeComponent();
        }

        public RobotConsole Console
        {
            get
            {
                return console;
            }

            set
            {
                console = value;
                if (console != null)
                {
                    this.ledview1.Led = console[Leds.Led1];
                    this.ledview2.Led = console[Leds.Led2];
                    this.ledview3.Led = console[Leds.Led3];
                    this.ledview4.Led = console[Leds.Led4];

                    this.switchview1.Myswitch = console[Switches.Switch1];
                    this.switchview2.Myswitch = console[Switches.Switch2];
                    this.switchview3.Myswitch = console[Switches.Switch3];
                    this.switchview4.Myswitch = console[Switches.Switch4];
                }

            }
        }

    }
}