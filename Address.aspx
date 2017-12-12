<%@ Page Title="" Language="C#" MasterPageFile="~/Son.master" AutoEventWireup="true" CodeBehind="Address.aspx.cs" Inherits="Shop.Address" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/js/jquery.min.js" type="text/javascript"></script>
	<script src="/js/amazeui.js"></script>
    <script type="text/javascript">
            $(function () {
                $('a[name=delAddress]').click(function () {
                    var that = this;
                    $.ajax(
                        {
                            url: 'ashx/AddressHandler.ashx',
                            type: 'POST',
                            data: {
                                action: "del",
                                id: $(that).data('id'),
                                name: $(that).data('name')
                            }
                        }).done(function (res) {
                            if (res === '200') {
                                $(that).parents('li').remove();
                            }
                            else {
                                alert("删除失败");
                            }
                        }).error(function () {
                            alert("发生错误");
                        })
                })

            })

            $(function () {
                $('a[name=Moren]').click(function () {
                    var that = this;
                    $.ajax(
                        {
                            url: 'ashx/AddressHandler.ashx',
                            type: 'POST',
                            data: { action: "update", id: $(that).data('id'), name: $(that).data('name') }
                        }).done(function (res) {
                            if (res === '200') {
                                
                            }
                            else {
                                alert("设为默认地址失败");
                            }
                        }).error(function () {
                            alert("发生错误");
                        })
                })

            })
      </script>
	<div class="user-address">
		<!--标题 -->
		<div class="am-cf am-padding">
			<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">地址管理</strong> / <small>Address&nbsp;list</small></div>
		</div>
		<hr/>
		<ul class="am-avg-sm-1 am-avg-md-3 am-thumbnails" id="GetAddress" runat="server">

		</ul>
		<div class="clear"></div>
		<a class="new-abtn-type" data-am-modal="{target: '#doc-modal-1', closeViaDimmer: 0}">添加新地址</a>
		<!--例子-->
		<div class="am-modal am-modal-no-btn" id="doc-modal-1">
			<div class="add-dress">
				<!--标题 -->
				<div class="am-cf am-padding">
					<div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">新增地址</strong> / <small>Add&nbsp;address</small></div>
				</div>
				<hr/>
				<div class="am-u-md-12 am-u-lg-8" style="margin-top: 20px;">
					<form class="am-form am-form-horizontal" runat="server">
						<div class="am-form-group">
							<label for="user-name" class="am-form-label">收货人</label>
							<div class="am-form-content">
								<input type="text" id="username" placeholder="收货人" runat="server" ClientMode="Static"/>
							</div>
						</div>
						<div class="am-form-group">
							<label for="user-phone" class="am-form-label">手机号码</label>
							<div class="am-form-content">
								<input id="userphone" placeholder="手机号必填" type="text" runat="server" ClientMode="Static"/>
							</div>
						</div>
						<div class="am-form-group">
							<label for="user-address" class="am-form-label">所在地</label>
							<div class="am-form-content address">
								<select id="province" runat="server" ClientMode="Static">
									<option value="河南省">河南省</option>
									<option value="湖北省" selected>湖北省</option>
								</select>
                                
								<select  id="city" runat="server" ClientMode="Static">
									<option value="信阳市">信阳市</option>
                                    <option value="郑州市">郑州市</option>
									<option value="武汉市" selected>武汉市</option>
								</select>
								<select id="county" runat="server" ClientMode="Static">
									<option value="金山区">金山区</option>
									<option value="洪山区" selected>洪山区</option>
								</select>
							</div>
						</div>
						<div class="am-form-group">
							<label for="user-intro" class="am-form-label">详细地址</label>
							<div class="am-form-content">
								<textarea class="" rows="3" id="details" runat="server" ClientMode="Static" placeholder="输入详细地址"></textarea>
								<small>100字以内写出你的详细地址...</small>
							</div>
						</div>
						<div class="am-form-group">
							<div class="am-u-sm-9 am-u-sm-push-3">
								<input class="am-btn am-btn-danger" type="button" value="保存" id="Add" onserverclick="Add_ServerClick" runat="server"/>
								<a href="javascript: void(0)" class="am-close am-btn am-btn-danger" data-am-modal-close>取消</a>
							</div>
						</div>
					</form>
				</div>
			</div>
		</div>
	</div>
	<script type="text/javascript">
		$(document).ready(function() {							
			$(".new-option-r").click(function() {
				$(this).parent('.user-addresslist').addClass("defaultAddr").siblings().removeClass("defaultAddr");
			});
							
			var $ww = $(window).width();
			if($ww>640) {
				$("#doc-modal-1").removeClass("am-modal am-modal-no-btn")
			}
							
		})
	</script>
	<div class="clear"></div>
</asp:Content>
