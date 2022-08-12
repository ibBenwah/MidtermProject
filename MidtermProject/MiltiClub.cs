using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    internal class MiltiClub : Members
    {
        public MiltiClub(int membershipPoints)
        {
            MembershipPoints = membershipPoints;
        }
    
        public int MembershipPoints { get; set; }
        
    }
}
