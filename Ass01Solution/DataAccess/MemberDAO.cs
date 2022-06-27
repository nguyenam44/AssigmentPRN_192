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
            new MemberObject{MemberID = 1, MemberName = "QuanNguyen", Email = "quannmse161529@fpt.edu.vn", City = "Ho Chi Minh", Country = "Viet Nam", Password = "QuanNM_0516"},
            new MemberObject{MemberID = 2, MemberName = "PhucLe", Email = "phuclnse161514@fpt.edu.vn", City = "Ho Chi Minh", Country = "Viet Nam", Password = "phuc123"},
            new MemberObject{MemberID = 3, MemberName = "HieuNguyen", Email = "hieunmse130445@fpt.edu.vn", City = "Ho Chi Minh", Country = "Viet Nam", Password = "hieu123"},
            new MemberObject{MemberID = 4, MemberName = "NamNguyen", Email = "namnvhse150925@fpt.edu.vn", City = "Ho Chi Minh", Country = "Viet Nam", Password = "nam123"},
            new MemberObject{MemberID = 5, MemberName = "NghiaLe", Email = "nghialhse150939@fpt.edu.vn", City = "Ho Chi Minh", Country = "Viet Nam", Password = "nghia123"}
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
                    if(instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //--------------------------------------------------------------------------------
        //Get Member list
        public List<MemberObject> GetMembers => MemberList;
        //--------------------------------------------------------------------------------
        //Get Member by ID
        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject member = MemberList.SingleOrDefault(pro => pro.MemberID == memberID);
            return member;
        }
        //--------------------------------------------------------------------------------
        //GetMember by Name
        public MemberObject GetMemberByName(String memberName)
        {
            MemberObject member = MemberList.SingleOrDefault(pro => pro.MemberName == memberName);
            return member;
        }
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
        //Delete a Member
        public void DeleteMember(int MemberID)
        {
            MemberObject mem = GetMemberByID(MemberID);
            if(mem != null)
            {
                MemberList.Remove(mem);
            }
            else
            {
                throw new Exception("Member does not exists!");
            }
        }
        

    }//MemberDAO class end 
}//DataAccess namespace end