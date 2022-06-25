﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        void InsertMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int memberID);
    }
}