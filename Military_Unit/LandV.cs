using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class LandV : Vehicles
    {
        public override string GroupDesignator
        { get { return "Caravan"; } }
        public override string VehicleDesignator { get { return "Default Land Vehicle Designator"; } }
        public override string Movement
        {
            get { return "Default Driving Sound"; }
        }
    }
}
