using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Bll;

namespace Shop
{
    public partial class Main : System.Web.UI.MasterPage
    {
        ProductBll bll = new ProductBll();
        SystemBll sysbll = new SystemBll();
        ShoppingBll shopbll = new ShoppingBll();

        public string login,goout,con,usersinfo,UserShopingCart,smallCart;

        public string put = "style='pointer-events: none;'";
        protected void Page_Load(object sender, EventArgs e)
        {
            usersinfo = "账户";
            
            if (!IsPostBack)
            {
                if (Session["uname"]!= null)
                {
                    put = "";
                    usersinfo = Session["uname"].ToString();
                    int level= sysbll.GetUserLevel(usersinfo);
                    if (level==0)
                    {
                        con = "<li><a href='Information.aspx'><i class='fa fa-user'></i>用户中心</a></li>" +
                            "<li><a href='ShoppingCart.aspx'><i class='fa fa-shopping-cart'></i>购物车</a></li>" +
                            "<li><a href = 'HouIndex.aspx'><i class='fa fa-gear'></i>控制台</a></li>" +
                            "<li><a href='MyWish.aspx'><i class='fa fa-heart'></i>我的收藏</a></li>" +
                            "<li><a href='Logout.aspx'><i class='fa fa-remove'></i>退出登录</a></li>";
                    }
                    else
                    {
                        con = "<li><a href='Information.aspx'><i class='fa fa-user'></i>用户中心</a></li>" +
                            "<li><a href='ShoppingCart.aspx'><i class='fa fa-shopping-cart'></i>购物车</a></li>" +
                            "<li><a href='MyWish.aspx'><i class='fa fa-heart'></i>我的收藏</a></li>" +
                            "<li><a href='Logout.aspx'><i class='fa fa-remove'></i>退出登录</a></li>";
                    }
                    
                }
                else
                {
                    login = "<li><a href='Log.aspx'><i class='fa fa-unlock'></i>登录</a></li>";
                }
                DataTable dt = bll.GetAllBrand();
                foreach (DataRow row in dt.Rows)
                {
                    BrandList.InnerHtml += "<li>" +
                                                $"<a class='heading-line' href='BrandList.aspx?brand={row["Alias"]}'>{row["BName"]}</a>" +
                                            "</li>";
                }
                smallCart = $"<div id='cart-wrapper' class='col-xs-6 col-sm-12 col-md-2 col-lg-2'{put}>" +
                                $"<div class='b-cart pull-right' id='minCart'  data-name='{usersinfo}' >" +
                                    "<button id='cart' class='btn btn-default-color1 btn-sm'>" +
                                        "<span class='price'><i class='fa fa-shopping-bag'></i> 购物车</span>" +
                                    "</button>" +
                                    "<div class='cart-products'>" +
                                        "<div class='c-holder'>" +
                                            "<h3 class='title'>购物车</h3>" +
                                            "<ul class='products-list list-unstyled' id='smallCart'>" +
                                            "</ul>" +
                                            "<div class='products-buttons text-center' style='margin-top:15px'>" +
                                                $"<a href='#' class='btn btn-default-color1 btn-sm ClearCart' data-name='{usersinfo}' style='margin-right:10px'>清空购物车</a>" +
                                                "<a href='ShoppingCart.aspx'  class='btn btn-primary-color2 btn-sm'>查看购物车</a>" +
                                            "</div>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                            "</div>";
            }
        }

    }
}