using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public static class FitnessHandler
  {
    public static List<SingleMember> singleMemberList = new List<SingleMember>();
    public static List<Member> allMembers = new List<Member>();
    public static List<MultiMember> multiClubMembers = new List<MultiMember>();


        //remove member based off ID
        public static void RemoveMember()
        {
            foreach (SingleMember s in singleMemberList)
            {
                
            }
            
            
            //Console.WriteLine("Enter the name of the member you would like to remove: ");
            //string userInput = Console.ReadLine();
            //var singleNameToRemove = singleMemberList.Single(x => x.Name.Equals(userInput));
            //singleMemberList.Remove(singleNameToRemove);
            //var doubleleNameToRemove = multiClubMembers.Single(x => x.Name == Console.ReadLine());
            //multiClubMembers.Remove(doubleleNameToRemove);


            //int singleIndex = singleMemberList.FindIndex(member => member.Name.ToLower(), singleMemberList.Remove(singleMemberList[nameToRemove]), );
            //int multiIndex = multiClubMembers.FindIndex(member => member.Name.ToLower() == nameToRemove);
            //if (singleNameToRemove is ())
            //{
            //    singleMemberList.RemoveAt();
            //}
            //if (multiIndex != -1)
            //{
            //    multiClubMembers.RemoveAt(multiIndex);
            //}
            //else Console.WriteLine("Error, invalid member");
        }

        public static void MemberInfo()
        {
            //what is user input doing?
            //int userinput = int.Parse(Console.ReadLine());
            SingleMember.singleMembers.ForEach(x => Console.WriteLine($"Name: {x.Name} \nMember ID: {x.Id} \nMembership Type: Single \nHomeLocation: {Club.clubList[x.HomeClub - 1].Address}"));
            MultiMember.multiMembers.ForEach(x => Console.WriteLine($"{x.Name} {x.Id} {x.MembershipPoints}"));

        }
        public static void AddMember()
        {
            Console.WriteLine("Please enter the following member information to register yourself as a member: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Membership type: (Single or MultiClub Membership? ");

            string membershipType = Console.ReadLine();

            bool isAddingMember = true;

            
            

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
                        new SingleMember(name, generateId, homeClub);

                        Console.WriteLine("to confirm your club number enter the club number one more time");
                        int clubChoice = int.Parse(Console.ReadLine());
                        homeClub = clubChoice;
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
    }
