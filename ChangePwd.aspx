<%@ Page Title="" Language="C#" MasterPageFile="~/Son.master" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="Shop.ChangePwd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="user-info">
	    <!--标题 -->
	    <div class="am-cf am-padding">
		    <div class="am-fl am-cf"><strong class="am-text-danger am-text-lg">修改密码</strong> / <small>Personal&nbsp;information</small></div>
	    </div>
	    <hr/>
	    <!--个人信息 -->
	    <div class="info-main" style="width:100%">
		    <div class="am-form am-form-horizontal">
			    <div class="am-form-group">
				    <label for="user-name2" class="am-form-label">原密码：</label>
                    <div class="col-sm-6">
					    <input type="text" class="form-control" id="yuan" runat="server" ClientIDMode="Static"  placeholder="">
				    </div>
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
				    <label for="user-phone" class="am-form-label">新密码：</label>
                    <div class="col-sm-6">
					    <input type="password" class="form-control" id="pwd"  runat="server" ClientIDMode="Static">
				    </div>
			    </div>
			    <div class="am-form-group">
				    <label for="user-email" class="am-form-label">确认密码：</label>
                    <div class="col-sm-6">
					    <input type="password" class="form-control" id="repwd" ClientIDMode="Static" runat="server">
				    </div>
			    </div>
                <div style="width:126px; margin:0 auto; display:block"><button type="button" class="btn btn-primary-color2 btn-sm" id="Update">保存修改</button></div>
		    </div>
            <script>
                $('#Update').click(function () {
                    var yuan = document.getElementById('yuan').value;
                    var pwd = document.getElementById('pwd').value;
                    var repwd = document.getElementById('repwd').value;

                    if (pwd!=repwd) {
                        alert("两次密码不相同，请重新输入");
                        $('#pwd').focus()
                    }

                    $.ajax({
                        url: 'ashx/User.ashx',
                        type: 'POST',
                        data: {
                            action:'UpPwd',
                            yuanpass: yuan,
                            newpass: pwd,
                        }
                    }).done(function (res) {
                        if (res == "修改成功") {
                            alert(res)
                            location.href = 'Information.aspx';
                        }
                        else {
                            alert(res);
                            history.go(0)
                        }

                    }).error(function () {
                        alert("发生错误");
                        history.go(0);
                    })
                })
            </script>
        </div>
    </div>
</asp:Content>
