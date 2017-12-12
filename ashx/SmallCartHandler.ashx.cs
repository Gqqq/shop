using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Common;
using Bll;
using System.Web.SessionState;

namespace Shop.ashx
{
    /// <summary>
    /// 小购物车
    /// </summary>
    public class SmallCartHandler : IHttpHandler, IRequiresSessionState
    {
        ProductBll bll = new ProductBll();
        ShoppingBll shopbll = new ShoppingBll();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["uname"] == null)
            {
                return;
            }
            var uname = context.Request["name"];

            var li = "";
            DataTable dt= shopbll.GetTopShopCart(uname);
            if (dt.Rows.Count>0)
            {
                foreach (DataRow shoprow in dt.Rows)
                {
                    var proprice = Convert.ToDouble(shoprow["Proprice"]);
                    var price = Convert.ToDouble(shoprow["Price"]);
                    var count = Convert.ToInt32(shoprow["Count"]);
                    string name = shoprow["Name"].ToString();
                    string Comname = string.Empty;
                    if (name.Length>10)
                    {
                        Comname = name.Substring(0, 4);
                        Comname += "...";
                        Comname += name.Substring(name.Length - 2);
                    }
                    else
                    {
                        Comname = name;
                    }
                    li += "<li>" +
                            "<div class='b-cart-table '>" +
                                $"<a href='Products.aspx?id={shoprow["Id"]}' class='image'>" +
                                    $"<img src='images/{shoprow["Picture"].ToString().Split(';')[0]}' style='width:70px' alt='/'>" +
                                "</a>" +
                                "<div class='caption'>" +
                                    $"<a class='product-name' href='Products.aspx?id={shoprow["Id"]}'>{Comname}</a>" +
                                    $"<span class='product-price'>{count}×￥{proprice}</span><br />" +
                                    $"<span class='product-price-old'>{count}×￥{price}</span>" +
                                "</div>" +
                                $"<button class='btn btn-remove' name='smallDelCart' data-id='{shoprow["Id"]}' data-uname='{uname}'><i class='fa fa-trash fa-lg'></i></button>" +
                            "</div>" +
                        "</li>";
                }
                context.Response.Write(li);
            }
            else
            {
                context.Response.Write("<li style='text-align:center;'>您的购物车都快饿死了 (>_<)</li>");
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