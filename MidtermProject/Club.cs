using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class Club : Members
    {
        public Club(int id, string name, string address) : base (id, address)
        {
            Name = name;
            Address = address;
        }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}
