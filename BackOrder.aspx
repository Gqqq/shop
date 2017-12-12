<%@ Page Title="" Language="C#" MasterPageFile="~/Son.master" AutoEventWireup="true" CodeBehind="BackOrder.aspx.cs" Inherits="Shop.BackOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/js/jquery.min.js"></script>
	<script src="/js/amazeui.js"></script>
    <script type="text/javascript">
            //删除订单
            $(function () {
                $('button[name=DelOrder]').click(function () {
                    var that = this;
                    $.ajax(
                        {
                            url: 'ashx/OrderHandler.ashx',
                            type: 'POST',
                            data: {action:"Del", uid: $(that).data('uid'),onum:$(that).data('onum') }                                 
                        }).done(function (res) {
                            if (res === '200') {
                                $(that).parents('div[id=order]').remove();
                                alert('删除成功，正在跳转');
                                //window.location.href = 'BackOrder.aspx'
                            }
                            else {
                                alert("删除失败");
                            }
                        }).error(function () {
                            alert("发生错误");
                        })
                })

            })
      </script>
    <script type="text/javascript">
            //收货
            $(function () {
                $('button[name=UpdateOrder]').click(function () {
                    var that = this;
                    $.ajax(
                        {
                            url: 'ashx/OrderHandler.ashx',
                            type: 'POST',
                            data: { action:"Update", uid: $(that).data('uid'), onum: $(that).data('onum'), type: "待评价 "}
                        }).done(function (res) {
                            if (res === '200') {
                                $(that).parents('div[id=order]').remove();
                                alert('确认收货成功，正在跳转');
                                window.location.href = 'BackOrder.aspx'
                            }
                            else {
                                alert("确认收货失败");
                            }
                        }).error(function () {
                            alert("发生错误");
                        })
                })

            })
      </script>
    <div class="user-order">
						<!--标题 -->
						<div class="am-cf am-padding">
							<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">订单管理</strong> / <small>Order</small></div>
						</div>
						<hr/>

						<div class="am-tabs am-tabs-d2 am-margin" data-am-tabs>

							<ul class="am-avg-sm-5 am-tabs-nav am-nav am-nav-tabs">
								<li class="am-active"><a href="#tab1">所有订单</a></li>
								<li><a href="#tab3">待发货</a></li>
								<li><a href="#tab4">待收货</a></li>
								<%--<li><a href="#tab4">待评价</a></li>--%>
                                <li><a href="#tab5">已完成</a></li>
							</ul>

							<div class="am-tabs-bd">
								<div class="am-tab-panel am-fade am-in am-active" id="tab1">
									<div class="order-top">
										<div class="th th-operation">
											<td class="td-inner">订单编号</td>
										</div>
										<div class="th th-price" style="margin-left:100px">
											<td class="td-inner">下单时间</td>
										</div>
                                        <div class="th th-price" style="margin-left:20px">
											<td class="td-inner">商品单价</td>
										</div>
										<div class="th th-operation">
											<td class="td-inner">商品数量</td>
										</div>
										<%--<div class="th th-operation">
											<td class="td-inner">订单状态</td>
										</div>--%>
										<div class="th th-amount" style="margin-left:100px">
											<td class="td-inner">总价格（元）</td>
										</div>
									</div>
									<div class="order-main">
										<div class="order-list" id="AllOrder" runat="server" ClientIDMode="Static">
											
										</div>

									</div>

								</div>
								<div class="am-tab-panel am-fade" id="tab2">
									<div class="order-top">
										<div class="th th-operation">
											<td class="td-inner">订单编号</td>
										</div>
										<div class="th th-price" style="margin-left:100px">
											<td class="td-inner">下单时间</td>
										</div>
                                        <div class="th th-price" style="margin-left:20px">
											<td class="td-inner">商品单价</td>
										</div>
										<div class="th th-operation">
											<td class="td-inner">商品数量</td>
										</div>
										<%--<div class="th th-operation">
											<td class="td-inner">订单状态</td>
										</div>--%>
										<div class="th th-amount" style="margin-left:100px">
											<td class="td-inner">总价格（元）</td>
										</div>
									</div>
									<div class="order-main">
										<div class="order-list">
											<div class="order-status1">
												<div class="order-content" id="orderdfk" runat="server" ClientIDMode="Static">
													

												</div>
											</div>
										</div>

									</div>
								</div>
								<div class="am-tab-panel am-fade" id="tab3">
									<div class="order-top">
										<div class="th th-operation">
											<td class="td-inner">订单编号</td>
										</div>
										<div class="th th-price" style="margin-left:100px">
											<td class="td-inner">下单时间</td>
										</div>
                                        <div class="th th-price" style="margin-left:20px">
											<td class="td-inner">商品单价</td>
										</div>
										<div class="th th-operation">
											<td class="td-inner">商品数量</td>
										</div>
										<%--<div class="th th-operation">
											<td class="td-inner">订单状态</td>
										</div>--%>
										<div class="th th-amount" style="margin-left:100px">
											<td class="td-inner">总价格（元）</td>
										</div>
									</div>
									<div class="order-main">
										<div class="order-list" id="orderdfh" runat="server" ClientIDMode="Static">
											
										</div>
									</div>
								</div>
								<div class="am-tab-panel am-fade" id="tab4">
									<div class="order-top">
										<div class="th th-operation">
											<td class="td-inner">订单编号</td>
										</div>
										<div class="th th-price" style="margin-left:100px">
											<td class="td-inner">下单时间</td>
										</div>
                                        <div class="th th-price" style="margin-left:20px">
											<td class="td-inner">商品单价</td>
										</div>
										<div class="th th-operation">
											<td class="td-inner">商品数量</td>
										</div>
										<%--<div class="th th-operation">
											<td class="td-inner">订单状态</td>
										</div>--%>
										<div class="th th-amount" style="margin-left:100px">
											<td class="td-inner">总价格（元）</td>
										</div>
									</div>
									<div class="order-main">
										<div class="order-list" id="orderdsh" runat="server" ClientIDMode="Static">
											
										</div>
									</div>
								</div>
								<div class="am-tab-panel am-fade" id="tab5">
									<div class="order-top">
										<div class="th th-operation">
											<td class="td-inner">订单编号</td>
										</div>
										<div class="th th-price" style="margin-left:100px">
											<td class="td-inner">下单时间</td>
										</div>
                                        <div class="th th-price" style="margin-left:20px">
											<td class="td-inner">商品单价</td>
										</div>
										<div class="th th-operation">
											<td class="td-inner">商品数量</td>
										</div>
										<%--<div class="th th-operation">
											<td class="td-inner">订单状态</td>
										</div>--%>
										<div class="th th-amount" style="margin-left:100px">
											<td class="td-inner">总价格（元）</td>
										</div>
									</div>
									<div class="order-main">
										<div class="order-list" id="orderdpj" runat="server" ClientIDMode="Static">
											<!--不同状态的订单	-->
										</div>

									</div>

								</div>
							</div>

						</div>
					</div>
</asp:Content>
