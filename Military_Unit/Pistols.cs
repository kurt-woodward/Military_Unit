using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Pistols : Weapons
    {
        public override string Fire { get => "Pop!"; set => HasBeenFired = true; }
        //public override string WeaponSerial { get => GetSerial(); }
        //public override bool Clean { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public static string pistolSerial = "";
        //public static string isPistolClean = "";
        public Pistols()
        {
            string pistolSerial = WeaponSerial;
            bool isPistolClean = Clean;
            HasBeenFired = false;
        }
        //private string GetSerial()
        //{
        //    string pistolSerial = "";
        //    pistolSerial = Convert.ToString(Convert.ToChar(weapRand.Next(65, 91)));
        //    for (int i = 0; i < 5; i++)
        //    {
        //        pistolSerial += Convert.ToString(Convert.ToChar(weapRand.Next(48, 58)));
        //    }
        //    return pistolSerial;
        //}

        //public override void Fire()
        //{
        //    Console.WriteLine("Pop!");
        //}
    }
}
