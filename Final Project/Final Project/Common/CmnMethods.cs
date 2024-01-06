using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.Common
{
    public static class CmnMethods
    {
        public static void ResetGlobal()
        {
            Global.UserInfo = new Models.UserInfo();
        }
        public static SqlConnection OpenConnectionString(SqlConnection sqlCon)
        {
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            sqlCon.Open();
            return sqlCon;
        }
        public static void GetUserInfo(DataTable dt)
        {
            Global.UserInfo = (from rw in dt.AsEnumerable()
                               select new UserInfo()
                               {
                                   UsertId = Convert.ToInt32(rw["UserId"]),
                                   Username = Convert.ToString(rw["Username"]),
                                   Contact = Convert.ToString(rw["Contact"]),
                                   UserPassWord = Convert.ToString(rw["UserPassword"])
                               }).ToList().FirstOrDefault();

        }
    }
}
