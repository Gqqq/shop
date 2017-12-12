<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Shop.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="section-shopping-cart">
    <div class="b-page-header">
	    <div class="container">
		    <div class="row">
			    <div class="col-sm-12 clearfix">
				    <h3 class="page-title pull-left" style="font-size:20px;">购物车</h3>
				    <div class="b-breadcrumbs pull-right">
					    <ul class="list-unstyled">
						    <li>
							    <a href="index.aspx">首页</a>
						    </li>
						    <li>
							    <span>购物车</span>
						    </li>
					    </ul>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <div class="container">
	    <div class="row">
		    <div class="col-sm-12 cart-table wow fadeInUp">
			    <div class="b-table b-cart-table table-responsive">
				    <table class="table">
					    <thead>
						    <tr>
							    <td>
								    <span>商品<span class="counter">(<%=Sumcount %>)</span></span>
							    </td>
							    <td>
								    <span>优惠价</span>
							    </td>
                                <td>
								    <span>原价</span>
							    </td>
							    <td>
								    <span>数量</span>
							    </td>
							    <td>
								    <span>小计</span>
							    </td>
							    <td>
								    <span>删除</span>
							    </td>
						    </tr>
					    </thead>
					    <tbody id="tbody" runat="server" ClientIDMode="Static">
					    </tbody>
				    </table>
			    </div>
                <%=ShopButton %>
			    <%=ClearButton %>
		    </div>
		    <div class="col-xs-12 col-sm-12 col-md-8 col-lg-8 wow fadeInLeft"><%--收货地址--%>
			    <div id="tax-discount-form" class="b-form b-form-add" >
				    <ul class="nav nav-tabs" role="tablist">
					    <li role="presentation" class="active">
						    <a class="heading-line" href="shopping-cart.html#add" aria-controls="add" role="tab" data-toggle="tab">收货地址</a>
					    </li>
					    
				    </ul>
				    <div class="tab-content">
					    <div role="tabpanel" class="tab-pane active" id="add">
						    <div class="form-group">
							    <div class="b-form-description">
								    <p>
									    检查您的收货地址
								    </p>
							    </div>
                                <div class="row" id="address" runat="server">
								             
								</div>
						    </div>
					    </div>
				    </div>
			    </div>
		    </div>
		    <div class="col-xs-12 col-sm-12 col-md-4 col-lg-4 wow fadeInRight" style="float:right; margin-top:100px;">
			    <div class="b-total-table clearfix">
				    <table class="table table-condensed">
					    <tbody>
						    <tr>
							    <td>总价</td>
							    <td>￥<%=Pro %></td>
						    </tr>
                            <tr>
							    <td>优惠</td>
							    <td>￥<%=Hui %></td>
						    </tr>
						    <tr class="total">
							    <td>实付</td>
							    <td>￥<%=Subtotal %></td>
						    </tr>
					    </tbody>
				    </table>
				    <%--<button class="btn btn-primary-color2 btn-sm" runat="server" id="tijiao" onserverclick="tijiao_ServerClick" ClientIDMode="Static">提交订单</button>--%>
                    <form runat="server">
                        <input type="button" class="btn btn-primary-color2 btn-sm" value="提交订单" runat="server" onserverclick="tijiao_ServerClick"/>
                    </form>
			    </div>
		    </div>
	    </div>
    </div>
</section>
</asp:Content>
