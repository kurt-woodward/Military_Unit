using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Harrier : AirV
    {
        public override string VehicleDesignator
        { get { return "harrier jet"; } }

        public override string Movement => "zooming";
    }
}
