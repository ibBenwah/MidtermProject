using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class MiltiClub : Members
    {
        public MiltiClub(int id, string name, int membershipPoints) : base(id, name)
        {
            MembershipPoints = membershipPoints;
        }

    public MiltiClub(int id, string name) : base(id, name)
    {
    }

    public int MembershipPoints { get; set; }
        

    }
}
