using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public abstract class Weapons
    {
        public static string WeaponSerial { get; set; }
        public abstract void Fire();

        //public static bool IsClean = Convert.ToBoolean(weapRand.Next(0, 1));
        //public static string isWeaponClean = "";

        public static string Clean()
        {
            string isWeaponClean = "";
            bool IsClean = Convert.ToBoolean(weapRand.Next(0, 2));
            if (IsClean == true)
            {
                isWeaponClean = "clean";
            }
            else
            {
                isWeaponClean = "dirty";
            }
            return isWeaponClean;
        }

        public static Random weapRand = new Random();

        public static string GetSerial()
        {
            WeaponSerial = Convert.ToString(Convert.ToChar(weapRand.Next(65, 91)));
            for (int i = 0; i < 5; i++)
            {
                WeaponSerial += Convert.ToString(Convert.ToChar(weapRand.Next(48, 58)));
            }
            return WeaponSerial;
        }


    }
}
