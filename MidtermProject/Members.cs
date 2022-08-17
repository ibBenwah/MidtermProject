using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public abstract class Members
    {
        public Members(int id, string name, string membershipType)
        {
            Id = id;
            Name = name;
            MembershipType = membershipType;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string MembershipType { get; set; }

        //public abstract void CheckIn(); 






    }

}
