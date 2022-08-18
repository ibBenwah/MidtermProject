using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class SingleClub : Member
    {
        public SingleClub(int id, string name, Club location) : base(id, name)
        {

            Location = location;
            //MembershipType = membershipType;

        }




        public Club Location { get; set; }
        //public string MembershipType { get; set; }
    }
}
