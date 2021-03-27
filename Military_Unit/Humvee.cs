using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Humvee : LandV
    {
        public override string VehicleDesignator { get { return "humvee"; } }
        public override string Movement
        {
            get { return "sputter-put-vrooming"; }
        }
    }
}
