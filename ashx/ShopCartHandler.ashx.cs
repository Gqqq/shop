using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using Bll;
using System.Web.SessionState;

namespace Shop
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class AddCartHandler : IHttpHandler, IRequiresSessionState
    {
        ShoppingBll bll = new ShoppingBll();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["uname"] == null)
            {
                return;
            }
            string action = context.Request["action"];
            switch (action)
            {
                case "Add":
                    AddCart(context);
                    break;
                case "Del":
                    DelCart(context);
                    break;
                case "Submit":
                    AddCart(context);
                    break;
                case "Clear":
                    ClearCart(context);
                    break;
                default:
                    ReturnAjax(context, msg: "未知操作");
                    break;
            }

        }

        private void ReturnAjax(HttpContext context, string msg)
        {
            context.Response.Write($"<script>window.alert('{msg}');</script>");
        }

        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="context"></param>
        public void AddCart(HttpContext context)
        {
            var pid = context.Request["id"];
            var uname = context.Request["uname"];
            var count = context.Request["count"];
            var color = context.Request["color"];

            if (bll.CheckPid(pid, uname))
            {
                if (bll.UpShopCount(pid, uname) == 1)
                    context.Response.Write("200");
                else
                    context.Response.Write("500");
            }
            else
            {
                string sql = $"insert into Shoppingcart (UserName,Pid,Count,Color) values('{uname}','{pid}','{count}','{color}')";
                if (SqlHelper.ExNonQuery(sql) == 1)
                {
                    context.Response.Write("200");
                }
                else
                    context.Response.Write("500");
            }
        }

        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="context"></param>
        public void DelCart(HttpContext context)
        {
            var pid = context.Request["id"];
            var uname = context.Request["uname"];

            if (bll.DelShopByPid(uname, pid) == 1)
                context.Response.Write("200");
            else
                context.Response.Write("500");
        }

        /// <summary>
        /// 清空购物车
        /// </summary>
        /// <param name="context"></param>
        public void ClearCart(HttpContext context)
        {
            var uname = context.Request["name"];
            if (bll.ClearShopCart(uname)>0)
                context.Response.Write("200");
            else
                context.Response.Write("500");
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