<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MyWish.aspx.cs" Inherits="Shop.MyWish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="b-page-header">
	    <div class="container">
		    <div class="row">
			    <div class="col-sm-12 clearfix">
				    <h3 class="page-title pull-left">我的收藏</h3>
				    <div class="b-breadcrumbs pull-right">
					    <ul class="list-unstyled">
						    <li>
							    <a href="index.aspx">首页</a>
						    </li>
						    <li>
							    <span>我的收藏</span>
						    </li>
					    </ul>
				    </div>
			    </div>
		    </div>
	    </div>
    </div>
    <div class="container">
	<div class="row">
        <div class="col-xs-12 col-sm-12 col-md-9 col-lg-9" style="width:100%">
				<div class="b-settings">
					<div class="settings-tools">
						<h3 class="heading-line pull-left">
							samsung
							<span class="settings-counter">[ 1560 in total ]</span>
						</h3>
						<div class="settings-block pull-right">
							<div class="settings-options">
								<div class="select-block">
									<span class="select-title">Show</span>
									<select class="selectpicker" id="show-items" data-width="75px">
										<option value="Default Sorting">15</option>
										<option value="Default Sorting">30</option>
										<option value="Default Sorting">45</option>
									</select>
								</div>
								<div class="select-block">
									<span class="select-title">Sort By</span>
									<select class="selectpicker" id="sort-product" data-width="134px">
										<option value="Default Sorting">Revelance</option>
										<option value="Default Sorting">Revelance</option>
										<option value="Default Sorting">Revelance</option>
									</select>
								</div>
							</div>
							<div class="settings-view hidden-md hidden-sm hidden-xs">
								<ul id="type-of-display" class="list-unstyled">
									<li>
										<button class="btn toogle-view grid-list active-view">
											<i class="fa fa-th-list fa-fw"></i>
										</button>
									</li>
									<li>
										<button class="btn toogle-view grid-3">
											<i class="fa fa-th-large fa-fw"></i>
										</button>
									</li>
								</ul>
							</div>
						</div>
					</div>
					<%--<div class="settings-result text-center">
						<p>Showing restults 1 to 12 of 140 total</p>
					</div>--%>
				</div>
				<div class="b-grid b-grid-list">
					<div class="row">
						<%--<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card">
								<div class="image">
									<a href="media/item-card-media/6s-plus.jpg" data-gal="prettyPhoto" title="6s Plus">
										<img src="media/item-card-media/6s-plus.jpg" class="img-responsive center-block" alt="6s Plus">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">iPhone 6s plus</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$399.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="special-plank new">
									<span>new</span>
								</div>
								<div class="image">
									<a href="media/item-card-media/mate-s.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/mate-s.jpg" class="img-responsive center-block" alt="HUAWEI Mate S">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Huawei Mate S</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$280.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="special-plank new">
									<span>new</span>
								</div>
								<div class="image">
									<a href="media/item-card-media/xperia.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/xperia.jpg" class="img-responsive center-block" alt="Xperia">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">SONY XPERIA Z5</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$250.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/mi41.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/mi41.jpg" class="img-responsive center-block" alt="MI 41">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Xiaomi Mi 4i</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$350.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/core-prime.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/core-prime.jpg" class="img-responsive center-block" alt="Core Prime">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Galaxy Core Prime </a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$399.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/6s.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/6s.jpg" class="img-responsive center-block" alt="6s">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Apple iPhone 6S</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$550.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="special-plank sale">
									<span>-20%</span>
								</div>
								<div class="image">
									<a href="media/item-card-media/RoseGold.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/RoseGold.jpg" class="img-responsive center-block" alt="Rose Gold">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">iPhone Rose Gold</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$280.00</span>
											<span class="product-price-old">$649.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/g84g.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/g84g.jpg" class="img-responsive center-block" alt="HUAWEI G8 4G">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">HUAWEI G8 4G</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$350.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/mi4132g.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/mi4132g.jpg" class="img-responsive center-block" alt="MI 41 32">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Xiaomi Mi4i 32Gb</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$270.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/z5-prem.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/z5-prem.jpg" class="img-responsive center-block" alt="Z5 Premium">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Sony Z5 Premium</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$790.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/zen.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/zen.jpg" class="img-responsive center-block" alt="Zen">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">ASUS Zenfone 2</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$399.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class="col-lg-4 col-md-4 col-sm-4 col-xs-6">
							<div class="b-item-card wow fadeInUp">
								<div class="image">
									<a href="media/item-card-media/lum.jpg" data-gal="prettyPhoto" title="Item">
										<img src="media/item-card-media/lum.jpg" class="img-responsive center-block" alt="Lumia">
										<div class="image-add-mod">
											<span class="btn btn-lightbox btn-default-color1 btn-sm">
												<i class="fa fa-search-plus fa-lg"></i>
											</span>
										</div>
									</a>
								</div>
								<div class="card-info">
									<div class="caption">
										<div class="name-item">
											<a class="product-name" href="product-details.html">Nokia Lumia 1320</a>
											<div class="rating">
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star"><i class="fa fa-star"></i></span>
												<span class="star star-empty"><i class="fa fa-star-o"></i></span>
												<div class="add-review">
													<span><span class="review-counter">4</span>Review(s)</span>
													<a href="#">Add Your Review</a>
												</div>
											</div>
										</div>
										<div class="card-price-block">
											<span class="price-title">Price</span>
											<span class="product-price">$180.00</span>
										</div>
										<div class="product-description">
											<p>A9 chip with 64-bit architecture, Ultrafast 4G LTE Advanced wireless, iOS9 with Touch
												ID5.5" Retina HD Display with 3D Touch, Fingerprint-resistant oleophobic coating
											</p>
										</div>
									</div>
									<div class="add-buttons">
										<button type="button" class="btn btn-add btn-add-compare"><i class="fa fa-refresh"></i></button>
										<button type="button" class="btn btn-add btn-add-wish"><i class="fa fa-heart-o"></i></button>
										<button type="button" class="btn btn-add btn-add-cart"><i class="fa fa-shopping-cart"></i></button>
										<div class="cart-add-buttons">
											<button type="button" class="btn btn-cart-color1"><i class="fa fa-shopping-cart"></i> add to cart</button>
										</div>
									</div>
								</div>
							</div>
						</div>--%>
                        <%=WishList %>
					</div>
					<%--<nav class="pagination-full clearfix">
						<ul class="pagination wow fadeInUp">
							<li><a href="#">1</a></li>
							<li><a href="#">2</a></li>
							<li><a href="#">3</a></li>
							<li><a href="#">4</a></li>
							<li><a href="#">5</a></li>
							<li class="disabled"><a href="#">...</a></li>
							<li><a href="#">26</a></li>
						</ul>
						<ul class="pagination pagination-add">
							<li>
								<a href="#" aria-label="Previous">Previous</a>
							</li>
							<li>
								<a href="#" aria-label="Next">Next</a>
							</li>
						</ul>
					</nav>--%>
				</div>
			</div>
        </div>
    </div>
</asp:Content>
