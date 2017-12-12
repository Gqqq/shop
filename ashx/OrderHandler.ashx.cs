using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bll;

namespace Shop.ashx
{
    /// <summary>
    /// OrderHandler 的摘要说明
    /// </summary>
    public class OrderHandler : IHttpHandler
    {
        OrderBll bll = new OrderBll();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string action = context.Request["action"];
            switch (action)
            {
                case "Update":
                    UpdateOrder(context);
                    break;
                case "Del":
                    DelOrder(context);
                    break;
                default:
                    break;
            }

            
        }

        /// <summary>
        /// 修改订单状态
        /// </summary>
        /// <param name="context"></param>
        public void UpdateOrder(HttpContext context)
        {
            var uid = context.Request["uid"];
            var ordernum = context.Request["onum"].ToString();
            var type = context.Request["type"].ToString();
            if (bll.UpdateOrder(uid, ordernum, type) > 0)
            {
                context.Response.Write("200");
            }
            else
            {
                context.Response.Write("500");
            }
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="context"></param>
        public void DelOrder(HttpContext context)
        {
            var uid = context.Request["uid"];
            var onum = context.Request["onum"].ToString();
            string sql = $"select type from orders where uid='{uid}' and orderNum='{onum}'";
            if (SqlHelper.ExScalar(sql).ToString()!="已完成")
            {
                context.Response.Write("100");
                return;
            }
            if (bll.DeleteOrder(uid, onum) > 0)
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