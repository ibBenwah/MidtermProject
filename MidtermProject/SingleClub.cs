using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class SingleClub : Members
    {
        public SingleClub(int id, string name, string location, string membershipType) : base(id, name)
        {
            
            Location = location;
            MembershipType = membershipType;
        }




        public string Location { get; set; }
        public string MembershipType { get; set; }



        //public abstract void CheckIn();

        
    }
}
