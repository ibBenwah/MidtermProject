using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class SingleClub : Member
    {
        
        public SingleClub(int memberID, string name, int membershipType)
        {
            MemberID = memberID;
            Name = name;
            MembershipType = membershipType;
        }
        
        public int MemberID { get; set; }
        public int MembershipType { get; set; }
        public int HomeMembershipID { get; set; }
       
        




        //public override void CheckIn(Club club)
        //{
        //    if ( == club)
        //    {
        //        Console.WriteLine($"{Name} has checked in to {club.Name}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{Name} is not member of {club.Name}");
        //    }
        //}

        public Club GetLocation(Club location)
        {
            return location;
        }

        // public override void CheckIn(Club club)
        // {
        //   if (Location == club)
        //   {
        //     Console.WriteLine($"{Name} has checked in to {club.Name}");
        //   }
        //   else
        //   {
        //     Console.WriteLine($"{Name} is not member of {club.Name}");
        //   }
        // }
        
        public override void CheckIn()
        {

        }
    }
}
