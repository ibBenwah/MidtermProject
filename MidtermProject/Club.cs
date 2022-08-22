using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    internal class Club
    {
        //  Properties
        public Club(int clubNumber, string name, string address)
        {
            ClubNumber = clubNumber;
            Name = name;
            Address = address;
        }

        public Club(int id, string name)
        {
            Id = id;
            Name = name;

        }

        public int ClubNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

        public static List<Club> clubList = new List<Club>()
        {

            new Club(1, "Grand Rapids", "123 Main St, Grand Rapids, MI 49546"),
            new Club(2, "Seattle", "345 Bridge st, Seattle, WA 98544"),
            new Club(3, "Dothan", "456 Rucker Blvd, Dothan, AL 39330"),
            new Club(4, "Holland", "234 Hope St, Holland, MI 49345")

        };
        public static List<Club> allClubs = new List<Club>()
        {
            clubList[0],
            clubList[1],
            clubList[2],
            clubList[3]
        };
        public static List<Club> club1 = new List<Club>();
        public static List<Club> club2 = new List<Club>();
        public static List<Club> club3 = new List<Club>();
        public static List<Club> club4 = new List<Club>();


        //Methods 
        public static void DisplayClubInfo(Club clubFromList)
        {
            foreach (Club club in clubList)
            {
                Console.WriteLine($"{club.ClubNumber} {club.Name} {club.Address}");
            }
        }

        public static void DisplayClubInfo()
        {
            foreach (Club club in clubList)
            {
                Console.WriteLine($"{club.ClubNumber} {club.Name} {club.Address}");
            }
        }

        public static void ClubChoice(Club clubChoice)
        {

            Console.WriteLine();
            Console.WriteLine($"{clubChoice.ClubNumber} {clubChoice.Name} {clubChoice.Address}");
        }

        //public static void AddToClub()
        //{
        //    club1 = club1.Add(SingleMember;
        //}
    }
}




