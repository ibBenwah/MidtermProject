using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public static class FitnessHandler
  {
    public static List<SingleClub> singleMemberList = new List<SingleClub>();
    public static List<Member> memberList = new List<Member>();
    public static List<MultiClub> multiClubMembers = new List<MultiClub>();



        public static void AddMember(int a, string b, int c)
        {
            if (c == 1)
            {
                MultiClub temp = new MultiClub(a, b, c);
                multiClubMembers.Add(temp);
                memberList.Add(temp);
                 ;
            }
            else
            {
                SingleClub temp2 = new SingleClub(a, b, c);
                singleMemberList.Add(temp2);
                memberList.Add(temp2);
                a++;
            }
        }


   

        //public static void MultiClubMember(int a, string b, int c)
        //{
        //    multiClubMembers.Add(new MultiClub(a, b));
        //}

        //public static void AddSingleClub(int a, string b)
        //{
        //    //singleMemberList.Add(SingleClub(a, b));
        //}



        public static void MemberInfo()
        {
            foreach(Member m in memberList)
            {
                Console.WriteLine($"{m.MemberID} {m.Name} {m.MembershipType}");
            }
        }

        //remove member based off ID
        public static void RemoveMember(int id)
        {
            Console.WriteLine("Enter the ID of the member you would like to remove: ");
            foreach (Member member in memberList)
            {
                int idToRemove = int.Parse(Console.ReadLine());
                if (member.MemberID == idToRemove)
                {
                    memberList.Remove(member);
                }
            }
        }
        //List<MultiClub> multiClubMembers = new List<MultiClub>();
        //List<SingleClub> singleClubMembers  = new List<SingleClub>();
        //public void AddMembersMulti(int id, string name)
        //{
        //    multiClubMembers.Add(new MultiClub(id, name));
        //}

        //public void AddMembersSingle(int id, string name, Club club)
        //{
        //    singleClubMembers.Add(new SingleClub(id, name, club));
        //}

        //public  void RemoveMembers()
        //{
        //    int personIndex = multiClubMembers.FindIndex(x => x.Name.Contains(x.Name[x.Name.Length - 1]));
        //}

        //public void MemberInfo()
        //{

        //}


    }
}
