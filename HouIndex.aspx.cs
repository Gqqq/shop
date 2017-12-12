using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;

namespace Shop
{
    public partial class HouIndex : System.Web.UI.Page
    {
        SystemBll sysbll = new SystemBll();
        public string usersinfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] == null)
            {
                Response.Write("<script>location.href='Index.aspx';</script>");
                return;
            }
            else
            {
                string username = Session["uname"].ToString();
                if (sysbll.GetUserLevel(username) == 0)
                    usersinfo = username;
                else
                    Response.Write("<script>window.alert('您的权限不足，不能访问该页面');location.href='Index.aspx';</script>");
            }
            
        }
    }
}