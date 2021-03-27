using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Helicopter : AirV
    {
        public override string VehicleDesignator
        { get { return "CH-46"; } }

        public override string Movement => "buzzing";
    }
}
