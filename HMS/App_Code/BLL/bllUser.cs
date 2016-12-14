using System;
using System.Data;
using HMS.DAL;

namespace HMS.BLL
{
    public class bllUser
    {

        dalUser objUser = new dalUser();

        public bllUser()
        {
        }

        public DataTable GetSystemUsers()
        {
            return objUser.GetSystemUsers();
        }

        public DataTable GetByUserName(string UserName)
        {
            return objUser.GetByUserName(UserName);
        }


        public int Insert(int UserID, string UserName, string FullName, string MobileNo)
        {
            return objUser.InsertUpdate(UserID, UserName, FullName, MobileNo);
        }

        public int Delete(string UserName)
        {
            return objUser.Delete(UserName);
        }
    }
}
