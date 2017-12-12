using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using System.Data;
using Bll;

namespace Shop
{
    public partial class BackOrder : System.Web.UI.Page
    {
        OrderBll orderbll = new OrderBll ();
        ShoppingBll carbll = new ShoppingBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"]==null)
            {
                Response.Write("<script>window.alert('您还没有登陆，不能查看该页面，请先登陆');location.href='Log.aspx';</script>");
                return;
            }
            BindAllOrder();
            //BindDfk();
            BindDfh();
            BindDsh();
            BindDpj();
        }

        //绑定所有订单
        public void BindAllOrder()
        {
            string uid = Session["uname"].ToString();
            //根据订单类型绑定订单
            DataTable dt = orderbll.BindOrder(uid);
            string ordernum = "";
            foreach (DataRow Row in dt.Rows)
            {

                if (ordernum != Row["orderNum"].ToString())
                {
                    ordernum = Row["orderNum"].ToString();
                    //绑定商品
                    DataTable dt1 = orderbll.BindOrderPro(uid, ordernum);
                    double result = 0;

                    AllOrder.InnerHtml += "<div class='order-status5' id='order'>" +
                                               "<div class='order-title'>" +
                                                   "<div class='dd-num'>" + "订单编号：" + "<a href = 'javascript:;' >" + $"{Row["orderNum"]}" + "</a>" + "</div>" +

                                                   "<span>" + $"{Row["orderTime"]}" + "</span>" +
                                               "</div>" +
                                               "<div class='order-content'>" +
                                                   "<div class='order-left'>";
                    foreach (DataRow Row1 in dt1.Rows)
                    {
                        double a = Convert.ToInt32(Row1["num"]) * Convert.ToDouble(Row1["ProPrice"]);
                        result += a;
                        string pic = Row1["Picture"].ToString().Split(';')[0];
                        AllOrder.InnerHtml += "<ul class='item-list'>" +
                                                "<li class='td td-item'>" +
                                                    "<div class='item-pic'>" +
                                                        "<a href = '#' class='J_MakePoint'>" +
                                                            $"<img src = 'images/{pic}' class='itempic J_ItemImg' >" +
                                                        "</a>" +
                                                    "</div>" +
                                                    "<div class='item-info'>" +
                                                        "<div class='item-basic-info'>" +
                                                            $"<a href = 'ProductDetails.aspx?id={Row1["id"]}' >" +
                                                                "<p>" + $"{Row1["name"]}" + "</p>" +
                                                            "</a>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</li>" +
                                                "<li class='td td-price'>" +
                                                    "<div class='item-price'>" +
                                                        $"{Row1["ProPrice"]}" +
                                                    "</div>" +
                                                "</li>" +
                                                "<li class='td td-number'>" +
                                                    "<div class='item-number'>" +
                                                        "<span>" + "×" + "</span>" + $"{Row1["num"]}" +
                                                    "</div>" +
                                                "</li>" +
                                                "<li class='td td-operation'>" +
                                                    "<div class='item-operation'>" +
                                                    "</div>" +
                                                "</li>" +
                                            "</ul>";
                    }
                    AllOrder.InnerHtml += "</div>" +
                                                    "<div class='order-right'>" +
                                                        "<li class='td td-amount'>" +
                                                            "<div class='item-amount'>" +
                                                                $"￥{result}" +
                                                                //"<p>" + "含运费：" + "<span>" + "10.00" + "</span>" + "</p>" +
                                                            "</div>" +
                                                        "</li>" +
                                                        "<div class='move-right'>" +
                                                            "<li class='td td-status'>" +
                                                                "<div class='item-status'>" +
                                                                    //"<p class='order-info'>" + "<a href = 'orderinfo.html' >" + "订单详情" + "</a>" + "</p>" +

                                                                    //"<p class='order-info'>" + "<a href = 'logistics.html' >" + "查看物流" + "</a>" + "</p>" +

                                                                 "</div >" +

                                                             "</li>" +

                                                        // "<li class='td td-change'>" +
                                                        //    $"<button class='am-btn am-btn-danger anniu' name='DelOrder' data-uid='{Session["uname"]}' data-onum='{Row["orderNum"]}'>" +
                                                        //        "删除订单" + "</button>" +
                                                        //"</li>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>";

                }

            }

        }

