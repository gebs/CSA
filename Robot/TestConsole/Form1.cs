using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestConsole
{
    public partial class Form1 : Form
    {
        RobotConsole rc;
        public Form1()
        {
            InitializeComponent();
            rc = new RobotConsole();
            console.Console = rc;

            rc[Switches.Switch1].SwitchStateChanged += (s, e) => { rc[Leds.Led1].LedEnabled = rc[Switches.Switch1].SwitchEnabled; };
            rc[Switches.Switch2].SwitchStateChanged += (s, e) => { rc[Leds.Led2].LedEnabled = rc[Switches.Switch2].SwitchEnabled; };
            rc[Switches.Switch3].SwitchStateChanged += (s, e) => { rc[Leds.Led3].LedEnabled = rc[Switches.Switch3].SwitchEnabled; };
            rc[Switches.Switch4].SwitchStateChanged += (s, e) => { rc[Leds.Led4].LedEnabled = rc[Switches.Switch4].SwitchEnabled; };

        }


    }
}
