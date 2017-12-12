using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Bll;
using Common;
using System.Web.SessionState;

namespace Shop.ashx
{
    /// <summary>
    ///用户
    /// </summary>
    public class User : IHttpHandler, IRequiresSessionState
    {
        SystemBll bll = new SystemBll();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            if (context.Session["uname"] == null)
            {
                return;
            }

            var action = context.Request["action"];
            switch (action)
            {
                case "UpInfo":
                    UpInfo(context);
                    break;
                case "UpPwd":
                    Uppwd(context);
                    break;
                case "Del":
                    DelUser(context);
                    break;
                case "Enable":
                    EnUser(context);
                    break;
                default:
                    ReturnAjax(context, msg: "未知操作");
                    break;
            }

        }
        private void ReturnAjax(HttpContext context, string msg)
        {
            context.Response.Write(msg);
        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="context"></param>
        public void UpInfo(HttpContext context)
        {
            
            var yuan = context.Session["uname"].ToString();
            var username = context.Request["username"];
            var userphone = context.Request["userphone"];
            var useremail = context.Request["useremail"];

            var lname = context.Request["labname"];
            var lphone = context.Request["labphone"];
            var lemail = context.Request["labemail"];

            if (username == "")
            {
                username = lname;
            }
            if (userphone == "")
            {
                userphone = lphone;
            }
            if (useremail == "")
            {
                useremail = lemail;
            }
            //if (username=="" || userphone =="" || useremail =="")
            //{
            //    ReturnAjax(context, "不能为空");
            //    return;
            //}
            if (username == lname && userphone == lphone && useremail == lemail)
            {
                ReturnAjax(context, "未修改任何值");
            }
            else
            {
                try
                {
                    if (bll.UpdateByName(username, userphone, useremail, yuan) == 1)
                    {
                        if (yuan == username)
                        {
                            ReturnAjax(context, "修改成功");
                        }
                        else
                        {
                            ReturnAjax(context, "修改成功了");
                        }
                    }
                    else
                    {
                        ReturnAjax(context, "修改失败");
                    }
                }
                catch (Exception)
                {
                    ReturnAjax(context, "您的账户下有其他数据，不能直接修改用户名\n如要修改用户名请联系管理员");
                }
                
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="context"></param>
        public void Uppwd(HttpContext context)
        {
            var name = context.Session["uname"].ToString();
            var yuan= context.Request["yuanpass"];
            var newpwd= context.Request["newpass"];

            if (bll.UpDatePwd(name, yuan, newpwd) == 1)
            {
                ReturnAjax(context, "修改成功");
            }
            else
                ReturnAjax(context, "原密码不正确");
        }

        public void EnUser(HttpContext context)
        {
            string name = context.Request["id"].ToString();
            int enable;
            DataTable dt=  bll.GetUserinfoByName(name);
            if (Convert.ToBoolean( dt.Rows[0]["Enable"]))
            {
                enable = 0;
            }
            else
            {
                enable = 1;
            }
            string sql = $"update Users set Enable={enable} where username='{name}'";
            if (SqlHelper.ExNonQuery(sql)==1)
            {
                ReturnAjax(context, "修改成功");
            }
            else
            {
                ReturnAjax(context, "修改失败");
            }
        }

        public void DelUser(HttpContext context)
        {
            try
            {
                string name = context.Request["id"].ToString();
                if (name==context.Session["uname"].ToString())
                {
                    ReturnAjax(context, "超级管理员不能删除");
                    return;
                }
                if (bll.DelUser(name) == 1)
                {
                    ReturnAjax(context, "删除成功");
                }
                else
                    ReturnAjax(context, "删除失败");
            }
            catch (Exception)
            {
                ReturnAjax(context, "该用户下有其他数据，不能删除");
            }
           
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}