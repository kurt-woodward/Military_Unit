using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class SevenTon : LandV
    {
        public override string VehicleDesignator { get { return "7 Ton"; } }
        public override string Movement
        {
            get { return "rumbling"; }
        }
    }
}
