using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        // Add InsertMember to interface
        void InsertMember(MemberObject member);
        //--------------------------------------
        // Add UpdateMember to interface
        void UpdateMember(MemberObject member);
        //--------------------------------------
        // Add DeleteMember to interface
        void DeleteMember(int memberID);
        //--------------------------------------
        //Search Member By ID and Name
        MemberObject GetMemberByID(int memberID);
        MemberObject GetMemberByName(string memberName);
        List<MemberObject> GetMemberByCityAndCountry(string country,string city);

    }
}
