﻿using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IMemberRepository
    {
        List<Member> GetMembers();

        Member GetById(int id);

        void AddMember(Member member);

        void UpdateMember(int id, Member member);

        void DeleteMember(int id);
    }
}
