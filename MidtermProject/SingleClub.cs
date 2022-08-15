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


<<<<<<< HEAD
        //public abstract void CheckIn()
=======
        public abstract void CheckIn();
>>>>>>> d05a12265ab6570b62d9df7b4a22a6151174226d
        
    }
}