        //绑定待付款订单
        //public void BindDfk()
        //{
        //    string  uid =Session["uname"].ToString();
        //    DataTable dt = carbll.GetCarProducts(uid);
        //    foreach (DataRow Row in dt.Rows)
        //    {
        //        string pic = Row["Picture"].ToString().Split(';')[0];
        //        orderdfk.InnerHtml += "<div class='order-left'>" + "<ul class='item-list'>" +
        //                                                      "<li class='td td-item'>" +
        //                                                          "<div class='item-pic'>" +
        //                                                              "<a href = '#' class='J_MakePoint'>" +
        //                                                                  $"<img src = 'images/{pic}' class='itempic J_ItemImg'>" +
        //                                                              "</a>" +
        //                                                          "</div>" +
        //                                                          "<div class='item-info'>" +
        //                                                              "<div class='item-basic-info'>" +
        //                                                                  $"<a href = 'ProductDetails.aspx?id={Row["id"]}' >" +

        //                                                                      "<p>" + $"{Row["name"]}" + "</p>" +
        //                                                                  "</a>" +
        //                                                              "</div>" +
        //                                                          "</div>" +
        //                                                      "</li>" +
        //                                                      "<li class='td td-price'>" +
        //                                                          "<div class='item-price'>" +
        //                                                              $"{Row["ProPrice"]}" +
        //                                                          "</div>" +
        //                                                      "</li>" +
        //                                                      "<li class='td td-number'>" +
        //                                                          "<div class='item-number'>" +
        //                                                              "<span>" + "×" + "</span>" + $"{Row["Count"]}" +
        //                                                          "</div>" +
        //                                                      "</li>" +
        //                                                      "<li class='td td-operation'>" +
        //                                                          "<div class='item-operation'>" +
        //                                                          "</div>" +
        //                                                      "</li>" +
        //                                                  "</ul>" + "</div>";
        //    }
        //    orderdfk.InnerHtml += "<div class='order-right'>" +
        //                                                "<li class='td td-amount'>" +
        //                                                    "<div class='item-amount'>" +
        //                                                        "￥676.00" +
        //                                                        //"<p>" + "含运费：" + "<span>" + "10.00" + "</span>" + "</p>" +
        //                                                    "</div>" +
        //                                                "</li>" +
        //                                                "<div class='move-right'>" +
        //                                                    "<li class='td td-status'>" +
        //                                                        "<div class='item-status'>" +
        //                                                            "<p class='Mystatus'>" + "等待买家付款" + "</p>" +
        //                                                        "</div>" +

        //                                                    "</li>" +

        //                                                    "<li class='td td-change'>" +
        //                                                        "<a href = 'Shopping-Cart.aspx'>" +

        //                                                        "<div class='am-btn am-btn-danger anniu'>" +
        //                                                            "一键支付" + "</div>" + "</a>" +
        //                                                    "</li>" +
        //                                                "</div>" +
        //                                            "</div>";
        //}

        //绑定待发货订单
        public void BindDfh()
        {
            string uid = Session["uname"].ToString();
            string type = "待发货";
            DataTable dt = orderbll.BindOrder(uid, type);
            string ordernum = "";
            foreach (DataRow Row in dt.Rows)
            {

                if (ordernum != Row["orderNum"].ToString())
                {
                    ordernum = Row["orderNum"].ToString();
                    //绑定订单中的商品
                    DataTable dt1 = orderbll.BindOrderPro(uid, ordernum);
                    double result = 0;

                    orderdfh.InnerHtml += "<div class='order-status5' id='order'>" +
                                               "<div class='order-title'>" +
                                                   "<div class='dd-num'>" + "订单编号：" + "<a href = 'javascript:;' >" + $"{Row["orderNum"]}" + "</a>" + "</div>" +
                                                   "<span>" + $"{Row["orderTime"]}" + "</span>" +
                                               "</div>" +
                                               "<div class='order-content'>" +
                                            "<div class='order-left'>";
                    foreach (DataRow Row1 in dt1.Rows)
                    {
                        double a = Convert.ToInt32(Row1["num"]) * Convert.ToDouble(Row1["ProPrice"]);
                        result += a;
                        string pic = Row1["Picture"].ToString().Split(';')[0];
                        orderdfh.InnerHtml += "<ul class='item-list'>" +
                                                              "<li class='td td-item'>" +
                                                                  "<div class='item-pic'>" +
                                                                      "<a href = '#' class='J_MakePoint'>" +
                                                                          $"<img src = 'images/{pic}' class='itempic J_ItemImg'>" +
                                                                      "</a>" +
                                                                  "</div>" +
                                                                  "<div class='item-info'>" +
                                                                      "<div class='item-basic-info'>" +
                                                                          $"<a href = 'ProductDetails.aspx?id={Row1["id"]}' >" +

                                                                              "<p>" + $"{Row1["name"]}" + "</p>" +
                                                                          "</a>" +
                                                                      "</div>" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-price'>" +
                                                                  "<div class='item-price'>" +
                                                                      $"{Row1["ProPrice"]}" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-number'>" +
                                                                  "<div class='item-number'>" +
                                                                      "<span>" + "×" + "</span>" + $"{Row1["num"]}" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-operation'>" +
                                                                  "<div class='item-operation'>" +
                                                                  "</div>" +
                                                              "</li>" +
                                                          "</ul>";
                    }
                    orderdfh.InnerHtml += "</div>" +
                                                "<div class='order-right'>" +
                                                    "<li class='td td-amount'>" +
                                                        "<div class='item-amount'>" +
                                                            $"￥{result}" +
                                                        "</div>" +
                                                    "</li>" +
                                                    "<div class='move-right'>" +
                                                        "<li class='td td-status'>" +
                                                            "<div class='item-status'>" +
                                                                //"<p class='order-info'>" + "<a href = 'orderinfo.html' >" + "订单详情" + "</a>" + "</p>" +
                                                                //"<p class='order-info'>" + "<a href = 'logistics.html' >" + "查看物流" + "</a>" + "</p>" +
                                                                "<p class='order-info'>待发货</p>" +
                                                                "</div >" +
                                                            "</li>" +
                                                        //    "<li class='td td-change'>" +
                                                        //    $"<button class='am-btn am-btn-danger anniu' name='DelOrder' data-uid='{Session["uname"]}' data-onum='{Row["orderNum"]}'>" +
                                                        //        "删除订单" + "</button>" +
                                                        //"</li>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>" +
                                        "</div>";
                }

            }
        }
        public void BindDshdd()
        {
            string uid = Session["uname"].ToString();
            string type = "待收货";
            DataTable dt = orderbll.BindOrder(uid, type);
        }

