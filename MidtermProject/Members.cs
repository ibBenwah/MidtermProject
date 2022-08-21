﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProject
{
  public abstract class Member
  {
    public Member(int id, string name, int membershipType)
    {
      Id = id;
      Name = name;
      MembershipType = membershipType;

    }
    public static List<Member> memberList = new List<Member>();

    public int Id { get; set; }
    public string Name { get; set; }
    public int MembershipType { get; set; }

    public override string ToString()
    {
      return $"{Id} {Name} {MembershipType}";
    }

  
        public abstract void CheckIn(Club club);


  }
}


