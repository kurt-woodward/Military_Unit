﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Officers : Personnel
    {
        public override string GetRank { get => personRank [0][rand.Next(0, personRank[0].Length - 1)]; set => throw new NotImplementedException(); }
        public override bool AnnualTraining { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Officers()
        {
            string rank = GetRank;
            string name = GetLastName();
            //Pistols officer_weapon = new Pistols();
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
}
