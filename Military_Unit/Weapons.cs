using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public abstract class Weapons
    {
        public static Random weapRand = new Random();
        public static string WeaponSerial { get => GetSerial(); set => GetSerial(); }
        public abstract string Fire { get; set; }
        public static bool HasBeenFired { get; set; }
        public static bool Clean { get => Convert.ToBoolean(weapRand.Next(0, 2)); set { Clean = !Clean; } }

        //public static bool IsClean = Convert.ToBoolean(weapRand.Next(0, 1));
        //public static string isWeaponClean = "";

        public static string isClean()
        {
            string isWeaponClean = "";
            //Clean = Convert.ToBoolean(weapRand.Next(0, 2));
            if (Clean == true && HasBeenFired == false)
            {
                isWeaponClean = "clean";
            }
            else
            {
                isWeaponClean = "dirty";
            }
            return isWeaponClean;
        }


        public static string GetSerial()
        {
            string serial = Convert.ToString(Convert.ToChar(weapRand.Next(65, 91)));
            for (int i = 0; i < 5; i++)
            {
                serial += Convert.ToString(Convert.ToChar(weapRand.Next(48, 58)));
            }
            return serial;
        }


    }
}
