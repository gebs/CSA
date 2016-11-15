//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: RadarView.cs 828 2012-08-05 09:10:38Z zajost $
//------------------------------------------------------------------------------
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
    public partial class RadarView : UserControl
    {
        public event EventHandler TooClose;
        #region constructor & destructor
        public RadarView()
        {
            InitializeComponent();
        }
        #endregion


        #region properties
        /// <summary>
        /// Liefert bzw. setzt das Radar-Objekt
        /// </summary>
        public Radar Radar { get; set; }
        #endregion


        #region methods
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Radar != null)
            {
                this.label1.Text = "Distanz: " + Radar.Distance.ToString("0.00") + " m";
                int value = (int)(Radar.Distance * 100);
                if (value > 255) value = 255;
                if (value < 0) value = 0;

                if (value < 20)
                    TooClose?.Invoke(null, null);

                this.progressBar1.Value = value;
            }
        }
        #endregion
    }
}