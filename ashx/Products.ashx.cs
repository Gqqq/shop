using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using Bll;
using System.Data;

namespace Shop.ashx
{
    /// <summary>
    /// Products 的摘要说明
    /// </summary>
    public class Products : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            ProductBll bll = new ProductBll();
            context.Response.ContentType = "text/plain";
            var pid = Convert.ToInt32(context.Request["id"]);
            if (bll.DelComm(pid)==1)
            {
                context.Response.Write("删除成功");
            }
            else
            {
                context.Response.Write("删除失败");
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