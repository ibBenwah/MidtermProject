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



        //public static void AddMember(int a, string b)
        //{
        //    if (a == 2)
        //    {
        //        MultiMember temp = new MultiMember(a, b);
        //        multiClubMembers.Add(temp);
        //        allMembers.Add(temp);
        //         a += 1;
        //    }
        //    else
        //    {
        //        SingleMember temp2 = new SingleMember(a, b);
        //       // singleMemberList.Add(temp2);
        //        allMembers.Add(temp2);
        //        a++;
        //    }
        //}


   

        ////public static void MultiClubMember(int a, string b, int c)
        ////{
        ////    multiClubMembers.Add(new MultiClub(a, b));
        ////}

        ////public static void AddSingleClub(int a, string b)
        ////{
        ////    //singleMemberList.Add(SingleClub(a, b));
        ////}



        //public static void MemberInfo()
        //{
        //    foreach(Member m in allMembers)
        //    {
        //        Console.WriteLine($"{m.MemberID} {m.Name} {m.MembershipType}");
        //    }
        //}

        ////remove member based off ID
        //public static void RemoveMember(int id)
        //{
        //    Console.WriteLine("Enter the ID of the member you would like to remove: ");
        //    foreach (Member member in allMembers)
        //    {
        //        int idToRemove = int.Parse(Console.ReadLine());
        //        if (member.MemberID == idToRemove)
        //        {
        //            allMembers.Remove(member);
        //        }
        //    }
        //}
        ////List<MultiClub> multiClubMembers = new List<MultiClub>();
        ////List<SingleClub> singleClubMembers  = new List<SingleClub>();
        ////public void AddMembersMulti(int id, string name)
        ////{
        ////    multiClubMembers.Add(new MultiClub(id, name));
        ////}

        ////public void AddMembersSingle(int id, string name, Club club)
        ////{
        ////    singleClubMembers.Add(new SingleClub(id, name, club));
        ////}

        ////public  void RemoveMembers()
        ////{
        ////    int personIndex = multiClubMembers.FindIndex(x => x.Name.Contains(x.Name[x.Name.Length - 1]));
        ////}

        ////public void MemberInfo()
        ////{

        ////}


    }
}
