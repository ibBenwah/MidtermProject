using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public abstract class Members
    {
        public Members(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //public abstract void CheckIn(); 

        new List<Members> NewMember = new List<Members>();
        public List<Members> AddMembers()
        {
            NewMember.Add();
            return NewMember; 
        }
        //public List<Members> AddMembers(string name, string address, string membershipType)
        //{
        //    Console.WriteLine("Enter new Member Name");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Please enter address");
        //    address = Console.ReadLine();
        //    Console.WriteLine("Please enter Membership Type");
        //    membershipType = Console.ReadLine();
        //    var NewMember = new List<Members>();
        //    return NewMember;

        //}


    }

}
