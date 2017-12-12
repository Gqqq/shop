using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Common;

namespace Dal
{
    public class SystemDal
    {
        public object SelectUserInfo(string uname,string pwd)
        {
            string sql = $"select count(*) from Users where username='{uname}' and password='{pwd}'";
            return SqlHelper.ExScalar(sql);
        }

        public int InsertUser(string user,string pwd,string phone,string email)
        {
            string sql = $"insert into Users (username,password,Phone,Email,UserLevel) values('{user}','{pwd}','{phone}','{email}',1)";
            return SqlHelper.ExNonQuery(sql);
        }

        public object SelectUserLevel(string uname)
        {
            string  sql = $"select UserLevel from Users where username='{uname}'";
            return SqlHelper.ExScalar(sql);
        }

        public DataTable SelectUserinfoByName(string name)
        {
            string sql = $"select * from Users where username='{name}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public int UpdateUserInfo(string name,string phone,string email,string yuan)
        {
            string sql = $"update Users set username='{name}',Phone='{phone}',Email ='{email}' where username='{yuan}'";
            return SqlHelper.ExNonQuery(sql);
        }

        public int UpPwd(string name, string yuan, string newpwd)
        {
            string sql = $"update Users set password='{newpwd}' where username='{name}' and password='{yuan}'";
            return SqlHelper.ExNonQuery(sql);
        }

        public DataTable SelectAllWish(string name)
        {
            string sql = $"select * from UserWish a join Commodity b on a.Pid=b.Id join users c on a.UserName=c.username where c.username='{name}'";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public DataTable SelectAllUsers()
        {
            string sql = $"select * from Users";
            return SqlHelper.FillSet(sql).Tables[0];
        }

        public int DelUser(string uname)
        {
            string sql = $"delete Users where username='{uname}'";
            return SqlHelper.ExNonQuery(sql);
        }
        public DataTable SelectAllAssess()
        {
            string sql = "select * from Assess a join Users b on a.uname=b.username join Commodity c on a.comid=c.Id ";
            return SqlHelper.FillSet(sql).Tables[0];
        }
    }
}
