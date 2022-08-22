using MidtermProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

foreach (var member in SingleMember.singleMembers)
{
    Console.WriteLine($"{member.Name} {member.Id} {member.HomeClub}");
}


//SingleMember.CheckIn();
//SingleMember.AddMember();
//SingleMember.MemberInfo();

bool continueprogram = true;

Console.WriteLine("Welcome to the Fitness Center!");
while (continueprogram = true)
{
    Console.WriteLine("Hello!  1:Join New Club 2:Check In 3:Add/Remove Members 4:Display Member Information 5: Pay Bills");
    int userSelection = int.Parse(Console.ReadLine());
    if (userSelection == 1)
    {
        FitnessHandler.AddMember();


    }
    else if (userSelection == 2)
    {
        //CheckIn()
    }
    else if (userSelection == 3)
{
    FitnessHandler.RemoveMember();
}
    else if (userSelection == 4)
    {
        SingleMember.MemberInfo();
    }
    else if (userSelection == 5)
    {
        //pay bills
    }
    else { Console.WriteLine("Please enter a valid entry"); }
}






