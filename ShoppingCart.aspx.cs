using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Common;
using Bll;

namespace Shop
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        ShoppingBll bll = new ShoppingBll();
        AddressBll addbll = new AddressBll();
        public string ShopNotNull, ShopNull,ShopButton,ClearButton;
        public double Subtotal,Pro,Hui;

        protected void tijiao_ServerClick(object sender, EventArgs e)
        {
            string  uname = Session["uname"].ToString();
            //select 查的内容 from 表名  join 第二个表名  on 两个表的联系 join 第三个表  on 第一个表与第三个表之间的联系 where 条件
            DataTable cardt = bll.GetCarProducts(uname);
            int k = 0;
            string code = "";
            string str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            Random r = new Random();
            //循环产生指定个数的随机字符
            for (int i = 1; i <= 10; i++)
            {
                int j = r.Next(0, str.Length - 1);
                code += str[j];
            }
            //获取默认地址
            int addID= addbll.GetAddByType();
            foreach (DataRow Row in cardt.Rows)
            {
                int pid = Convert.ToInt32(Row["id"]);
                int num = Convert.ToInt32(Row["count"]);
                string type = "待发货";
                //新增订单
                // insert into orders(列名) values(值)
                k = bll.InsertToOrder(uname, pid, code, num, type,addID);
            }
            if (k == 1)
            {
                //清空购物车
                //delete 表名 where 条件
                bll.DelCar(uname);
                Response.Write("<script>alert('付款成功');window.location.href='BackOrder.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('您的购物车空空如也');window.location.href='Shopping-Cart.aspx'</script>");
            }
        }

        public int Sumcount;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["uname"] == null)
                {
                    Response.Write("<script>window.alert('您还没有登陆，不能查看该页面，请先登陆');location.href='Log.aspx';</script>");
                    return;
                }

                int number = 0;
                double price = 0;
                DataTable dt = bll.GetShopCart(Session["uname"].ToString());
                if (dt.Rows.Count<1)
                {
                    tbody.InnerHtml = "<tr><td style='text-align:center' colspan='6'>您的购物车都快饿死了 (>_<)</td></tr>";
                }
                foreach (DataRow row in dt.Rows)
                {
                    Sumcount +=Convert.ToInt32(row["Count"]);
                    number=Convert.ToInt32(row["Count"]);
                    price = Convert.ToDouble(row["ProPrice"]);
                    tbody.InnerHtml+="<tr>"+
                                        "<td>"+
                                            "<div class='image'>"+
									            $"<div style='width:108px; height:132px; overflow: hidden;'><img src = 'images/{row["Picture"].ToString().Split(';')[0]}' style='width:108px;' class='img-responsive img-thumbnail center-block' alt='6s'></div>" +
								            "</div>"+
								            "<div class='caption'>"+
									            $"<a class='product-name' href='Products.aspx?id={row["ID"]}'>{row["Name"]}</a>"+
									            "<div class='product-options'>"+
										            $"<p class='opt-color'>颜色：<span>{GetColor(row)}</span></p>"+
										            $"<p class='availability'>库存：<span>{row["Repertory"]}</span></p>"+
									            "</div>"+
									            "<button type = 'button' class='btn btn-add-wish'>"+"<i class='fa fa-heart-o'>"+"</i>添加到收藏</button>"+
								            "</div>"+
							            "</td>"+
                                        "<td>" +
                                            $"<span class='product-price'>￥{price}</span>" +
                                        "</td>" +
                                        "<td>" +
                                            $"<span class='product-price' style='text-decoration:line-through'>￥{row["Price"]}</span>" +
                                        "</td>" +
							            "<td>"+
								            "<div class='input-group btn-block qty-block' data-trigger='spinner'>"+
									            $"<span data-rule='quantity' style='width: 55px'>{number}</span>"+
								            "</div>"+
							            "</td>"+
							            "<td>"+
								            $"<span class='product-price total-price'>￥{price*number}</span>" +
                                        "</td>" +
                                        "<td class='text-left'>" +
                                            $"<button class='btn btn-remove' name='DelCart' data-id='{row["Id"]}' data-uname='{Session["uname"]}'><i class='fa fa-trash fa-lg'></i></button>" +
                                        "</td>" +
                                    "</tr>";
                    ClearButton =$"<button type='button'  class='btn btn-default-color2 btn-sm ClearCart' data-name='{Session["uname"]}' style='margin-top:5px; float:right; clear:both'>清空购物车</button>";

                    Pro += Convert.ToDouble(row["price"]) * number;
                    Subtotal += price * number;
                    Hui = Pro - Subtotal;
                }
                ShopButton = "<a href='index.aspx' class='btn btn-default-color1 btn-continue btn-sm'>去购物</a>";

                DataTable adddt = addbll.GetAddress(Session["uname"].ToString());
                foreach (DataRow addrow in adddt.Rows)
                {
                    address.InnerHtml += "<div class='col-sm-6'>" +
                                            $"<input type='text' class='form-control' id='province' placeholder='province' value={addrow["province"]} readonly='readonly'>" +
                                        "</div>" +
                                        "<div class='col-sm-6'>" +
                                            $"<input type='text' class='form-control' id='city' placeholder='city' value={addrow["city"]} readonly='readonly'>" +
                                        "</div>" +
                                        "<div class='col-sm-6'>" +
                                           $"<input type='text' class='form-control' id='county' placeholder='county' value={addrow["county"]} readonly='readonly'>" +
                                        "</div>"+
                                        "<div class='col-sm-6'>" +
                                           $"<input type='text' class='form-control' id='county' placeholder='county' value={addrow["details"]} readonly='readonly'>" +
                                        "</div>" +
                                        "<div class='col-sm-6'>" +
                                           $"<input type='text' class='form-control' id='county' placeholder='county' value={addrow["tel"]} readonly='readonly'>" +
                                        "</div>" +
                                        "<div class='col-sm-6'>" +
                                            "<button type = 'submit' class='btn btn-default' >" + "<a href='Address.aspx'>"+"添加收货地址"+"</a>" + "</button>" +
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
            for (int i = 0; i < row["Color"].ToString().Split(';').Length; i++)
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