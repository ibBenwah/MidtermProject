using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class SingleClub : Members
    {
        public SingleClub(int clubIDNumber, string location)
        {
            ClubIDNumber = clubIDNumber;
            Location = location;
        }

        public int ClubIDNumber { get; set; }
        public string Location { get; set; }

    }
}
