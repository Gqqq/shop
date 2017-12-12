using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using System.Web.SessionState;

namespace Shop.ashx
{
    /// <summary>
    /// 我的收藏
    /// </summary>
    public class WishHandler : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["uname"] == null)
            {
                return;
            }
            var pid = context.Request["id"];
            var uname = context.Request["uname"];
            var color = context.Request["color"];
            string selectsql = $"select count(*) from UserWish where Pid='{pid}' and UserName='{uname}'";
            if (Convert.ToInt32( SqlHelper.ExScalar(selectsql))!=0)//返回值为true表示已收藏
            {
                context.Response.Write("300");
                return;
            }
            else
            {
                string sql = $"insert into UserWish (UserName,Pid,Color) values('{uname}','{pid}','{color}')";
                if (SqlHelper.ExNonQuery(sql) == 1)
                {
                    context.Response.Write("200");
                }
                else
                {
                    context.Response.Write("500");
                }
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