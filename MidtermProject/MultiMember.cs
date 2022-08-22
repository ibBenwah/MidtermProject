using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class MultiMember : Member
    {
        public MultiMember(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public int MembershipPoints { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<MultiMember> multiMembers = new List<MultiMember>();



        //  Methods
        public override void CheckIn()
        {

        }

        

    }

}


