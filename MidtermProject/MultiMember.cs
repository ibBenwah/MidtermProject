using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class MultiMember : Member
    {
        public MultiMember(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public int MembershipPoints { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<MultiMember> multiMembers = new List<MultiMember>();



        //  Methods
        public override void CheckIn()
        {
            Console.WriteLine("Welcome! what is your name? ");
            var name = Console.ReadLine().ToLower();
            List<MultiMember> checkMultiMembers = multiMembers.Where(x => x.Name.ToLower().Equals(name)).ToList();
            if (checkMultiMembers.Count == 1)
            {
                Console.WriteLine("Enjoy your workout!");
            }
            else if (checkMultiMembers.Count != 1)
            {
                Console.WriteLine("Please try to check in again, if you are not a member please join!");
            }



        }

    }
}


