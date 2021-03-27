using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class MK19s : Weapons
    {
        //public static string mk19Serial = "";
        //public static bool isMk19Clean;
        public override string Fire { get => "FIRE IN THE HOLE!\nKABOOOM!"; set => HasBeenFired = true; }
        //public override string WeaponSerial { get => throw new NotImplementedException(); set => GetSerial(); }
        //public override bool Clean { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MK19s()
        {
            string mK19Serial = WeaponSerial;
            bool isMk19Clean = Clean;
            HasBeenFired = false;
        }

        //private string GetSerial()
        //{
        //    string MK19Serial = "";
        //    MK19Serial = Convert.ToString(Convert.ToChar(weapRand.Next(65, 91)));
        //    for (int i = 0; i < 5; i++)
        //    {
        //        MK19Serial += Convert.ToString(Convert.ToChar(weapRand.Next(48, 58)));
        //    }
        //    return MK19Serial;
        //}
        //public override void Fire()
        //{
        //    Console.WriteLine("FIRE IN THE HOLE!\nKABOOOM!");
        //}
    }
}
