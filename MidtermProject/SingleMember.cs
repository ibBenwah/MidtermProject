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

        public SingleClub()
        {
            MemberID = 0;
            Name = "";
            MembershipType = 0;
        }

        public SingleClub(int a, string b)
        {
        }

        public int MemberID { get; set; }
        public int MembershipType { get; set; }
        public int HomeMembershipID { get; set; }
        public static List<SingleClub> singleMemberList = new List<SingleClub>();





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
            foreach(var m in singleMemberList)
            {
                //if(Club. 0)
                //{

                //}
            }

        }
    }
}
