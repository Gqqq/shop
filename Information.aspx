<%@ Page Title="" Language="C#" MasterPageFile="~/Son.master" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="Shop.Information" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="user-info">
	    <!--标题 -->
	    <div class="am-cf am-padding">
		    <div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">个人资料</strong> / <small>Personal&nbsp;information</small></div>
	    </div>
	    <hr/>
	    <!--个人信息 -->
	    <div class="info-main" style="width:100%">
		    <div class="am-form am-form-horizontal">
			    <div class="am-form-group">
				    <label for="user-name2" class="am-form-label">昵称：</label>
                    <div class="col-sm-6" style="display:none">
					    <input type="text" class="form-control" id="Username" runat="server" ClientIDMode="Static"  placeholder="">
				    </div>
				    <label for="female2" class="change" id="lname"  style="line-height:38px; padding-left:20px;"><%=name %></label>
			    </div>
			    <%--<div class="am-form-group">
				    <label class="am-form-label">性别：</label>
				    <div class="f-left styled-radio" style="padding-left:20px">
					    <div class="radio radio2">
						    <input id="male2" name="gender2" value="male2" type="radio">
						    <label for="male2">男</label>
					    </div>
					    <div class="radio radio2">
						    <input id="female2" name="gender2" value="female2" checked="" type="radio">
						    <label for="female2">女</label>
					    </div>
				    </div>
			    </div>--%>
			    <div class="am-form-group">
				    <label for="user-phone" class="am-form-label">电话：</label>
                    <div class="col-sm-6" style="display:none">
					    <input type="text" class="form-control" id="Phone"  runat="server" ClientIDMode="Static">
				    </div>
				    <label for="female2" class="change" id="lphone" style="line-height:38px; padding-left:20px;"><%=phonenumber %></label>
			    </div>
			    <div class="am-form-group">
				    <label for="user-email" class="am-form-label">电子邮件：</label>
                    <div class="col-sm-6" style="display:none">
					    <input type="text" class="form-control" id="Email" ClientIDMode="Static" runat="server">
				    </div>
				    <label for="female2" class="change" id="lemail" style="line-height:38px; padding-left:20px;"><%=email %></label>
			    </div>
			    <div class="am-form-group">
				    <label for="user-name" class="am-form-label">创建日期：</label>
				    <label for="female2"  style="line-height:38px; padding-left:20px;"><%=regtime %></label>
			    </div>
                <div style="width:126px; margin:0 auto; display:block"><button type="button" class="btn btn-primary-color2 btn-sm" id="Update">保存修改</button></div>
		    </div>
            <script>
                $('.change').click(function () {
                    that = this;
                    that.style.display='none'
                    var lin = that.previousElementSibling;
                    lin.style.display = 'block';
                }),
                $('#Update').click(function () {
                    var uname = document.getElementById('Username').value;
                    var phone = document.getElementById('Phone').value;
                    var email = document.getElementById('Email').value;
                   
                    var lname = $('#lname').text();
                    var lphone = $('#lphone').text();
                    var lemail = $('#lemail').text();
                    
                    $.ajax({
                        url: 'ashx/User.ashx',
                        type: 'POST',
                        data: {
                            action:'UpInfo',
                            username: uname,
                            userphone:phone,
                            useremail: email,
                            labname: lname,
                            labphone: lphone,
                            labemail:lemail
                        }
                    }).done(function (res) {
                        if (res == "修改成功了") {
                            alert(res + "\n由于用户名已变更，重新登陆");
                            location.href = 'Log.aspx';
                        }
                        else {
                            alert(res);
                            history.go(0)
                        }

                    }).error(function () {
                        alert(res);
                        history.go(0);
                    })
                })
            </script>
	    </div>
    </div>
</asp:Content>
