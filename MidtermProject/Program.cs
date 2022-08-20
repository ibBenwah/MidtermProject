using MidtermProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Would you like to select a club or a member?");
// string userInput = Console.ReadLine();















// List<Club> clubInfo = new List<Club>();
// List<Member> memberInfo = new List<Member>();
// List<Member> singleMemberList = new List<Member>();
// List<Member> multiClubMembers = new List<Member>();
// List<Member> singleClubMembers = new List<Member>();


// clubInfo.Add(new Club(1, "Fitness", "Fitness"));
List<Member> memberList = new List<Member>();
Member member1 = new Member(123, "Garret", 1);
Member member2 = new Member(123, "Merck", 2);
Member member3 = new Member(123, "John", 3);
Member member4 = new Member(123, "Jane", 4);
FitnessHandler.AddMember(123, "Garret");
FitnessHandler.AddMember(123, "Merck");
FitnessHandler.AddMember(124, "Kevin");
FitnessHandler.AddMember(125, "John");
FitnessHandler.AddMember(126, "Jane");
FitnessHandler.AddMember(125, "Colin");
Console.WriteLine(member1.Name);
Console.WriteLine(member1.Id);
Console.WriteLine(member1.MembershipType);

Console.WriteLine(member2.Name);
Console.WriteLine(member2.Id);
Console.WriteLine(member2.MembershipType);




// FitnessHandler.AddMember(1234, "Bill Muarry");
// FitnessHandler.AddMember(1235, "John Muarry");
// FitnessHandler.AddMember(1236, "Colin Muarry");
// FitnessHandler.AddMember(1237, "Garret Muarry");






// // Club.DisplayClubInfo(member1.Club);



// FitnessHandler.MemberInfo(1234);

// Club.AddClubInfo(1, "Fitness", "Fitness");






