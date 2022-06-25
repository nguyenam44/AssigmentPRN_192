using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : MemberRepository
    {
        void InsertMember(MemberObject member)=>MemberDAO.Instance.AddNewmember(member);
        void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);
        void DeleteMember(int memberID)=> MemberDAO.Instance.RemoveMember(memberID);
    }
}
