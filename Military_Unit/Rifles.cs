using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Rifles : Weapons
    {
        public override string Fire { get => "Bang!"; set => HasBeenFired = true; }
        //public override string WeaponSerial { get => throw new NotImplementedException(); set => GetSerial(); }
        //public override bool Clean { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public static string rifleSerial = "";
        //private static bool Clean;

        public Rifles()
        {
            bool isRifleClean = Clean;
            string rifleSerial = WeaponSerial;
            HasBeenFired = false;
        }

        //private string GetSerial()
        //{
        //    string rifleSerial = "";
        //    rifleSerial = Convert.ToString(Convert.ToChar(weapRand.Next(65, 91)));
        //    for (int i = 0; i < 5; i++)
        //    {
        //        rifleSerial += Convert.ToString(Convert.ToChar(weapRand.Next(48, 58)));
        //    }
        //    return rifleSerial;
        //}

        //public override void Fire()
        //{
        //    Console.WriteLine("Bang!");
        //}
    }
}
