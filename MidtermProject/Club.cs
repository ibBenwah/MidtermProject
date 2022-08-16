using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Club : Members
    {
        public Club(int id, string name, string address) : base(id, address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        //possibly add club to these to seperate from members
        public string Name { get; set; }
        public string Address { get; set; }

     
        
        public Dictionary<string, string> userMembers = new Dictionary<string, string>();
        public void AddMembers(string name, string address)
        {

            userMembers.Add(name, address);


          
        }
    }
}
