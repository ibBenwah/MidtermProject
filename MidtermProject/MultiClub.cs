using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class MultiClub : Member
    {
        public MultiClub(int id, string name, int membershipPoints) : base(id, name)
        {
            MembershipPoints = membershipPoints;
        }

        public MultiClub(int id, string name) : base(id, name)
        {
        }

        public int MembershipPoints { get; set; }


        public override void CheckIn(Club club)
        {
            Console.WriteLine($"{Name} has checked in to {club.Name}");
            MembershipPoints ++; 
            MembershipPoints += 0;
        }

       
    }
}
