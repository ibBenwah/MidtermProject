using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Club : Members
    {
        public Club(int id, string name, string address) : base(id, address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        //possibly add club to these to seperate from members
        public string Name { get; set; }
        public string Address { get; set; }

        public static List<Club> GetClubList()
        {
        List<Club> clubLocations = new List<Club>();
            clubLocations.Add(new Club(1, "Grand Rapids", "123 Main"));
            clubLocations.Add(new Club(2, "Grand Banks", "1222 Copper"));

            return clubLocations;
        }
        

        
       

        //add multi memebers
        //public static void AddMultiMems(List<MultiClubMems> members, MultiClubMems member)

        
    }

}
