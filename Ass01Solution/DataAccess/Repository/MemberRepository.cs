using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        //Add implement function here

        //implement DeleteMember function
        public void DeleteMember(int memberID)=> MemberDAO.Instance.RemoveMember(memberID);
        //-----------------------------------------------------------------------------------
        //implement InsertMember function
        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNewmember(member);
        //-----------------------------------------------------------------------------------g
        //implement UpdateMember function
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.UpdateMember(member);
        //-----------------------------------------------------------------------------------
    }
}
