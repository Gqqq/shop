using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bll;
using Common;
using System.Data;

namespace Shop
{
    public partial class HouAllOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] == null)
            {
                Response.Write("<script>window.location.href='index.aspx'</script>");
            }
            BindOrder();
        }
        public void BindOrder()
        {
            string sql = $"select a.*,b.username from orders a join users b on a.uid=b.username";
            DataTable dt = SqlHelper.FillSet(sql).Tables[0];
            string ordernum = "";
            foreach (DataRow Row in dt.Rows)
            {
                if (ordernum != Row["orderNum"].ToString())
                {
                    ordernum = Row["orderNum"].ToString();
                    string sql1 = $"select a.username,b.*,c.id,c.name,c.Picture,c.ProPrice from users a join orders b on a.username=b.uid join Commodity c on b.pid=c.id where b.orderNum='{ordernum}'";
                    DataTable dt1 = SqlHelper.FillSet(sql1).Tables[0];
                    int result = 0;
                    orders.InnerHtml += "<tr class='text-c va-m'>" +
                        "<td>" + $"{ordernum}" + "</td>" +
                        "<td>";

                    foreach (DataRow Row1 in dt1.Rows)
                    {
                        int a = Convert.ToInt32(Row1["num"]) * Convert.ToInt32(Row1["ProPrice"]);
                        result += a;
                        string pic = Row1["Picture"].ToString().Split(';')[0];
                        orders.InnerHtml +=
                            $"<a href='Products.aspx?id={Row1["id"]}' target='_blank'  style = 'text-decoration:none' >" +
                                $"<img class='product-thumb' src='images/{pic}' style='height:100px;'/>" +
                                "<span style = 'margin-left:5px'>" + "×" + $"{Row1["num"]}" + "</span>" +
                            "</a>";
                    }
                    orders.InnerHtml += "</td >" +
                        "<td class='text-l'>" +
                            "<a style = 'text-decoration:none'>" + $"{Row["username"]}" + "</a>" +
                        "</td>" +
                        "<td class='text-l'>" + $"{Row["orderTime"]}" + "</td>" +
                        "<td>" + "<span class='price'>" + $"{result}" + "</span>" + "</td>" +
                        "<td class='td-status'>" + "<span class='label label-success radius'>" + $"{Row["type"]}" + "</span>" + "</td>" +
                       "</td>" +
                    "</tr>";
                }
            }
        }
    }
}