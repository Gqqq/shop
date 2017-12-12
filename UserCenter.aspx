<%@ Page Title="" Language="C#" MasterPageFile="~/Son.master" AutoEventWireup="true" CodeBehind="UserCenter.aspx.cs" Inherits="Shop.UserInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="wrap-left">
		<div class="wrap-list">
			<div class="m-user">
				<!--个人信息 -->
				<div class="m-bg"></div>
				<div class="m-userinfo">
					<div class="m-baseinfo">
						<a href="information.html">
							<img src="../images/images/getAvatar.do.jpg">
						</a>
						<em class="s-name">(小叮当)</em>
						<div class="s-prestige am-btn am-round">
							<span class="vip1">会员福利</span>
						</div>
					</div>
					<div class="m-right">
										
						<div class="m-address">
							<a href="address.html" class="i-trigger">我的收货地址</a>
						</div>
					</div>
				</div>
			</div>
			<div class="box-container-bottom"></div>

			<!--订单 -->
			<div class="m-order">
				<div class="s-bar">
					<i class="s-icon"></i>我的订单
					<a class="i-load-more-item-shadow" href="order.html">全部订单</a>
				</div>
				<ul>
					<li><a href="order.html"><i><img src="../images/images/pay.png"/></i><span>待付款</span></a></li>
					<li><a href="order.html"><i><img src="../images/images/send.png"/></i><span>待发货<em class="m-num">1</em></span></a></li>
					<li><a href="order.html"><i><img src="../images/images/receive.png"/></i><span>待收货</span></a></li>
					<li><a href="order.html"><i><img src="../images/images/comment.png"/></i><span>待评价<em class="m-num">3</em></span></a></li>
					<li><a href="change.html"><i><img src="../images/images/refund.png"/></i><span>退换货</span></a></li>
				</ul>
			</div>
			<!--九宫格-->
			<div class="user-patternIcon">
				<div class="s-bar">
					<i class="s-icon"></i>我的常用
				</div>
				<ul>

					<a href="../home/shopcart.html"><li class="am-u-sm-4"><i class="am-icon-shopping-basket am-icon-md"></i><img src="../images/images/images/iconbig.png"/><p>购物车</p></li></a>
					<a href="collection.html"><li class="am-u-sm-4"><i class="am-icon-heart am-icon-md"></i><img src="../images/images/iconsmall1.png"/><p>我的收藏</p></li></a>
					<a href="../home/home.html"><li class="am-u-sm-4"><i class="am-icon-gift am-icon-md"></i><img src="../images/images/iconsmall0.png"/><p>为你推荐</p></li></a>
					<a href="comment.html"><li class="am-u-sm-4"><i class="am-icon-pencil am-icon-md"></i><img src="../images/images/iconsmall3.png"/><p>好评宝贝</p></li></a>
					<a href="foot.html"><li class="am-u-sm-4"><i class="am-icon-clock-o am-icon-md"></i><img src="../images/images/iconsmall2.png"/><p>我的足迹</p></li></a>                                                                        
				</ul>
			</div>
							
			<!--收藏夹 -->
			<div class="you-like">
				<div class="s-bar">我的收藏
					<a class="am-badge am-badge-danger am-round">降价</a>
					<a class="am-badge am-badge-danger am-round">下架</a>
					<a class="i-load-more-item-shadow" href="#"><i class="am-icon-refresh am-icon-fw"></i>换一组</a>
				</div>
				<div class="s-content">
					<div class="s-item-wrap">
						<div class="s-item">

							<div class="s-pic">
								<a href="#" class="s-pic-link">
									<img src="../images/images/0-item_pic.jpg_220x220.jpg" alt="包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰" title="包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰" class="s-pic-img s-guess-item-img">
								</a>
							</div>
							<div class="s-price-box">
								<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value">42.50</em></span>
								<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value">68.00</em></span>

							</div>
							<div class="s-title"><a href="#" title="包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰">包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰</a></div>
							<div class="s-extra-box">
								<span class="s-comment">好评: 98.03%</span>
								<span class="s-sales">月销: 219</span>

							</div>
						</div>
					</div>

					<div class="s-item-wrap">
						<div class="s-item">

							<div class="s-pic">
								<a href="#" class="s-pic-link">
									<img src="../images/images/1-item_pic.jpg_220x220.jpg" alt="s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰" title="s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰" class="s-pic-img s-guess-item-img">
								</a>
							</div>
							<div class="s-price-box">
								<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value">49.90</em></span>
								<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value">88.00</em></span>

							</div>
							<div class="s-title"><a href="#" title="s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰">s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰</a></div>
							<div class="s-extra-box">
								<span class="s-comment">好评: 99.74%</span>
								<span class="s-sales">月销: 69</span>

							</div>
						</div>
					</div>

					<div class="s-item-wrap">
						<div class="s-item">

							<div class="s-pic">
								<a href="#" class="s-pic-link">
									<img src="../images/images/-0-saturn_solar.jpg_220x220.jpg" alt="4折抢购!十二生肖925银女戒指,时尚开口女戒" title="4折抢购!十二生肖925银女戒指,时尚开口女戒" class="s-pic-img s-guess-item-img">
								</a>
							</div>
							<div class="s-price-box">
								<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value">378.00</em></span>
								<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value">1888.00</em></span>

							</div>
							<div class="s-title"><a href="#" title="4折抢购!十二生肖925银女戒指,时尚开口女戒">4折抢购!十二生肖925银女戒指,时尚开口女戒</a></div>
							<div class="s-extra-box">
								<span class="s-comment">好评: 99.93%</span>
								<span class="s-sales">月销: 278</span>

							</div>
						</div>
					</div>

					<div class="s-item-wrap">
						<div class="s-item">

							<div class="s-pic">
								<a href="#" class="s-pic-link">
									<img src="../images/images/0-item_pic.jpg_220x220.jpg" alt="包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰" title="包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰" class="s-pic-img s-guess-item-img">
								</a>
							</div>
							<div class="s-price-box">
								<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value">42.50</em></span>
								<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value">68.00</em></span>

							</div>
							<div class="s-title"><a href="#" title="包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰">包邮s925纯银项链女吊坠短款锁骨链颈链日韩猫咪银饰简约夏配饰</a></div>
							<div class="s-extra-box">
								<span class="s-comment">好评: 98.03%</span>
								<span class="s-sales">月销: 219</span>

							</div>
						</div>
					</div>

					<div class="s-item-wrap">
						<div class="s-item">

							<div class="s-pic">
								<a href="#" class="s-pic-link">
									<img src="../images/images/1-item_pic.jpg_220x220.jpg" alt="s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰" title="s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰" class="s-pic-img s-guess-item-img">
								</a>
							</div>
							<div class="s-price-box">
								<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value">49.90</em></span>
								<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value">88.00</em></span>

							</div>
							<div class="s-title"><a href="#" title="s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰">s925纯银千纸鹤锁骨链短款简约时尚韩版素银项链小清新秋款女配饰</a></div>
							<div class="s-extra-box">
								<span class="s-comment">好评: 99.74%</span>
								<span class="s-sales">月销: 69</span>

							</div>
						</div>
					</div>

					<div class="s-item-wrap">
						<div class="s-item">

							<div class="s-pic">
								<a href="#" class="s-pic-link">
									<img src="../images/images/-0-saturn_solar.jpg_220x220.jpg" alt="4折抢购!十二生肖925银女戒指,时尚开口女戒" title="4折抢购!十二生肖925银女戒指,时尚开口女戒" class="s-pic-img s-guess-item-img">
								</a>
							</div>
							<div class="s-price-box">
								<span class="s-price"><em class="s-price-sign">¥</em><em class="s-value">378.00</em></span>
								<span class="s-history-price"><em class="s-price-sign">¥</em><em class="s-value">1888.00</em></span>

							</div>
							<div class="s-title"><a href="#" title="4折抢购!十二生肖925银女戒指,时尚开口女戒">4折抢购!十二生肖925银女戒指,时尚开口女戒</a></div>
							<div class="s-extra-box">
								<span class="s-comment">好评: 99.93%</span>
								<span class="s-sales">月销: 278</span>

							</div>
						</div>
					</div>

				</div>
			</div>

		</div>
	</div>
	<div class="wrap-right">

		<!-- 日历-->
		<div class="day-list">
			<div class="s-bar">
				<a class="i-history-trigger s-icon" href="#"></a>我的日历
				<a class="i-setting-trigger s-icon" href="#"></a>
			</div>
			<div class="s-care s-care-noweather">
				<div class="s-date">
					<em>21</em>
					<span>星期一</span>
					<span>2015.12</span>
				</div>
			</div>
		</div>
		<!--新品 -->
		<div class="new-goods">
			<div class="s-bar">
				<i class="s-icon"></i>今日新品
				<a class="i-load-more-item-shadow">15款新品</a>
			</div>
			<div class="new-goods-info">
				<a class="shop-info" href="#" target="_blank">
					<div class="face-img-panel">
						<img src="../images/images/imgsearch1.jpg" alt="">
					</div>
					<span class="new-goods-num ">4</span>
					<span class="shop-title">剥壳松子</span>
				</a>
				<a class="follow " target="_blank">关注</a>
			</div>
		</div>

		<!--热卖推荐 -->
		<div class="new-goods">
			<div class="s-bar">
				<i class="s-icon"></i>热卖推荐
			</div>
			<div class="new-goods-info">
				<a class="shop-info" href="#" target="_blank">
					<div >
						<img src="../images/images/imgsearch1.jpg" alt="">
					</div>
                    <span class="one-hot-goods">￥9.20</span>
				</a>
			</div>
		</div>

	</div>
</asp:Content>
