<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BrandList.aspx.cs" Inherits="Shop.ProductList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section-home home-3">
        <div class="b-hr-mod3">	
		</div>
		<div class="b-filter-smart container-fluid">
			<div class="row" id="Hot" runat="server">
			</div>
		</div>
        <div class="b-featured">
			<div class="container">
				<div class="row">
					<div class="col-xs-12 col-sm-12 col-md-12 col-lg-12" style="">
						<h3 class="heading-line-long">最畅销</h3>
						<div class="custom-nav-mod">
							<div class="slider-nav">
								<a class="slider-prev bestsellers-prev"><i class="fa fa-chevron-left"></i></a>
								<span class="nav-divider"></span>
								<a class="slider-next bestsellers-next"><i class="fa fa-chevron-right"></i></a>
							</div>
						</div>
					</div>
					<div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
						<div class="row">
							<div id="HotComm" runat="server" class="b-related bestseller-home wow fadeInUp enable-owl-carousel" data-loop="true" data-auto-width="false" data-dots="false" data-nav="false" data-margin="0" data-responsive-class="true" data-responsive='{"0":{"items":1},"479":{"items":2},"768":{"items":3},"1199":{"items":4}}' data-slider-next=".bestsellers-next" data-slider-prev=".bestsellers-prev">
							</div>
						</div>
					</div>
				</div>
				<div class="row">
					<div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
						<h3 class="heading-line-long">最新到货</h3>
						<div class="custom-nav-mod">
							<div class="slider-nav">
								<a class="slider-prev latest-prev"><i class="fa fa-chevron-left"></i></a>
								<span class="nav-divider"></span>
								<a class="slider-next latest-next"><i class="fa fa-chevron-right"></i></a>
							</div>
						</div>
					</div>
					<div class="col-xs-12 col-sm-12 col-md-12 col-lg-12">
						<div class="row">
							<div id="NewComm" runat="server" class="b-related latest-home wow fadeInUp enable-owl-carousel" data-loop="true" data-auto-width="false" data-dots="false" data-nav="false" data-margin="0" data-responsive-class="true" data-responsive='{"0":{"items":1},"479":{"items":2},"768":{"items":3},"1199":{"items":4}}' data-slider-next=".latest-next" data-slider-prev=".latest-prev">
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
    </section>
</asp:Content>
