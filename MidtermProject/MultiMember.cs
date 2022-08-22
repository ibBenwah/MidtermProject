using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public class MultiClub : Member
  {
        public MultiClub(int memberID, string name, int membershipType)
        {
            MemberID = memberID;
            Name = name;
            MembershipType = membershipType;
        }

        public MultiClub()
        {
            MemberID = 0;
            Name = " ";
            MembershipType = 1;
        }

        public MultiClub(int a, string b)
        {
        }

        public static List<MultiClub> multiClubMembers = new List<MultiClub>();
        public int MembershipPoints { get; set; }
        public int  MemberID { get; set; }
        public int MembershipType { get; set; }
        
        public override void CheckIn()
        {
            
        }




        public virtual void CheckIn(Club a)
        {
            foreach(var m in multiClubMembers) 
            { 
                if (MembershipType == 2)
                { 
                    Console.WriteLine($"{a.Name} has checked in to {a.Name}");
                    MembershipPoints++;
                    MembershipPoints += 0;
                }
            }
            
        }


    }
}

