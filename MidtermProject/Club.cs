using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Club
    {
        public Club(int id, string name, string address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }

        public static List<Club> clubInfo = new List<Club>();
        
       
        void AddClubInfo(int a, string b, string c)
        {
            Club.clubInfo.Add(new Club(12345, "Grand Rapids", "123 Main St, Grand Rapids, MI 49546"));
            Club.clubInfo.Add(new Club(54321, "Seattle", "345 Bridge st, Seattle, WA 98544"));
            Club.clubInfo.Add(new Club(95951, "Dothan", "456 Rucker Blvd, Dothan, AL 39330"));
            Club.clubInfo.Add(new Club(95951, "Holland", "234 Hope St, Holland, MI 49345"));
          
            
            public void ClubInfo(string a, string b)
            {
                foreach (var club in clubInfo)
                {
                    Console.WriteLine($"{club.Id} {club.Name} {club.Address}");
                }
            }
        }
    }
}




