using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public abstract class Vehicles
    {
        

        public abstract string GroupDesignator { get; }
        public abstract string VehicleDesignator { get; }
        public abstract string Movement { get; }
        
    }
}
