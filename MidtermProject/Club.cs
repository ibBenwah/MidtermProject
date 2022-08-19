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
            Id = id;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }

        public static List<Club> clubInfo = new List<Club>() 
        {
          
            new Club(12345, "Grand Rapids", "123 Main St, Grand Rapids, MI 49546"),
            new Club(54321, "Seattle", "345 Bridge st, Seattle, WA 98544"),
            new Club(95951, "Dothan", "456 Rucker Blvd, Dothan, AL 39330"),
            new Club(95951, "Holland", "234 Hope St, Holland, MI 49345")

        };
        
        
       
        public static void AddClubInfo(int a, string b, string c)
        {
            List<Club> clubInfo = new List<Club>();
            clubInfo.Add(new Club(12345, "Grand Rapids", "123 Main St, Grand Rapids, MI 49546"));
            clubInfo.Add(new Club(54321, "Seattle", "345 Bridge st, Seattle, WA 98544"));
            clubInfo.Add(new Club(95951, "Dothan", "456 Rucker Blvd, Dothan, AL 39330"));
            clubInfo.Add(new Club(95951, "Holland", "234 Hope St, Holland, MI 49345"));
          
            
            
        }
        public static void DisplayClubInfo()
        {
            foreach (Club club in clubInfo)
            {
                Console.WriteLine($"{club.Id} {club.Name} {club.Address}");
            }
        }
    }
}




