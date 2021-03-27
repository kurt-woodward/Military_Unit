using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Osprey : AirV
    {
        public override string VehicleDesignator
        { get { return "osprey"; } }

        public override string Movement => "thwip-thwip-thwiping";
    }
}
