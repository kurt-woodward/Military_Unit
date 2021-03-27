using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class AmmoTruck : LandV
    {
        public override string VehicleDesignator { get { return "forklift"; } }
        public override string Movement
        {
            get { return "put-put-putting"; }
        }
    }
}
