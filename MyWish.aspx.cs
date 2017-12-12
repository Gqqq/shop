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
    public partial class MyWish : System.Web.UI.Page
    {
        SystemBll bll = new SystemBll();
        public string WishList= "<div style='text-align:center'>您还没有收藏商品</div>";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"]==null)
            {
                Response.Redirect("index.aspx");
            }
            DataTable dt = bll.GetWishByName(Session["uname"].ToString());
            if (dt.Rows.Count>0)
            {
                WishList = "";
            }
            foreach (DataRow row in dt.Rows)
            {
                string pic = row["Picture"].ToString().Split(';')[0];
                WishList += "<div class='col-lg-4 col-md-4 col-sm-4 col-xs-6'>" +
                                "<div class='b-item-card'>" +
                                    $"<div class='image' style='width:259px; height:313px; overflow: hidden; text-align:center;'>" +
                                        $"<a href='images/{pic}' data-gal='prettyPhoto' title='{row["Name"]}' >" +
                                            $"<img src='images/{pic}' class='img-responsive center-block' alt='{row["Name"]}'  >" +
                                            "<div class='image-add-mod'>" +
                                                "<span class='btn btn-lightbox btn-default-color1 btn-sm'>" +
                                                    "<i class='fa fa-search-plus fa-lg'></i>"+
                                                "</span>" +
                                            "</div>" +
                                        "</a>" +
                                    "</div>" +
                                    "<div class='card-info'>" +
                                        "<div class='caption'>" +
                                            "<div class='name-item'>" +
                                                $"<a class='product-name' href='Products.aspx?id={row["Pid"]}'>{row["Name"]}</a>" +
                                                "<div class='rating'>" +
                                                    "<span class='star'><i class='fa fa-star'></i></span>" +
                                                    "<span class='star'><i class='fa fa-star'></i></span>" +
                                                    "<span class='star'><i class='fa fa-star'></i></span>" +
                                                    "<span class='star'><i class='fa fa-star'></i></span>" +
                                                    "<span class='star star-empty'><i class='fa fa-star-o'></i></span>" +
                                                    "<div class='add-review'>" +
                                                        "<span>库存:</span>" +
                                                        $"<a href='#'>{row["Repertory"]}</a>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                            "<div class='card-price-block'>" +
                                                "<span class='price-title'>价格</span>" +
                                                $"<span class='product-price'>￥{row["ProPrice"]}</span>" +
                                            "</div>" +
                                        "</div>" +
                                         "<div class='product-description'>" +
                                            $"<p style='text-indent:2em'>{row["detail"]}</p>" +
                                        "</div>" +
                                        "<div class='add-buttons'>" +
                                            //"<button type='button' class='btn btn-add btn-add-compare'><i class='fa fa-refresh'></i></button>" +
                                            //$"<button type='button' class='btn btn-add btn-add-wishAddWish' data-id='{row["Id"]}' data-uname='{Session["uname"]}' data-color='1'><i class='fa fa-heart-o'></i></button>" +
                                            "<button type='button' class='btn btn-add btn-add-cart'><i class='fa fa-shopping-cart'></i></button>" +
                                            "<div class='cart-add-buttons'>" +
                                                $"<button type='button' class='btn btn-cart-color1' name='AddCart' data-id='{row["Id"]}' data-uname='{Session["uname"]}' data-count='1' data-color='1'><i class='fa fa-shopping-cart'></i>添加到购物车</button>" +
                                            "</div>" +
                                        "</div>" +
                                    "</div>" +
                                "</div>" +
                            "</div>";
            }
        }
            
    }
}