        //绑定待收货订单
        public void BindDsh()
        {
            string uid =Session["uname"].ToString();
            string type = "待收货";
            DataTable dt = orderbll.BindOrder(uid, type);
            string ordernum = "";
            foreach (DataRow Row in dt.Rows)
            {

                if (ordernum != Row["orderNum"].ToString())
                {
                    ordernum = Row["orderNum"].ToString();
                    DataTable dt1 = orderbll.BindOrderPro(uid, ordernum);
                    double result = 0;

                    orderdsh.InnerHtml += "<div class='order-status5' id='order'>" +
                                               "<div class='order-title'>" +
                                                   "<div class='dd-num'>" + "订单编号：" + "<a href = 'javascript:;' >" + $"{Row["orderNum"]}" + "</a>" + "</div>" +

                                                   "<span>" + $"{Row["orderTime"]}" + "</span>" +
                                               "</div>" +
                                               "<div class='order-content'>" +
                                                   "<div class='order-left'>";
                    foreach (DataRow Row1 in dt1.Rows)
                    {
                        double a = Convert.ToInt32(Row1["num"]) * Convert.ToDouble(Row1["ProPrice"]);
                        result += a;
                        string pic = Row1["Picture"].ToString().Split(';')[0];
                        orderdsh.InnerHtml += "<ul class='item-list'>" +
                                                              "<li class='td td-item'>" +
                                                                  "<div class='item-pic'>" +
                                                                      "<a href = '#' class='J_MakePoint'>" +
                                                                          $"<img src = 'images/{pic}' class='itempic J_ItemImg'>" +
                                                                      "</a>" +
                                                                  "</div>" +
                                                                  "<div class='item-info'>" +
                                                                      "<div class='item-basic-info'>" +
                                                                          $"<a href = 'ProductDetails.aspx?id={Row1["id"]}' >" +

                                                                              "<p>" + $"{Row1["name"]}" + "</p>" +
                                                                          "</a>" +
                                                                      "</div>" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-price'>" +
                                                                  "<div class='item-price'>" +
                                                                      $"{Row1["ProPrice"]}" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-number'>" +
                                                                  "<div class='item-number'>" +
                                                                      "<span>" + "×" + "</span>" + $"{Row1["num"]}" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-operation'>" +
                                                                  "<div class='item-operation'>" +
                                                                  "</div>" +
                                                              "</li>" +
                                                          "</ul>";
                    }
                    orderdsh.InnerHtml += "</div>" +
                                                    "<div class='order-right'>" +
                                                        "<li class='td td-amount'>" +
                                                            "<div class='item-amount'>" +
                                                                $"￥{result}" +
                                                                //"<p>" + "含运费：" + "<span>" + "10.00" + "</span>" + "</p>" +
                                                            "</div>" +
                                                        "</li>" +
                                                        "<div class='move-right'>" +
                                                            "<li class='td td-status'>" +
                                                                "<div class='item-status'>" +
                                                                    //"<p class='order-info'>" + "<a href = 'orderinfo.html' >" + "订单详情" + "</a>" + "</p>" +
                                                                    //"<p class='order-info'>" + "<a href = 'logistics.html' >" + "查看物流" + "</a>" + "</p>" +
                                                                    "<p class='order-info'>待收货</p>" +
                                                                 "</div >" +

                                                             "</li>" +

                                                             "<li class='td td-change'>" +
                                                                $"<button class='am-btn am-btn-danger anniu' name='UpdateOrder' data-uid='{uid}' data-onum='{Row["orderNum"]}'>" +
                                                                    "确认收货" + "</button>" +
                                                            "</li>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>";

                }

            }
        }

