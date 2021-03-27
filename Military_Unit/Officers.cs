using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{

    class Officers : Personnel
    {
        public override bool AnnualTraining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Rank { get => oRank[Rand.Next(0, oRank.Length - 1)];}
        

        private string[] oRank = new string[]
        {
                // List of officer ranks
                 "General",
                 "Colonel",
                 "Lt Colonel",
                 "Major",
                 "Captain",
                 "First Lt",
                 "Second Lt",
                 "Cadet"
        };

        public Officers()
        {
            string name = LastName;
            string rank = Rank;
        }
    }




        //public override string GetRank()
        //{
        //    string rankName = personRank[0][rand.Next(0, personRank[0].Length - 1)];
        //    return rankName;
        //}

        //public override bool AnnualTraining()
        //{
        //    if (IsComplete == false)
        //    {
        //        IsComplete = true;
        //        Console.WriteLine("The officers quickly knock out their annual training.");
        //    }
        //    return IsComplete;
        //}
}

