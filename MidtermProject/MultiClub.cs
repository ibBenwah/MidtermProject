using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public class MultiClub : Member
  {
    public int MembershipPoints { get; set; }
    public MultiClub(int id, string name, int membershipPoints) : base(id, name, membershipPoints)
    {
      MembershipPoints = membershipPoints;
    }

    public MultiClub(int id, string name) : base(id, name, 0)
    {
      Id = id;
      Name = name;
      MembershipPoints = 0;
    }




    // public abstract void CheckIn(Club club)
    // 
    //   Console.WriteLine($"{Name} has checked in to {club.Name}");
    //   MembershipPoints++;
    //   MembershipPoints += 0;
    // }


  }
}

