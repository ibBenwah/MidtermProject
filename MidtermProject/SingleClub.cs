using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public class SingleClub : Member
  {
    public SingleClub(int id, string name, Club location)
    {

      Location = location;
      //   MembershipType = membershipType;

    }

    public override void CheckIn(Club club)
    {
      if (Location == club)
      {
        Console.WriteLine($"{Name} has checked in to {club.Name}");
      }
      else
      {
        Console.WriteLine($"{Name} is not member of {club.Name}");
      }




    }





    public Club Location { get; set; }
    //public string MembershipType { get; set; }
  }
}
