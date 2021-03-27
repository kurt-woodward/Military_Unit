using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Troops : Personnel
    {
        //public static string troopName = GetLastName();

        public override string GetRank()
        {
            string rankName = personRank[1][rand.Next(0, personRank[1].Length - 1)];
            return rankName;
        }

        public override bool AnnualTraining()
        {
            if (IsComplete == false)
            {
                IsComplete = true;
                Console.WriteLine("The troops quickly knock out their annual training.");
            }
            else
            {
                IsComplete = false;
                Console.WriteLine("The First Sergeant waits until Friday at 1700 to announce the next batch of annual training.");
            }    

            return IsComplete;
        }
    }
    
}
