using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public abstract class Member
  {
        


        public int MemberID { get; set; }
        public string Name { get; set; }
        public int MembershipType { get; set; }

        public override string ToString()
        {
            return $"{MemberID} {Name} {MembershipType}" ;
        }

  
        public abstract void CheckIn();


  }
}


