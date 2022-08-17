using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
    public class FitnessHandler
    {


        List<MultiClub> multiClubMembers;
        List<SingleClub> singleClubMembers;
        public void AddMembersMulti(int id, string name)
        {
            multiClubMembers.Add(new MultiClub(id, name));
        }

        public void AddMembersSingle(int id, string name, Club club)
        {
            singleClubMembers.Add(new SingleClub(id, name, club));
        }

        public void RemoveMembers()
        {

        }

        public void MemberInfo()
        {

        }

    }
}
