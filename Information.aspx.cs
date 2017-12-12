using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Bll;
using Common;

namespace Shop
{
    public partial class Information : System.Web.UI.Page
    {
        SystemBll bll = new SystemBll();
        public string name = "昵称", phonenumber = "手机号", email = "电子邮件", regtime = "注册时间";

        protected void Update_ServerClick(object sender, EventArgs e)
        {
           
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["uname"]!=null)
                {
                    DataTable dt = bll.GetUserinfoByName(Session["uname"].ToString());
                    name = dt.Rows[0]["username"].ToString();
                    phonenumber= dt.Rows[0]["Phone"].ToString();
                    email= dt.Rows[0]["Email"].ToString();
                    regtime= dt.Rows[0]["RegDate"].ToString();
                }
            }
        }
    }
}