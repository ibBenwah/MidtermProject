using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class SingleMember : Member
    {
        //  Properties
        public SingleMember(string name, int id, int homeClub)
        {
            Name = name;
            HomeClub = homeClub;
            Id = id;
        }
        public int HomeClub { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public static List<SingleMember> singleMembers = new List<SingleMember>()

        {
            new SingleMember ("Collin", 1002, 1),
            new SingleMember ("Garret", 2004, 2),
            new SingleMember ("Kevin", 1003, 4)
        };



           
        
        public static List<Member> allMembers = new List<Member>();
        
        

        //  Methods
        public override void CheckIn()
        {
            Console.WriteLine("Welcome! what is your name? ");
            var name = Console.ReadLine().ToLower();
            List<SingleMember> checkSingleMembers = singleMembers.Where(x => x.Name.ToLower().Equals(name)).ToList();
            Console.WriteLine("Which location are you checking in at?");
            int userClubEntry = int.Parse(Console.ReadLine());
            if (userClubEntry == HomeClub)
            {
                if (checkSingleMembers.Count == 1)
                {
                    Console.WriteLine("Enjoy your workout!");
                }
                else if (checkSingleMembers.Count != 1)
                {
                    Console.WriteLine("Please try to check in again, if you are not a member please join!");
                }
            }
        }
     

       

        

        public static void MemberInfo()
        {
            int userinput = int.Parse(Console.ReadLine());
            singleMembers.ForEach(x => Console.WriteLine($"Name: {x.Name} \nMember ID: {x.Id} \nMembership Type: Single \nHomeLocation: {Club.clubList[userinput - 1].Address}"));
            MultiMember.multiMembers.ForEach(x => Console.WriteLine($"{x.Name} {x.Id} {x.MembershipPoints}"));

        }
    }
}
