using MidtermProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//SingleMember.CheckIn();
//SingleMember.AddMember();
//SingleMember.MemberInfo();

bool continueprogram = true;

//Console.WriteLine("Welcome to the Fitness Center! what would you like to do? ");

while (continueprogram = true)
{
    Console.WriteLine("Hello! Welcome to the Fitness Center! what would you like to do? \n1:Join New Club \n2:Check In \n3:Add/Remove Members \n4:Display Member Information \n5: Pay Bills");
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






