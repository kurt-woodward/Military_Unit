using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    public abstract class Personnel
    {
        //public static bool IsComplete = false;
        //
        //public static string lastName = "";
        //public abstract string GetRank();
        //public abstract bool AnnualTraining();
        //
        public static Random rand = new Random();
        public bool IsComplete {get; set; }
        public static string LastName { get; set; }
        public abstract string GetRank { get; set; }
        public abstract bool AnnualTraining { get; set; }
        
        // Feeds into GetRank() in subclasses
        public static string[][] personRank = new string[][] {
            // List of officer ranks
            new string[]{
             "General",
             "Colonel",
             "Lt Colonel",
             "Major",
             "Captain",
             "First Lt",
             "Second Lt",
             "Cadet"
            },
            // List of enlisted ranks
            new string[]{
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
            } };
        public static string[] familyName =
        {
            // List of random last names
            "Starcks",
            "Wimsett",
            "Allmark",
            "Trew",
            "Brameld",
            "Gartell",
            "Marte",
            "Gheraldi",
            "Scurman",
            "Ellse",
            "Vickar",
            "Lowdeane",
            "Postgate",
            "Hestrop",
            "Ganing",
            "Firebrace",
            "Jane",
            "Tunnah",
            "Scollard",
            "Bamling",
            "Ancell",
            "Ayliff",
            "Fowell",
            "Geikie",
            "Dimbylow",
            "Westley",
            "Adams",
            "Leggate",
            "Berggren",
            "Durden",
            "Senten",
            "Gamblin",
            "McGragh",
            "Lamond",
            "Dewane",
            "Pinnington",
            "Diemer",
            "Hryskiewicz",
            "Hickenbottom",
            "Ruskin",
            "Mingasson",
            "Harvatt",
            "Peagram",
            "Biddwell",
            "Hazell",
            "Tamblyn",
            "McCard",
            "Trewin",
            "Kiezler",
            "Jacques"
        };

        static string[] stockPhrases =
        {
            "I love the smell of napalm in the morning.",
            "Now I want you to remember that no bastard ever won a war by dying for his country. He won it by making the other poor dumb bastard die for his country.",
            "I can no longer sit back and allow Communist infiltration, Communist indoctrination, Communist subversion and the international Communist conspiracy to sap and impurify all of our precious bodily fluids",
            "A brilliant man will find a way not to fight a war.",
            "At the next war let all the Kaisers, presidents and generals and diplomats go into a big field and fight it out first among themselves.",
            "Every man who wages war believes God is on his side. I’ll warrant God should often wonder who is on his.",
            "Are you not entertained?",
            "War is what happens when language fails."
        };


        public static string Speech()
        {
            string catchPhrase = stockPhrases[rand.Next(0, stockPhrases.Length - 1)];
            return catchPhrase;
        }

        public static string GetLastName()
        {
            return LastName = familyName[rand.Next(0, familyName.Length - 1)];
        }


    }
}
