using BusinessObject;
using System;
using System.Collections;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {

        //Init Members list
        private static List<MemberObject> MemberList = new List<MemberObject>
        {
            //Add code here
        };
        //--------------------------------------------------------------------------------
        // SingletonPattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    instance = new MemberDAO();
                }
                return instance;
            }
        }
        //--------------------------------------------------------------------------------
        //Get Member list

        //--------------------------------------------------------------------------------
        //Get Member by ID
        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject member = null;
            // Add code here
            return member;
        }
        //--------------------------------------------------------------------------------
        //Get Member by Name

        //--------------------------------------------------------------------------------
        //Get Member by City or County

        //--------------------------------------------------------------------------------
        //Creat a new Member
        public void AddNewmember(MemberObject member)
        {
            MemberObject obj = GetMemberByID(member.MemberID);
            if (obj == null)
            {
                MemberList.Add(member);
            }
            else
            {
                throw new Exception("Member already exsitsed!");
            }
        }
        //--------------------------------------------------------------------------------
        //Remove a Member
        public void RemoveMember(int MemberID)
        {
            MemberObject obj = GetMemberByID(MemberID);
            if(obj != null)
            {
                MemberList.Remove(obj);
            }
            else
            {
                throw new Exception("Member does not exsits!");
            }
        }
        //--------------------------------------------------------------------------------
        //Update a Member
        public void UpdateMember(MemberObject member)
        {
            MemberObject obj = GetMemberByID(member.MemberID);
            if (obj != null)
            {
                var index = MemberList.IndexOf(obj);
                MemberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not exsits!");
            }
        }
        //--------------------------------------------------------------------------------


    }//MemberDAO class end 
}//DataAccess namespace end