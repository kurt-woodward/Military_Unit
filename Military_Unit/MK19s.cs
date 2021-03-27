using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class MK19s : Weapons
    {
        public static string mk19Serial = "";
        public static string isMk19Clean = "";
        public MK19s(string sn)
        {
            mk19Serial = sn;
            isMk19Clean = Clean();
        }
        public override void Fire()
        {
            Console.WriteLine("FIRE IN THE HOLE!\nKABOOOM!");
        }
    }
}
