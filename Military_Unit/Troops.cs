using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Troops : Personnel
    {
        public override string Rank { get => eRank[Rand.Next(0, eRank.Length - 1)]; }
        public override bool AnnualTraining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private static string[] eRank = new string[] 
        {
            // List of enlisted ranks
             "Sergeant Major",
             "Master Gunnery Sergeant",
             "First Sergeant",
             "Master Sergeant",
             "Gunnery Sergeant",
             "Staff Sergeant",
             "Sergeant",
             "Corporal",
             "Lance Corporal",
             "Private First Class",
             "Private",
             "Recruit"
        };

        public Troops()
        {
            string name = LastName;
            string rank = Rank;
        }
        //public static string troopName = GetLastName();

        //public override string GetRank()
        //{
        //    string rankName = personRank[1][rand.Next(0, personRank[1].Length - 1)];
        //    return rankName;
        //}

        //public override bool AnnualTraining()
        //{
        //    if (IsComplete == false)
        //    {
        //        IsComplete = true;
        //        Console.WriteLine("The troops quickly knock out their annual training.");
        //    }
        //    else
        //    {
        //        IsComplete = false;
        //        Console.WriteLine("The First Sergeant waits until Friday at 1700 to announce the next batch of annual training.");
        //    }    

        //    return IsComplete;
        //}
    }
    
}
