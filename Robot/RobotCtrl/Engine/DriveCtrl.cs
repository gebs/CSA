//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: MotorCtrl.cs 973 2015-11-10 13:12:03Z zajost $
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RobotCtrl
{

    public class DriveCtrl : IDisposable
    {

        #region members
        private int ioAddress;
        #endregion


        #region constructor & destructor
        public DriveCtrl(int IOAddress)
        {
            this.ioAddress = IOAddress;
            Reset();
        }

        public void Dispose()
        {
            Reset();
        }
        #endregion


        #region properties
        /// <summary>
        /// Schaltet die Stromversorgung der beiden Motoren ein oder aus.
        /// </summary>
        public bool Power
        {
            set { DriveState = (value) ? DriveState | 0x03 : DriveState & ~0x03; }
        }


        /// <summary>
        /// Liefert den Status ob der rechte Motor ein-/ausgeschaltet ist bzw. schaltet den rechten Motor ein-/aus.
        /// Die Information dazu steht im Bit0 von DriveState.
        /// </summary>
        public bool PowerRight
        {
            get
            {
                int bitMask = 1 << 0;
                int result = DriveState & bitMask;
                if (result == bitMask) return true;
                else return false;

            } // ToDo
            set
            {
                if (value)
                {
                    DriveState = DriveState | (1 << 0);
                }
                else
                {
                    DriveState = DriveState & ~(1 << 0);
                }
            } 
        }


        /// <summary>
        /// Liefert den Status ob der linke Motor ein-/ausgeschaltet ist bzw. schaltet den linken Motor ein-/aus.
        /// </summary>
        public bool PowerLeft
        {
            get
            {
                int bitMask = 1 << 1;
                int result = DriveState & bitMask;
                if (result == bitMask) return true;
                else return false;

            } // ToDo
            set
            {
                if (value)
                {
                    DriveState = DriveState | (1 << 1);
                }
                else
                {
                    DriveState = DriveState & ~(1 << 1);
                }
            }
        }

        private int drivestate = 0;
        /// <summary>
        /// Bietet Zugriff auf das Status-/Controlregister
        /// </summary>
        public int DriveState
        {
            get { return drivestate = IOPort.Read(ioAddress); } 
            set
            {
                drivestate = value;
                IOPort.Write(ioAddress, drivestate);

            } 
        }
        #endregion


        #region methods
        /// <summary>
        /// Setzt die beiden Motorencontroller (LM629) zurück, 
        /// indem kurz die Reset-Leitung aktiviert wird.
        /// </summary>
        public void Reset()
        {
            //DriveState = 0x00;
            //Thread.Sleep(5);
            //DriveState = 0x80;
            //Thread.Sleep(5);
            //DriveState = 0x00;
            //Thread.Sleep(5);

            
            IOPort.Write(ioAddress, 0x00);
            Thread.Sleep(5);
            IOPort.Write(ioAddress, 0x80);           // Define Home
            Thread.Sleep(50);
            IOPort.Write(ioAddress, 0x00);
            Thread.Sleep(5);
                            //
        }
        #endregion

    }
}
