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
    public partial class ProductList : System.Web.UI.Page
    {
        ProductBll bll = new ProductBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string brand = Request["brand"];
                if (brand==null)
                {
                    Response.Redirect("index.aspx");
                    return;
                }
                DataTable dt = bll.GetTopCommByBrand();
                foreach (DataRow row in dt.Rows)
                {
                    Hot.InnerHtml += "<div class='filter-smart-item col-sm-4 wow fadeInLeft'>" +
                                        "<div class='image'>" +
                                            "<div class='hold'>" +
                                                $"<img src = 'images/{row["Picture"].ToString().Split(';')[0]}' style='width:250px; max-height:300px' class='img-responsive center-block' alt='/'>" +
                                                "<div class='image-add'>" +
                                                    $"<a href = 'Products.aspx?id={row["Id"]}' class='btn btn-default-color1 btn-sm'>查看更多</a>" +
                                                "</div>" +
                                            "</div>" +
                                            "<div class='smart-caption'>" +
                                                "<p>引领潮流</p>" +
                                            "</div>" +
                                        "</div>" +
                                    "</div>";
                }
                DataTable Hotdt = bll.GetHotByBrand(brand);
                foreach (DataRow row1 in Hotdt.Rows)
                {
                    HotComm.InnerHtml+="<div class='related-item'>"+
									        "<div class='b-item-card'>"+
                                                $"<div class='special-plank {GetColum(row1)}'>" +
											        $"<span>{GetColum(row1)}</span>"+
										        "</div>"+
										        "<div class='image'>"+
                                                    $"<a href = 'Products.aspx?id={row1["Id"]}' >" +
                                                        $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{row1["Picture"].ToString().Split(';')[0]}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" +
                                                        //$"<img src='images/{row1["Picture"].ToString().Split(';')[0]}' class='img-responsive center-block' alt='/'>" +
											        "</a>"+
											        "<div class='image-add-mod'>"+
												        "<div class='add-description'>"+
													        "<div>"+
														        $"<span>{row1["Introduce"]}</span>"+
														        "<br>"+
														        //"<button class='btn btn-default-color1 btn-sm' type='button'>"+"<i class='fa fa-refresh fa-lg'>"+"</i>"+"</button>"+
														        $"<a href = 'images/{row1["Picture"].ToString().Split(';')[0]}' data-gal='prettyPhoto' title='{row1["Name"]}' class='btn btn-lightbox btn-default-color1 btn-sm'>"+
															        "<i class='fa fa-search-plus fa-lg'>"+"</i>"+
														        "</a>"+
													        "</div>"+

												        "</div>"+
											        "</div>"+
										        "</div>"+
										        "<div class='card-info'>"+
											        "<div class='caption'>"+
												        "<p class='name-item'>"+
													        $"<a class='product-name' href='Products.aspx?id={row1["Id"]}'>{row1["Name"]}</a>"+
												        "</p>"+
												        $"<span class='product-price'>￥{row1["ProPrice"]}</span>"+
												        $"<span class='product-price-old'>￥{row1["Price"]}</span>" +
                                                    "</div>" +
                                                    "<div class='add-buttons'>" +
                                                        $"<button type = 'button' class='btn btn-add btn-add-wish AddWish' data-id='{row1["Id"]}' data-uname='{Session["uname"]}' data-color='1' style='margin-right:5px'>" + "<i class='fa fa-heart-o'>" + "</i>" + "</button>" +
                                                    $"<button type = 'button' class='btn btn-add btn-add-cart' name='AddCart' data-id='{row1["Id"]}' data-uname='{Session["uname"]}' data-count='1'>" + "<i class='fa fa-shopping-cart'>" + "</i>" + "</button>" + "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>";
                }
                DataTable dt2 = bll.GetNewByBrand(brand);
                foreach (DataRow row2 in dt2.Rows)
                {
                    NewComm.InnerHtml += "<div class='related-item'>" +
                                            "<div class='b-item-card'>" +
                                                $"<div class='special-plank {GetColum(row2)}'>" +
                                                    $"<span>{GetColum(row2)}</span>" +
                                                "</div>" +
                                                "<div class='image'>" +
                                                    $"<a href = 'Products.aspx?id={row2["Id"]}' >" +
                                                        $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{row2["Picture"].ToString().Split(';')[0]}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" +
                                                        //$"<img src='images/{row2["Picture"].ToString().Split(';')[0]}' class='img-responsive center-block' alt='/'>" +
                                                    "</a>" +
                                                    "<div class='image-add-mod'>" +
                                                        "<div class='add-description'>" +
                                                            "<div>" +
                                                                "<span></span>" +
                                                                "<br>" +
                                                                //"<button class='btn btn-default-color1 btn-sm' type='button'>" + "<i class='fa fa-refresh fa-lg'>" + "</i>" + "</button>" +
                                                                $"<a href = 'images/{row2["Picture"].ToString().Split(';')[0]}' data-gal='prettyPhoto' title='{row2["Name"]}' class='btn btn-lightbox btn-default-color1 btn-sm'>" +
                                                                    "<i class='fa fa-search-plus fa-lg'></i>" +
                                                                "</a>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                                "<div class='card-info'>" +
                                                    "<div class='caption'>" +
                                                        "<p class='name-item'>" +
                                                            $"<a class='product-name' href='Products.aspx?id={row2["Id"]}'>{row2["Name"]}</a>" +
                                                        "</p>" +
                                                        $"<span class='product-price'>￥{row2["ProPrice"]}</span>" +
                                                        $"<span class='product-price-old'>￥{row2["Price"]}</span>" +
                                                    "</div>" +
                                                    "<div class='add-buttons'>" +
                                                        $"<button type = 'button' class='btn btn-add btn-add-wish AddWish' data-id='{row2["Id"]}' data-uname='{Session["uname"]}' data-color='1' style='margin-right:5px'><i class='fa fa-heart-o'></i></button>" +
                                                    $"<button type = 'button' class='btn btn-add btn-add-cart' name='AddCart' data-id='{row2["Id"]}' data-uname='{Session["uname"]}' data-count='1'><i class='fa fa-shopping-cart'></i></button></div>" +
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