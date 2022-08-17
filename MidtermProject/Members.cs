using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Members
    {
        public Members(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        //public abstract void CheckIn(); 

        public List<Members> newMembers = new List<Members>();
        public void AddMembers(int a, string b)
        {
            new Members(a, b);
        }


        //public void AddMembers(int a, string b, string c)
        //{
        //   new Members(a, b, c);
        //}



    }
}

