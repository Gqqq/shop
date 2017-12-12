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
    public partial class index : System.Web.UI.Page
    {
        ProductBll probll = new ProductBll();
        ShoppingBll shopbll = new ShoppingBll();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (!IsPostBack)
            {
                DataTable newdt = probll.NewTopComm();//新品推荐
                foreach (DataRow row in newdt.Rows)
                {
                    string pic = row["Picture"].ToString().Split(';')[0];
                    ListProduct.InnerHtml += "<div class='col-xs-6 col-sm-6 col-md-4 col-lg-4'>" +
                                                    "<div class='related-item wow fadeInUp'>" +
                                                        "<div class='b-item-card'>" +
                                                        $"<div class='special-plank {GetColum(row)}'>" +
                                                            $"<span>{GetColum(row)}</span>" +
                                                         "</div>" +
                                                            "<div class='image'>" +
                                                                $"<a href='Products.aspx?id={row["Id"]}'>" +
                                                                    $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{pic}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" +
                                                                "</a>" +
                                                                "<div class='image-add-mod'>" +
                                                                    "<div class='add-description'>" +
                                                                        "<div>" +
                                                                            $"<span>{row["Introduce"]}</span>" +
                                                                              "<br>" +
                                                                              //"<button class='btn btn-default-color1 btn-sm' type='button' style='margin-right:5px'>" + "<i class='fa fa-refresh fa-lg'>" + "</i>" + "</button>" +
                                                                              $"<a href='images/{pic}' data-gal='prettyPhoto' title='{row["Name"]}' class='btn btn-lightbox btn-default-color1 btn-sm'>" +
                                                                                  "<i class='fa fa-search-plus fa-lg'>" + "</i>" +
                                                                              "</a>" +
                                                                          "</div>" +
                                                                      "</div>" +
                                                                  "</div>" +
                                                              "</div>" +
                                                              "<div class='card-info'>" +
                                                                  "<div class='caption'>" +
                                                                      "<p class='name-item'>" +
                                                                          $"<a class='product-name' href='Products.aspx?id={row["Id"]}'>{row["Name"]}</a>" +
                                                                        "</p>" +
                                                                        $"<span class='product-price'>￥{row["ProPrice"]}</span>" +
                                                                        $"<span class='product-price-old'>￥{row["Price"]}</span>" +
                                                                     "</div>" +
                                                                     "<div class='add-buttons'>" +
                                                                        $"<button type='button' class='btn btn-add btn-add-wish AddWish' data-id='{row["Id"]}' data-uname='{Session["uname"]}' data-color='1' style='margin-right:5px'><i class='fa fa-heart-o'></i></button>" +
                                                                        $"<button type='button' class='btn btn-add btn-add-cart' name='AddCart' data-id='{row["Id"]}' data-uname='{Session["uname"]}' data-count='1' data-color='1'><i class='fa fa-shopping-cart'></i></button>" + 
                                                                    "</div>" +
                                                                 "</div>" +
                                                             "</div>" +
                                                         "</div>" +
                                                     "</div>";
                }

                DateTime time = DateTime.Now;//获取当前系统时间
                int day= Convert.ToInt32(time.Day);//天
                string year = time.Year.ToString();//年
                string month = time.Month.ToString();//月

                DataTable besthotdt = probll.BestHotComm();//最热
                foreach (DataRow besthotrow in besthotdt.Rows)
                {
                    HotProduct.InnerHtml = "<div class='b-hot-deal wow fadeInRight'>" +
                                            "<div class='special-plank top'>" +
                                                $"<span>top</span>" +
                                            "</div>" +
                                            "<div class='hot-deal-card'>" +
                                                "<h3 class='heading-line'>BEST</h3>" +
                                                "<div class='image'>" +
                                                    $"<a href = 'Products.aspx?id={besthotrow["Id"]}' >" +
                                                         $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{besthotrow["Picture"].ToString().Split(';')[0]}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" +
                                                    "</a>" +
                                                "</div>" +
                                                $"<div class='countdown' data-end-date='{month} {day}, {year} 23:59:59' data-theme='custom' data-title-days='天' data-title-hours='时' data-title-minutes='分' data-title-seconds='秒' ></div>" +
                                                "<div class='card-info'>" +
                                                    "<div class='caption'>" +
                                                        "<div class='name-item'>" +
                                                            $"<a class='product-name' href='Products.aspx?id={besthotrow["Id"]}'>{besthotrow["Name"]}</a>" +
                                                            "<div class='rating'>" +
                                                                "<span class='star'><i class='fa fa-star'></i></span>" +
                                                                "<span class='star'><i class='fa fa-star'></i></span>" +
                                                                "<span class='star'><i class='fa fa-star'></i></span>" +
                                                                "<span class='star'><i class='fa fa-star'></i></span>" +
                                                                "<span class='star star-empty'><i class='fa fa-star-o'></i></span>" +
                                                            "</div>" +
                                                        "</div>" +
                                                        "<div class='deal-prices clearfix'>" +
                                                            "<div class='deal pull-left'>" +
                                                                "<span>促销价</span>" +
                                                                "<br>" +
                                                                $"<span class='product-price'>￥{besthotrow["ProPrice"]}</span>" +
                                                            "</div>" +
                                                            "<div class='regular pull-right'>" +
                                                                "<span>原价</span>" +
                                                                "<br>" +
                                                                $"<span class='product-price-old'>￥{besthotrow["Price"]}</span>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</div>" +
                                                    "<div class='cart-add-buttons'>" +
                                                        $"<button id = 'add-cart1' type='button' class='btn btn-add-cart-full' name='AddCart' data-id='{besthotrow["Id"]}' data-uname='{Session["uname"]}' data-count='1' data-color='1'><span><i class='fa fa-shopping-cart'></i></span>添加到购物车</button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>";
                }

                DataTable branddt = probll.Brand();//品牌
                foreach (DataRow brand in branddt.Rows)
                {
                    Brand.InnerHtml += "<li>" +
                                            $"<button data-filter = '.{brand["Alias"]}' class='btn btn-tag'>{brand["BName"]}</button>" +
                                        "</li>";
                    count++;
                }

                DataTable brandcommdt = probll.BrandComm(count*8);//品牌产品
                foreach (DataRow brandcomm in brandcommdt.Rows)
                {
                        BrandComm.InnerHtml += $"<div class='{brandcomm["Brand"]} related-item col-xs-6 col-sm-6 col-md-3 col-lg-3'>" +
                                        "<div class='b-item-card'>" +
                                            $"<div class='special-plank {GetColum(brandcomm)}'>" +
                                                $"<span>{GetColum(brandcomm)}</span>" +
                                            "</div>" +
                                            "<div class='image'>" +
                                                $"<a href = 'Products.aspx?id={brandcomm["Id"]}' >" +
                                                    $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{brandcomm["Picture"].ToString().Split(';')[0]}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" +
                                                    //$"<img src='images/{brandcomm["Picture"].ToString().Split(';')[0]}' style='width:259px; height:313px; overflow: hidden;' class='img-responsive center-block' alt='/'>" +
                                                "</a>" +
                                                "<div class='image-add-mod'>" +
                                                    "<div class='add-description'>" +
                                                        "<div>" +
                                                            $"<span>{brandcomm["Introduce"]}</span>" +
                                                            "<br>" +
                                                            //"<button class='btn btn-default-color1 btn-sm' type='button' style='margin-right:5px'><i class='fa fa-refresh fa-lg'></i></button>" +
                                                            $"<a href = 'images/{brandcomm["Picture"].ToString().Split(';')[0]}' data-gal='prettyPhoto' title='{brandcomm["Name"]}' class='btn btn-lightbox btn-default-color1 btn-sm'>" +
                                                                "<i class='fa fa-search-plus fa-lg'></i>" +
                                                            "</a>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                            "<div class='card-info'>" +
                                                "<div class='caption'>" +
                                                    "<p class='name-item'>" +
                                                        $"<a class='product-name' href='Products.aspx?id={brandcomm["Id"]}'>{brandcomm["Name"]}</a>" +
                                                    "</p>" +
                                                    $"<span class='product-price'>￥{brandcomm["ProPrice"]}</span>" +
                                                    $"<span class='product-price-old'>￥{brandcomm["Price"]}</span>" +
                                                "</div>" +
                                                "<div class='add-buttons'>" +
                                                    $"<button type = 'button' class='btn btn-add btn-add-wish AddWish' data-id='{brandcomm["Id"]}' data-uname='{Session["uname"]}' data-color='1'  style='margin-right:5px'><i class='fa fa-heart-o'></i></button>" +
                                                    $"<button type = 'button' class='btn btn-add btn-add-cart' name='AddCart' data-id='{brandcomm["Id"]}' data-uname='{Session["uname"]}' data-count='1' data-color='1'><i class='fa fa-shopping-cart'></i></button>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>" +
                                    "</div>";
                }
                DataTable hotdt = probll.HotComm();//热销
                foreach (DataRow hotrow in hotdt.Rows)
                {
                    hotComm.InnerHtml += "<div class='col-xs-6 col-sm-3 col-md-3 col-lg-3'>" +
                                            "<div class='b-item-card'>" +
                                                $"<div class='special-plank {GetColum(hotrow)}'>" +
                                                    $"<span>{GetColum(hotrow)}</span>" +
                                                "</div>" +
                                                "<div class='image'>" +
                                                    $"<a href = 'Products.aspx?id={hotrow["Id"]}'>" +
                                                        $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{hotrow["Picture"].ToString().Split(';')[0]}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" + 
                                                        //$"<img src='images/{hotrow["Picture"].ToString().Split(';')[0]}' class='img-responsive center-block' alt='/'>" +
                                                    "</a>" +
                                                    "<div class='image-add-mod'>" +
                                                        "<div class='add-description'>" +
                                                            "<div>" +
                                                                $"<span>{hotrow["Introduce"]}</span>" +
                                                                "<br>" +
                                                                //"<button class='btn btn-default-color1 btn-sm' type='button' style='margin-right:5px'><i class='fa fa-refresh fa-lg'></i></button>" +
                                                                $"<a href = 'images/{hotrow["Picture"].ToString().Split(';')[0]}' data-gal='prettyPhoto' title='{hotrow["Name"]}' class='btn btn-lightbox btn-default-color1 btn-sm'>" +
                                                                    "<i class='fa fa-search-plus fa-lg'></i>" +
                                                                "</a>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                                "<div class='card-info'>" +
                                                    "<div class='caption'>" +
                                                        "<p class='name-item'>" +
                                                            $"<a class='product-name' href='Products.aspx?id={hotrow["Id"]}'>{hotrow["Name"]}</a>" +
                                                        "</p>" +
                                                        $"<span class='product-price'>￥{hotrow["ProPrice"]}</span>" +
                                                        $"<span class='product-price-old'>￥{hotrow["Price"]}</span>" +
                                                    "</div>" +
                                                    "<div class='add-buttons'>" +
                                                        $"<button type = 'button' class='btn btn-add btn-add-wish AddWish' data-id='{hotrow["Id"]}' data-uname='{Session["uname"]}' data-color='1' style='margin-right:5px'><i class='fa fa-heart-o'></i></button>" +
                                                        $"<button type = 'button' class='btn btn-add btn-add-cart' name='AddCart' data-id='{hotrow["Id"]}' data-uname='{Session["uname"]}' data-count='1' data-color='1'><i class='fa fa-shopping-cart'></i></button>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>";
                }
                
            }
        }

        /// <summary>
        /// 获取商品栏目
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public string GetColum(DataRow row)
        {
            string colum = string.Empty;
            switch (Convert.ToInt32(row["Colum"]))
            {
                case 1:
                    colum = "new";
                    break;
                case 2:
                    colum = "sale";
                    break;
                case 3:
                    colum = "top";
                    break;
                default:
                    colum = string.Empty;
                    break;
            }
            return colum;
        }
    }
}