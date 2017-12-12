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
    public partial class Products : System.Web.UI.Page
    {
        public string name, price, proprice, repertory,introduce,desc,brand,pid,color,brandName,Assess;

        ProductBll bll = new ProductBll();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            if (!IsPostBack)
            {
                if (id == 0)//为null值的string类型转换为int后，值为 0 !impotent
                {
                    Response.Redirect("index.aspx");
                    return;
                }
                if (string.IsNullOrEmpty(id.ToString()))
                {
                    Response.Redirect("Index.aspx");
                }
                DataTable dt = bll.GetCommById(id);
                foreach (DataRow row in dt.Rows)
                {
                    int i = 0;
                    string [] photo  = row["Picture"].ToString().Split(';');
                    foreach (var item in photo)
                    {
                        piclist.InnerHtml += "<li>" +
                                                $"<a data-slide-index = '{i}' href ='#'><img src = 'images/{photo[i]}' alt = '/' /></a>" +
                                             "</li>";
                        bigpic.InnerHtml += $"<li><img src = 'images/{photo[i]}' class='image-responsive' alt='/' style='width:335px;' /></li>";
                        i++;
                    }
                    DataTable dtPj = bll.GetAssByCommID(id);
                    foreach (DataRow rowPj in dtPj.Rows)
                    {
                        Assess += $"<p><div><span style='width:80px; display:inline-block; text-align:center'>{rowPj["uname"]}</span><span style='padding-left: 20px;'>{rowPj["count"]}</span></div></p>";
                    }
                }

                name = dt.Rows[0]["Name"].ToString();
                price= dt.Rows[0]["Price"].ToString();
                proprice= dt.Rows[0]["ProPrice"].ToString();
                repertory= dt.Rows[0]["Repertory"].ToString();
                introduce= dt.Rows[0]["Introduce"].ToString();
                brand = dt.Rows[0]["Brand"].ToString();
                desc = dt.Rows[0]["Describe"].ToString();
                brandName = dt.Rows[0]["BName"].ToString();
                pid = dt.Rows[0]["Id"].ToString();
                DataTable bdt = bll.GetBrandDeComm(brand, id);
                foreach (DataRow brow in bdt.Rows)
                {
                    BrandReco.InnerHtml += "<div class='related-item'>" +
                                            "<div class='b-item-card' >" +
                                                "<div class='image'>" +
                                                    $"<a href = 'Products.aspx?id={brow["Id"]}' >" +
                                                        $"<div style='width:259px; height:313px; overflow: hidden;'><img src='images/{brow["Picture"].ToString().Split(';')[0]}' style='width:259px;' class='img-responsive center-block' alt='/'></div>" +
                                                    "</a>" +
                                                    "<div class='image-add-mod'>" +
                                                        "<div class='add-description'>" +
                                                            "<div>" +
                                                                $"<span>{brow["Introduce"]}</span>" +
                                                                "<br>" +
                                                                $"<a href = 'images/{brow["Picture"].ToString().Split(';')[0]}' data-gal='prettyPhoto' title='{brow["Name"]}' class='btn btn-lightbox btn-default-color1 btn-sm'>" +
                                                                    "<i class='fa fa-search-plus fa-lg'>" + "</i>" +
                                                                "</a>" +
                                                            "</div>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                                "<div class='card-info'>" +
                                                    "<div class='caption'>" +
                                                        "<p class='name-item'>" +
                                                            $"<a class='product-name' href='Products.aspx?id={brow["Id"]}'>{brow["Name"]}</a>" +
                                                        "</p>" +
                                                        $"<span class='product-price'>￥{brow["Price"]}</span>" +
                                                    "</div>" +
                                                    "<div class='add-buttons'>" +
                                                        "<button type = 'button' class='btn btn-add btn-add-wish'>" + "<i class='fa fa-heart-o'>" + "</i>" + "</button>" +
                                                    $"<button type = 'button' class='btn btn-add btn-add-cart' name='AddCart' data-id='{brow["Id"]}' data-uname='{Session["uname"]}' data-count='1' data-color='1'>" + "<i class='fa fa-shopping-cart'>" + "</i>" + "</button>" + "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>";
                }
            }
        }


        /// <summary>
        /// 获取商品颜色
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public string GetColor(DataRow row)
        {
            string color = string.Empty;
            string comm = string.Empty;
            for (int i = 0; i <row["Color"].ToString().Split(';').Length; i++)
            {
                comm = row["Color"].ToString().Split(';')[i];
                switch (comm)
                {
                    case "1":
                        color = "black";
                        break;
                    case "2":
                        color = "red";
                        break;
                    case "3":
                        color = "blue";
                        break;
                    case "4":
                        color = "white";
                        break;
                }
            }
            return color;
        }
    }
}