<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Shop.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="section-product-detail-2">
				<div class="b-page-header">
					<div class="container">
						<div class="row">
							<div class="col-sm-12 clearfix">
								<h3 class="page-title pull-left" style="font-size:20px;">商品详情</h3>
								<div class="b-breadcrumbs pull-right">
									<ul class="list-unstyled">
										<li>
											<a href="Index.aspx">首页</a>
										</li>
										<li>
											<a href="BrandList.aspx?brand=<%=brand %>"><%=brandName %></a>
										</li>
										<li>
											<span><%=name %></span>
										</li>
									</ul>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="container">
					<div class="row">
						<div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
							<div class="detail-main pd-2">
								<div class="row">
									<div class="col-xs-12 col-sm-2 col-md-2 col-lg-1 product-image-2 prew-image" >
										<div class="product-image-thumbs">
											<ul id="piclist" runat="server" ClientIDMode="Static" class="pager-custom list-unstyled enable-bx-slider" data-pager-custom="null" data-controls="true" data-min-slides="4" data-max-slides="12" data-slide-width="96" data-slide-margin="8" data-pager="false" data-mode="vertical" data-infinite-loop="false">
											</ul>
										</div>
									</div>
									<div class="col-xs-12 col-sm-3 col-md-3 col-lg-4 product-image-2 pi2-big-image" style=" border: none;">
										<ul id="bigpic" runat="server" ClientIDMode="Static"  class="bxslider-product2 enable-bx-slider" data-pager-custom="#piclist" data-controls="false" data-min-slides="1" data-max-slides="1" data-slide-width="0" data-slide-margin="0" data-pager="true" data-mode="horizontal" data-infinite-loop="true">
										</ul>
									</div>
									<div class="col-xs-12 col-sm-7 col-md-7 col-lg-7 pd2-descr-product wow fadeInRight">
										<div class="detail-title">
											<h3 class=heading-line><%=name %> <span class="pull-right" style="font-size:12px; font-weight:normal">库存：<%=repertory %></span></h3>
										</div>
										<div class="detail-info clearfix">
											<div class="card-info">
												<div class="caption">
													<div class="name-item">
														<div class="card-price-block clearfix">
															<span class="price-title">价格</span>
															<span class="product-price">￥<%=proprice %></span>
															<span class="product-price-old">￥<%=price %></span>
														</div>
														<div class="rating">
															<span class="star"><i class="fa fa-star"></i></span>
															<span class="star"><i class="fa fa-star"></i></span>
															<span class="star"><i class="fa fa-star"></i></span>
															<span class="star"><i class="fa fa-star"></i></span>
															<span class="star star-empty"><i class="fa fa-star-o"></i></span>
														</div>
													</div>
													<div class="product-description">
														<p>
															<%=introduce %>
														</p>
													</div>
												</div>
											</div>
											<div class="detail-qty-color col-xs-12 col-sm-12 col-md-12 col-lg-4">
												
												<div class="input-group spinner" data-trigger="spinner">
													<h6 class="heading-line">数量</h6>
													<input type="text" id="shu" data-rule="quantity" value="1">
													<div class="spinner-btn">
														<a class="btn btn-default" href="javascript:;" data-spin="up"><i class="fa fa-chevron-up"></i></a>
														<a class="btn btn-default" href="javascript:;" data-spin="down"><i class="fa fa-chevron-down"></i></a>
													</div>
												</div>
											</div>
											<div class="detail-buttons col-xs-12 col-sm-12 col-md-12 col-lg-8 clearfix">
												<div class="add-buttons custom-add-buttons">
													<button type="button" class="btn btn-add btn-add-wish AddWish" data-id="<%=pid %>" data-uname="<%=Session["uname"] %>" data-color='1'  style='margin-right:5px'><i class="fa fa-heart-o"></i> 加入收藏</button>
												</div>
												<div class="cart-add-buttons">
													<button type="button" class="btn btn-cart-color2" name="AddCart" data-id="<%=pid %>" data-uname="<%=Session["uname"]%>" data-color='1'><i class="fa fa-shopping-cart fa-lg"></i> 添加到购物车</button>
												</div>
											</div>
										</div>
									</div>
								</div>
								<div class="row">
									<div class="col-sm-12">
										<div class="b-hr">
											<hr>
										</div>
										<div class="detail-tabs wow fadeInUp">
											<ul class="nav nav-tabs" role="tablist">
												<li role="presentation" class="active">
													<a class="heading-line" href="product-details-2.html#description" aria-controls="description" role="tab" data-toggle="tab">商品详情</a>
												</li>
												<li role="presentation">
													<a class="heading-line" href="product-details-2.html#reviews" aria-controls="reviews" role="tab" data-toggle="tab">用户评价</a>
												</li>
											</ul>
											<div class="tab-content">
												<div role="tabpanel" class="tab-pane active" id="description">
													<p><%=desc %></p>
													<%--<p>
														Processor: A9 chip with 64 bit architecture Integrated M9 movement co-processor
													</p>
													<p>
														Screen type: Retina HD display with 3D Touch 1400:1 contrast ratio (standard) 500 cd/m2 max brightness (standard) Full sRGB standard
														Dual-domain pixels for wider viewing angles Fingerprint-resistant oleophobic coating on front
													</p>
													<p>
														Screen size: 4.7 inch (diagonal) - Resolution of 1 334 x 750 pixels at 326 ppi
													</p>
													<p>
														Rear sensor: 12-megapixel iSight camera with 1.22µ pixels/Live Photos/Autofocus with Focus Pixels/True Tone Flash, Panoramic up to
														63 megapixels/Auto HDR photo
													</p>
													<p>
														Battery life: Talk time up to 14 hours in 3G Standby, up to 10 days (250 hours) Internet browsing: up to 10 hours in 3G, up to 10
													</p>
													<p>
														Don't forget that as an iPhone 6S user you also get access to the revolutionary App Store that has over 1.3 million apps in 155 countries.
													</p>--%>
												</div>
												<div role="tabpanel" class="tab-pane" id="reviews">
													<div class="form-group">
                                                        <%=Assess %>
														<p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad
															consectetur dicta dolorum earum eos et eum ex explicabo impedit
															laboriosam, maxime nesciunt omnis porro ratione saepe, sapiente sint
															totam, voluptas!
														</p>
														<p>Aliquam beatae cum cupiditate dolores excepturi facere harum impedit
															iste laborum. Aspernatur cumque distinctio excepturi illum itaque minus
															molestias nesciunt numquam, possimus recusandae ullam velit veritatis. A
															et nulla repudiandae!
														</p>
														<p>Alias amet animi consequuntur culpa debitis dolorem esse expedita illum
															labore numquam perspiciatis possimus praesentium quae quas quibusdam
															reprehenderit repudiandae sint sit soluta suscipit, tenetur vero
															voluptatibus! Illum neque, voluptatem!
														</p>
														<p>Alias amet asperiores culpa debitis dolor eligendi enim facere fugiat
															hic, iusto laboriosam molestias mollitia nobis nulla possimus quasi quia
															quod, soluta sunt voluptates? Dicta facilis fugit nostrum omnis sint.
														</p>
													</div>
												</div>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="b-hr">
					<hr>
				</div>
				<div class="container">
					<div class="row">
						<div class="col-sm-12 clearfix">
							<h3 class="heading-line-long">同品推荐</h3>
							<div class="custom-nav-mod">
								<div class="slider-nav">
									<a class="slider-prev"><i class="fa fa-chevron-left"></i></a>
									<span class="nav-divider"></span>
									<a class="slider-next"><i class="fa fa-chevron-right"></i></a>
								</div>
							</div>
						</div>
						<div class="col-sm-12 wow fadeInUp">
							<div class="row">
								<div id="BrandReco" runat="server" ClientIDMode="Static" class="b-related enable-owl-carousel" data-loop="true" data-auto-width="false" data-dots="false" data-nav="false" data-margin="0" data-responsive-class="true" data-responsive='{"0":{"items":1},"479":{"items":2},"768":{"items":3},"1199":{"items":4}}' data-slider-next=".slider-next" data-slider-prev=".slider-prev">
								</div>
							</div>
						</div>
					</div>
				</div>
