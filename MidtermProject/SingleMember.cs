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
        public SingleMember(string name, int id)
        {
            Name = name;
            //HomeClub = homeClub;
            Id = id;
        }
        public int HomeClub { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public static List<SingleMember> singleMembers = new List<SingleMember>();
        public static List<Member> allMembers = new List<Member>();

        //public List<Club> clubList = new List<Club>();

        //  Methods
        public override void CheckIn()
        {
            Console.WriteLine("Welcome! what is your ID number? ");
            string id = Console.ReadLine();
            if (id.ElementAt(id[]))
            {

            }
        }


        public static void AddMember()
        {
            Console.WriteLine("Please enter the following member information to register yourself as a member: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Membership type: (Single or MultiClub Membership? ");

            string membershipType = Console.ReadLine();

            bool isAddingMember = true;

            while (isAddingMember)
            {

                if (membershipType == "Single")
                {
                    Console.WriteLine("Here are our list of gyms. Which one would you like to join? ");
                    Club.DisplayClubInfo();

                    Console.WriteLine("Which Gym would you like to join? ");
                    int homeClub = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{name}, you selected: ");
                    Club.ClubChoice(Club.clubList[homeClub - 1]);

                    Console.WriteLine();
                    Console.WriteLine("is this Correct? (yes or no) ");
                    if (Console.ReadLine() == "yes")
                    {
                        int generateId = 10000000;
                        generateId += 1;
                        singleMembers.Add(new SingleMember(name, generateId));

                        Console.WriteLine("to confirm your club number enter the club number one more time");
                        MemberInfo();
                        Console.WriteLine();
                    }
                }
                else if (membershipType.ToLower() == "MultiClub")
                {
                    int generatedId = 2000000;
                    generatedId += 1;
                    MultiMember.multiMembers.Add(new MultiMember(name, generatedId));
                }
                else
                {
                    Console.WriteLine("Please enter a valid membership type");
                }

            }

        }



        public static void MemberInfo()
        {
            int userinput = int.Parse(Console.ReadLine());
            singleMembers.ForEach(x => Console.WriteLine($"Name: {x.Name} \nMember ID: {x.Id} \nMembership Type: Single \nHomeLocation: {Club.clubList[userinput - 1].Address}"));
           //MultiMember.multiMembers.ForEach(x => Console.WriteLine($"{x.Name} {x.ID} {x.MembershipPoints}"));

        }
    }
}
