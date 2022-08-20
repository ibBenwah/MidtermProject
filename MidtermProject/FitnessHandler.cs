using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public static class FitnessHandler
  {
    public static List<Member> singleMemberList = new List<Member>();
    public static List<Member> memberList = new List<Member>();
    public static List<Member> multiClubMembers = new List<Member>();
    public static List<Member> singleClubMembers = new List<Member>();


    public static void AddMember(int a, string b)
    {

      //   memberList.Add(new Member(a, b));
    }

    public static void MultiClubMember(int membershipPoints)
    {
      // multiClubMembers.Add()
    }


    public static void MemberInfo(int a)
    {
      foreach (Member member in memberList)
      {
        Console.WriteLine($"{member.Id} {member.Name}");
      }
    }

    //remove member based off ID
    public static void RemoveMember(int id)
    {
      Console.WriteLine("Enter the ID of the member you would like to remove: ");
      foreach (Member member in memberList)
      {
        int idToRemove = int.Parse(Console.ReadLine());
        if (member.Id == idToRemove)
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

    //public static void AddMembers(int a, string b)
    //{
    //    new Members(a, b);
    //}
  }
}
