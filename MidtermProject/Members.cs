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
      
     


    }

}
