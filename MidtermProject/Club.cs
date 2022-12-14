using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Club
    {
        public Club(int clubNumber, string name, string address)
        {
            Name = name;
            Address = address;
            ClubNumber = clubNumber;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int ClubNumber { get; set; }

        public static List<Club> clubInfo = new List<Club>() 
        {
          
            new Club(1, "Grand Rapids", "123 Main St, Grand Rapids, MI 49546"),
            new Club(2, "Seattle", "345 Bridge st, Seattle, WA 98544"),
            new Club(3, "Dothan", "456 Rucker Blvd, Dothan, AL 39330"),
            new Club(4, "Holland", "234 Hope St, Holland, MI 49345")

        };
        public static void AddClubInfo(int a, string b, string c)
        {
           
        }
        public static void DisplayClubInfo()
        {
            foreach (Club club in clubInfo)
            {
                Console.WriteLine($"{club.ClubNumber} {club.Name} {club.Address}");
            }
        }
    }
}




