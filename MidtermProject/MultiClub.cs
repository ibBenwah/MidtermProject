using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public class MultiClub : Member
  {
        public MultiClub(int memberID, string name, int membershipType)
        {
            MemberID = memberID;
            Name = name;
            MembershipType = membershipType;
        }

        public int MembershipPoints { get; set; }
        public int  MemberID { get; set; }
        public int MembershipType { get; set; }
        
        public override void CheckIn()
        {
            
        }




        public virtual void CheckIn(Club club)
        {
            Console.WriteLine($"{Name} has checked in to {club.Name}");
            MembershipPoints++;
            MembershipPoints += 0;
        }


    }
}

