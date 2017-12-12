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
    public partial class Address : System.Web.UI.Page
    {
        AddressBll bll = new AddressBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            BindAddress();
        }

        public void BindAddress()
        {
            if (Session["uname"]==null)
            {
                Response.Redirect("Log.aspx");
            }
            string name = Session["uname"].ToString();
            DataTable dt = bll.GetAddByName(name);
            foreach (DataRow row in dt.Rows)
            {
                string aa = "";
                if (Convert.ToInt32(row["type"]) == 0)
                {
                    aa = "defaultAddr";
                }
                GetAddress.InnerHtml += $"<li class='user-addresslist {aa}'>" +
                                             $"<a class='new-option-r' style='color:white;text-decoration:none' name='Moren' data-name='{name}' data-id='{row["id"]}'>" + "默认地址" + "</a>" +
                                             "<p class='new-tit new-p-re'>" +
                                                 "<span class='new-txt'>" + $"{row["name"]}" + "</span>" +
                                                 "<span class='new-txt-rd2'>" + $"{row["tel"]}" + "</span>" +
                                             "</p>" +
                                             "<div class='new-mu_l2a new-p-re'>" +
                                                 "<p class='new-mu_l2cw'>" +
                                                     "<span class='title'>" + "地址：" + "</span>" +
                                                     "<span class='province'>" + $"{row["province"]}" + "</span>" +
                                                     "<span class='city'>" + $"{row["city"]}" + "</span>" +
                                                     "<span class='dist'>" + $"{row["county"]}" + "</span>" +
                                                     "<span class='street'>" + $"{row["details"]}" + "</span>" + "</p>" +
                                             "</div>" +
                                             "<div class='new-addr-btn'>" +
                                                 "<span class='new-addr-bar'>" + "</span>" +
                                                 $"<a href = 'javascript:void(0);'name='delAddress' data-name='{name}' data-id={row["id"]}>" + "<i class='am-icon-trash'>" + "</i>" + "删除" + "</a>" +
                                             "</div>" +
                                         "</li>";
            }
        }

        protected void Add_ServerClick(object sender, EventArgs e)
        {
            string name = username.Value;
            string tel = userphone.Value;
            string pro = province.Value;
            string cit = city.Value;
            string cou = county.Value;
            string detail = details.Value;
            string uname = Session["uname"].ToString();
            int type = 1;
            if (bll.AddAddress(pro, cit, cou, detail, name, uname, type, tel) == 1)
            {
                Response.Redirect("Address.aspx");
            }
            else
            {
                Response.Write("<script>alert('添加失败')</Script>");
                return;
            }
        }
    }
}