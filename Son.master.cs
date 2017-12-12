using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;

namespace Shop
{
    public partial class Son : System.Web.UI.MasterPage
    {
        public string Url="当前页面";
        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.LocalPath;
            string minurl= url.Substring(url.LastIndexOf('/')+1);
            switch (minurl)
            {
                case "Information.aspx":
                    Url = "个人信息";
                    break;
                case "UserCenter.aspx":
                    Url = "用户中心";
                    break;
                case "Address.aspx":
                    Url = "收货地址";
                    break;
                case "ChangePwd.aspx":
                    Url = "修改密码";
                    break;
                case "BackOrder.aspx":
                    Url = "订单管理";
                    break;
                case "comment.aspx":
                    Url = "评价";
                    break;
            }
        }
    }
}