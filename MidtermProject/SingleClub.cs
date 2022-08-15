using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class SingleClub : Members
    {
        public SingleClub(string location)
        {
            
            Location = location;
        }

      
        public string Location { get; set; }


        public abstract void CheckIn();
        
    }
}
