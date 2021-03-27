using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Pistols : Weapons
    {
        public static string pistolSerial = "";
        public static string isPistolClean = "";
        public Pistols(string sn)
        {
            pistolSerial = sn;
            isPistolClean = Clean();
        }
        public override void Fire()
        {
            Console.WriteLine("Pop!");
        }
    }
}
