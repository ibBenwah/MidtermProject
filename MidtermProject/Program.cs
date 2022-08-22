using MidtermProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Console.WriteLine("Would you like to select a club or a member?");
// string userInput = Console.ReadLine();

SingleMember.CheckIn();
SingleMember.AddMember();
//SingleMember.MemberInfo();

bool continueprogram = true;

Console.WriteLine("Welcome to the Fitness Center!");
while(continueprogram = true)
{
    Console.WriteLine("Hello!  1:Join New Club 2:Check In 3:Add/Remove Members 4:Display Member Information 5: Pay Bills");
    int userSelection = int.Parse(Console.ReadLine());
    if (userSelection == 1)
    {
        //join club
    }
    else if (userSelection == 2)
    {
        //checkin
    }
    else if (userSelection == 3)
    {
        //add remove members based on another read line
    }
    else if (userSelection == 4)
    {
        //display member info
    }
    else if (userSelection == 5)
    {
        //pay bills
    }
    else { Console.WriteLine("Please enter a valid entry"); }
}