        //绑定待评价订单
        public void BindDpj()
        {
            string uid = Session["uname"].ToString();
            string type = "待评价";
            DataTable dt = orderbll.BindOrder(uid, type);
            string ordernum = "";
            foreach (DataRow Row in dt.Rows)
            {

                if (ordernum != Row["orderNum"].ToString())
                {
                    ordernum = Row["orderNum"].ToString();
                    DataTable dt1 = orderbll.BindOrderPro(uid, ordernum);
                    double result = 0;

                    orderdpj.InnerHtml += "<div class='order-status5' id='order'>" +
                                               "<div class='order-title'>" +
                                                   "<div class='dd-num'>" + "订单编号：" + "<a href = 'javascript:;' >" + $"{Row["orderNum"]}" + "</a>" + "</div>" +

                                                   "<span>" + $"{Row["orderTime"]}" + "</span>" +
                                               "</div>" +
                                               "<div class='order-content'>" +
                                                   "<div class='order-left'>";
                    foreach (DataRow Row1 in dt1.Rows)
                    {
                        double a = Convert.ToInt32(Row1["num"]) * Convert.ToDouble(Row1["ProPrice"]);
                        result += a;
                        string pic = Row1["Picture"].ToString().Split(';')[0];
                        orderdpj.InnerHtml += "<ul class='item-list'>" +
                                                              "<li class='td td-item'>" +
                                                                  "<div class='item-pic'>" +
                                                                      "<a href = '#' class='J_MakePoint'>" +
                                                                          $"<img src = 'images/{pic}' class='itempic J_ItemImg'>" +
                                                                      "</a>" +
                                                                  "</div>" +
                                                                  "<div class='item-info'>" +
                                                                      "<div class='item-basic-info'>" +
                                                                          $"<a href = 'ProductDetails.aspx?id={Row1["id"]}' >" +

                                                                              "<p>" + $"{Row1["name"]}" + "</p>" +
                                                                          "</a>" +
                                                                      "</div>" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-price'>" +
                                                                  "<div class='item-price'>" +
                                                                      $"{Row1["ProPrice"]}" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-number'>" +
                                                                  "<div class='item-number'>" +
                                                                      "<span>" + "×" + "</span>" + $"{Row1["num"]}" +
                                                                  "</div>" +
                                                              "</li>" +
                                                              "<li class='td td-operation'>" +
                                                                  "<div class='item-operation'>" +
                                                                  "</div>" +
                                                              "</li>" +
                                                          "</ul>";
                    }
                    orderdpj.InnerHtml += "</div>" +

                                                    "<div class='order-right'>" +
                                                        "<li class='td td-amount'>" +
                                                            "<div class='item-amount'>" +
                                                                $"￥{result}" +
                                                                //"<p>" + "含运费：" + "<span>" + "10.00" + "</span>" + "</p>" +
                                                            "</div>" +
                                                        "</li>" +
                                                        "<div class='move-right'>" +
                                                            "<li class='td td-status'>" +
                                                                "<div class='item-status'>" +
                                                                "<p class='Mystatus'>" + "交易成功" + "</p>" +
                                                                    //"<p class='order-info'>" + "<a href = 'orderinfo.html' >" + "订单详情" + "</a>" + "</p>" +

                                                                    //"<p class='order-info'>" + "<a href = 'logistics.html' >" + "查看物流" + "</a>" + "</p>" +
                                                                    //"<p class='order-info'>待评价</p>" +
                                                                 "</div >" +

                                                             "</li>" +

                                                             "<li class='td td-change'>" +
                                                                $"<button class='am-btn am-btn-danger anniu' name='Orderpj' data-uid='{uid}' data-onum='{Row["orderNum"]}'>" +
                                                                    "评价商品" + "</button>" +
                                                            "</li>" +
                                                        "</div>" +
                                                    "</div>" +
                                                "</div>" +
                                            "</div>";

                }

            }
        }
    }
}