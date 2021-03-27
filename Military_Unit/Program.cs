using System;

namespace Military_Unit
{
    class Program
    {
        //
        //  Kurt Woodward
        //  ISTA 322 EX 7A
        //  Military Unit (Implementing Inheritance)
        //

        static void Main(string[] args)
        {
            string[] pistolInventory;
            string[] rifleInventory;
            string[] mk19Inventory;

            Console.WriteLine("Military Unit!\n");

            //A couple of instances of inheritance in action:
            Officers OpsO = new Officers();
            Osprey C7V6 = new Osprey();
            HowManyToMake(1, "pistols");
            Console.WriteLine($"{C7V6.GroupDesignator} Commander {OpsO.GetRank()} {Officers.GetLastName()} {C7V6.Movement} in their {C7V6.VehicleDesignator} says:\n\"{Officers.Speech()}\" Their pistol serial number is {Pistols.pistolSerial}. Their pistol is {Pistols.isPistolClean}.");

            Console.WriteLine();
            Troops NCOIC = new Troops();
            HowManyToMake(1, "rifles");
            Humvee H24838 = new Humvee();
            Console.WriteLine($"{H24838.GroupDesignator} NCOIC {NCOIC.GetRank()} {Troops.GetLastName()} says:\n\"{Troops.Speech()}\" as they go {H24838.Movement} around in their {H24838.VehicleDesignator}. Their rifle's serial number is {Rifles.rifleSerial}. Their rifle is {Rifles.isRifleClean}.");

            //A super complicated way of generating instances of each type of weapon given the number and type of weapon to make. 
            string[] HowManyToMake(int numToMake, string weaponToMake)
            {
                pistolInventory = new string[numToMake];
                rifleInventory = new string[numToMake];
                mk19Inventory = new string[numToMake];
                string[] temp = new string[0];

                for (int i = 0; i < numToMake; i++)
                {
                    string sn = Weapons.GetSerial();
                    if (weaponToMake.ToLower() == "pistols")
                    {
                        new Pistols(sn);
                        pistolInventory[i] = Pistols.WeaponSerial;
                        return pistolInventory;

                    }
                    else if (weaponToMake.ToLower() == "rifles")
                    {
                        new Rifles(sn);
                        rifleInventory[i] = Rifles.WeaponSerial;
                        return rifleInventory;

                    }
                    else if (weaponToMake.ToLower() == "mk19s")
                    {
                        new MK19s(sn);
                        mk19Inventory[i] = MK19s.WeaponSerial;
                        return mk19Inventory;

                    }
                }
                return temp;
            }
            //// Caravan Lead Vic
            //Humvee H27538 = new Humvee();
            //Troops VicCommander = new Troops();
            //Rifles R445 = new Rifles();
            //Troops A_Team = new Troops();
            //Rifles R492 = new Rifles();
            //Troops Ready = new Troops();
            //Rifles R175 = new Rifles();
            //Troops Fire = new Troops();
            //MK19s G777 = new MK19s();

            //// Caravan Ammo Vic
            //AmmoTruck A63971 = new AmmoTruck();
            //Troops TruckDriver = new Troops();
            //Rifles R802 = new Rifles();
            //Troops A_TruckDriver = new Troops();
            //Rifles R327 = new Rifles();

            //// Caravan 7 Ton w/ Personnel
            //SevenTon S34297 = new SevenTon();
            //Troops SevDriver = new Troops();
            //Rifles R918 = new Rifles();
            //Troops A_SevDriver = new Troops();
            //Rifles R357 = new Rifles();









        }
    }
}
