﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        //Add implement function here
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList;
        //implement DeleteMember function
        public void DeleteMember(int memberID)=> MemberDAO.Instance.RemoveMember(memberID);
        //-----------------------------------------------------------------------------------
        //implement InsertMember function
        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNewMember(member);
        //-----------------------------------------------------------------------------------g
        //implement UpdateMember function
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);
        //-----------------------------------------------------------------------------------
        //SearchMember By ID and Name
        public MemberObject GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);
        public MemberObject GetMemberByName(String memberName) => MemberDAO.Instance.GetMemberByName(memberName);

        public List<MemberObject> GetMemberByCityAndCountry(string country, string city)=>MemberDAO.Instance.GetMemberByCityAndCountry(country, city);

    }
}
