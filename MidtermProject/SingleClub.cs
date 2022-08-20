using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public class SingleClub : Member
  {
    public SingleClub(int id, string name, int membershipPoints) : base(id, name, membershipPoints)
    {
      // MembershipPoints = membershipPoints;
    }

    // public string MembershipType { get; set; }

    private Club location;

    public Club GetLocation()
    {
      return GetLocation(location);
    }

    // public override void CheckIn(Club club)
    // {
    //   if (Location == club)
    //   {
    //     Console.WriteLine($"{Name} has checked in to {club.Name}");
    //   }
    //   else
    //   {
    //     Console.WriteLine($"{Name} is not member of {club.Name}");
    //   }
    // }
    public Club GetLocation(Club location)
    {
      return location;
    }

    // public override void CheckIn(Club club)
    // {
    //   if (Location == club)
    //   {
    //     Console.WriteLine($"{Name} has checked in to {club.Name}");
    //   }
    //   else
    //   {
    //     Console.WriteLine($"{Name} is not member of {club.Name}");
    //   }
    // }
    public void SetLocation(Club value)
    {
      location = value;
    }

  }
}
