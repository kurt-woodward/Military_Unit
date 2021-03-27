using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Rifles : Weapons
    {
        public static string rifleSerial = "";
        public static string isRifleClean = "";

        public Rifles(string sn)
        {
            rifleSerial = sn;
            isRifleClean = Clean();
        }
        public override void Fire()
        {
            Console.WriteLine("Bang!");
        }
    }
}
