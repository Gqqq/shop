using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using System.Data;
using Common;

namespace Shop
{
    public partial class Logo : System.Web.UI.Page
    {
        SystemBll bll = new SystemBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btn1_ServerClick(object sender, EventArgs e)
        {
            try
            {
                string name = uname.Value;
                string password = pass.Value;
                if (bll.CheckInfo(name, password))
                {
                    Session["uname"] = name;
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    JsHelper.Alert("账户或密码不正确，请重新输入");
                }
            }
            catch (Exception ex)
            {
                JsHelper.Alert(ex.Message); 
            }
            
           
        }
    }
}