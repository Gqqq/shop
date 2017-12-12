using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace Shop
{
    /// <summary>
    /// 登录
    /// </summary>
    public class RegHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var user = context.Request["user"];
            var pwd = context.Request["pwd"];
            var phone = context.Request["phone"];
            var email = context.Request["email"];

            string check = $"select count(*) from Users where username='{user}'";
            if (Convert.ToInt32( SqlHelper.ExScalar(check))!=0)
            {
                context.Response.Write("400");
                return;
            }
            string sql = $"insert into Users (username,password,Phone,Email,UserLevel) values('{user}','{pwd}','{phone}','{email}',1)";

            if (SqlHelper.ExNonQuery(sql)==1)
            {
                context.Response.Write("200");
            }
            else
            {
                context.Response.Write("500");
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