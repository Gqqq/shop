<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Shop.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section-home home-1">
        <section class="main-slider">
            <div class="slider-pro full-width-slider" id="main-slider" data-width="100%" data-height="570" data-fade="true" data-buttons="true" data-wait-for-layers="true" data-thumbnail-pointer="false" data-touch-swipe="false" data-autoplay="true" data-auto-scale-layers="true" data-visible-size="100%" data-force-size="fullWidth" data-autoplay-delay="5000">
                <div class="sp-slides"><%--Banner及漂浮其上的广告--%>
                    <div class="sp-slide">
                        <img class="sp-image" src="media/slides/bg.jpg"
                            data-src="media/slides/bg.jpg"
                            data-retina="media/slides/bg.jpg" alt="banner" />
                        <div class="sp-layer slider-discount"
                            data-horizontal="18.6%" data-vertical="22.5%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="400" data-hide-delay="200">
                            <span>25% OFF</span>
                        </div>
                        <div class="sp-layer slide-tex-1"
                            data-horizontal="18.6%" data-vertical="33.5%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="600" data-hide-delay="100">
                            <span>smartphones<br>
                                <span class="border-line">on sale</span></span>
                        </div>
                        <div class="sp-layer slider-text-2"
                            data-horizontal="18.7%" data-vertical="54.4%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="800">
                            more faster. more powerful<br>
                            & even more bigger
                        </div>
                        <div class="sp-layer"
                            data-horizontal="18.9%" data-vertical="68.7%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="1000">
                            <a class="btn btn-primary-color1 btn-sm" href="#">SHOP NOW</a>
                        </div>
                    </div>

                    <div class="sp-slide">
                        <img class="sp-image" src="media/slides/banner5.png"
                            data-src="media/slides/banner5.png"
                            data-retina="media/slides/banner5.png" alt="banner1" />
                        <%--<div class="sp-layer ls-text"
                            data-horizontal="14.8%" data-vertical="27.5%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="400" data-hide-delay="200">
                            <span>next is now</span>
                        </div>
                        <div class="sp-layer"
                            data-horizontal="15%" data-vertical="35.5%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="600" data-hide-delay="100">
                            <img src="media/slides/samsung.png" alt="samsung">
                        </div>
                        <div class="sp-layer"
                            data-horizontal="15%" data-vertical="41.7%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="800">
                            <img src="media/slides/galaxy.png" alt="samsung galaxy">
                        </div>
                        <div class="sp-layer text-highlight"
                            data-horizontal="15%" data-vertical="52%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="800">
                            <span class="highlight-primary">powerful. stunning. now even bigger</span>
                        </div>
                        <div class="sp-layer"
                            data-horizontal="15%" data-vertical="63.4%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="1000">
                            <button class="btn btn-default-color1 btn-sm" type="button">SHOP NOW</button>
                        </div>--%>
                    </div>

                    <div class="sp-slide">
                        <img class="sp-image" src="media/slides/banner6.png"
                            data-src="media/slides/banner6.png"
                            data-retina="media/slides/banner6.png" alt="banner3" />
                        <%--<div class="sp-layer s3-text"
                            data-horizontal="18.7%" data-vertical="22.3%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="400" data-hide-delay="200">
                            <span>microsoft</span>
                        </div>
                        <div class="sp-layer s3-name"
                            data-horizontal="18.4%" data-vertical="25%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="600" data-hide-delay="100">
                            <span>lumia</span>
                        </div>
                        <div class="sp-layer s3-discount"
                            data-horizontal="18.7%" data-vertical="36.4%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="800">
                            <span>smartphones<br>
                                10% OFF</span>
                        </div>
                        <div class="sp-layer s3-text2"
                            data-horizontal="18.7%" data-vertical="53%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="800">
                            <span>get discount on latest<br>
                                & the best tech</span>
                        </div>
                        <div class="sp-layer sl3"
                            data-horizontal="18.8%" data-vertical="69.4%"
                            data-show-transition="left" data-hide-transition="up" data-show-delay="1000">
                            <button class="btn btn-default-color1 btn-sm" type="button">SHOP NOW</button>
                        </div>--%>
                    </div>

                </div>
            </div>
        </section>
        <div class="b-featured">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12 col-sm-8 col-md-8 col-lg-8">
                        <div class="featured-holder row">
                            <div class="col-sm-12 wow fadeInUp">
                                <h3 class="heading-line-long">新品推荐</h3>
                            </div>
                            <div class="row">
                                <div class="b-related clearfix" id="ListProduct" runat="server">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12 col-sm-4 col-md-4 col-lg-4" id="HotProduct" runat="server">
					</div>
                </div>
            </div>
        </div>
        <div class="b-bestsellers">
            <div class="container">
                <div class="row">
                    <div class="col-sm-12">
                        <ul class="nav nav-tabs" role="tablist">
                            <li role="presentation" class="active">
                                <a class="heading-line-long" href="home-1.html#bybrand" aria-controls="bybrand" role="tab" data-toggle="tab">知名品牌</a>
                            </li>
                            <li role="presentation">
                                <a href="home-1.html#bestsellers" aria-controls="bestsellers" role="tab" data-toggle="tab">畅销产品</a>
                            </li>
                        </ul>
                        <div class="tab-content">
                            <div role="tabpanel" class="tab-pane active" id="bybrand">
                                <div class="row">
                                    <div class="col-sm-12">
                                        <div class="b-brand-filters">
                                            <div>
                                                <ul class="tags-buttons list-inline by-brands-buttons" id="Brand" runat="server">
                                                    <li>
                                                        <button data-filter="*" class="btn btn-tag active">全部</button>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="row" >
                                    <div class="b-related by-brands wow fadeInUp" style="max-height:980px; overflow:hidden" id="BrandComm" ClientIDMode="Static" runat="server"><%--品牌产品--%>
                                    </div>
                                </div>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="bestsellers" ><%--畅销产品--%>
                                <div class="row">
                                    <div class="b-related" id="hotComm" runat="server">
                                    </div>
                                </div>
                            </div><%--畅销产品--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    
</asp:Content>