<%--				<div class="b-hr">
					<hr>
				</div>
				<div class="container">
					<div class="row">
						<div class="col-sm-12 wow fadeInUp">
							<div class="b-brands-holder">
								<div class="b-store-features b-brands-logos clearfix">
									<ul id="llll" class="list-unstyled enable-owl-carousel" data-loop="true" data-auto-width="false" data-dots="true" data-nav="false" data-margin="0" data-responsive-class="true" data-responsive='{"0":{"items": "1"},"479":{"items": "2"},"992":{"items": "3"},"1199":{"items":"6","autoWidth":"true"}}' data-slider-next="" data-slider-prev="">
										<li>
											<a href="#">
												<img src="media/brand-logos/rick.png" class="img-responsive center-block" alt="/">
											</a>
										</li>
										<li>
											<a href="#">
												<img src="media/brand-logos/mike.png" class="img-responsive center-block" alt="/">
											</a>
										</li>
										<li>
											<a href="#">
												<img src="media/brand-logos/sa.png" class="img-responsive center-block" alt="/">
											</a>
										</li>
										<li>
											<a href="#">
												<img src="media/brand-logos/gone.png" class="img-responsive center-block" alt="/">
											</a>
										</li>
										<li>
											<a href="#">
												<img src="media/brand-logos/xmob.png" class="img-responsive center-block" alt="/">
											</a>
										</li>
										<li>
											<a href="#">
												<img src="media/brand-logos/roman.png" class="img-responsive center-block" alt="/">
											</a>
										</li>
									</ul>
								</div>
							</div>
						</div>
					</div>
				</div>--%>
			</section>
</asp:Content>
