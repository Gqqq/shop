using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using Dal;

namespace Bll
{
    public class SystemBll
    {
        SystemDal dal = new SystemDal();

        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool CheckInfo(string uname,string pwd)
        {
            int i = Convert.ToInt32(dal.SelectUserInfo(uname, pwd));
            return i == 1;
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int AddUser(string user, string pwd, string phone, string email)
        {
            return dal.InsertUser(user,pwd,phone,email);
        }

        /// <summary>
        /// 获取用户等级
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetUserLevel(string name)
        {
            return Convert.ToInt32(dal.SelectUserLevel(name));
        }

        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable GetUserinfoByName(string name)
        {
            return dal.SelectUserinfoByName(name);
        }

        /// <summary>
        /// 根据用户名修改用户信息
        /// </summary>
        /// <param name="name">新昵称</param>
        /// <param name="phone">手机号</param>
        /// <param name="email">电子邮件</param>
        /// <param name="yuan">原昵称</param>
        /// <returns></returns>
        public int UpdateByName(string name, string phone, string email, string yuan)
        {
            return dal.UpdateUserInfo(name, phone, email, yuan);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="yuan">原密码</param>
        /// <param name="newpwd">新密码</param>
        /// <returns></returns>
        public int UpDatePwd(string name,string yuan,string newpwd)
        {
            return dal.UpPwd(name, yuan, newpwd);
        }

        /// <summary>
        /// 获取收藏
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable GetWishByName(string name)
        {
            return dal.SelectAllWish(name);
        }

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public DataTable AllUsers()
        {
            return dal.SelectAllUsers();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="uname"></param>
        /// <returns></returns>
        public int DelUser(string uname)
        {
            return dal.DelUser(uname);
        }

        /// <summary>
        /// 查询所有评价
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllAssess()
        {
            return dal.SelectAllAssess();
        }
    }
}
