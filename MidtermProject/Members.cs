using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Member
    {
        public Member(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //public abstract void CheckIn(); 

        
       


        //public void AddMembers(int a, string b, string c)
        //{
        //   new Members(a, b, c);
        //}



    }
}

