using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using Bll;
using System.Data;
using System.Web.SessionState;

namespace Shop.ashx
{
    /// <summary>
    /// 收货地址
    /// </summary>
    public class AddressHandler : IHttpHandler, IRequiresSessionState
    {
        AddressBll bll = new AddressBll();
        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["uname"] == null)
            {
                return;
            }
           
            context.Response.ContentType = "text/plain";
            var action = context.Request["action"];
            switch (action)
            {
                case "del":
                    DelAddress(context);
                    break;
                case "update":
                    UpdateAddress(context);
                    break;
            }
            
        }


        public void DelAddress(HttpContext context)
        {
            var uname =context.Request["name"];
            var id = Convert.ToInt32(context.Request["id"]);

            if (bll.DelAddress(id, uname)==1)
            {
                context.Response.Write("200");
            }
            else
            {
                context.Response.Write("500");
            }

        }

        public void UpdateAddress(HttpContext context)
        {
            var uid  =context.Request["name"];
            var id = Convert.ToInt32(context.Request["id"]);
            if (uid==null)
            {
                return;
            }
            var type = 0;
            bll.UpdateType();
            if (bll.UpdateAddress(type,uid,id)==1)
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