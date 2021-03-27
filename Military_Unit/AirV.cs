using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class AirV : Vehicles
    {
        public override string GroupDesignator 
        { get { return "Air Wing"; } }
        public override string VehicleDesignator 
        { get; }
        public override string Movement
        { get; }
    }
}
