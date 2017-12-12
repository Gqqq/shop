<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="Shop.Logo" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>韩都衣舍-登陆</title>
<meta name="viewport" content="width=device-width, initial-scale=1"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<!-- Custom Theme files -->
<link href="css/logstyle.css" rel="stylesheet" type="text/css" media="all" />
<!-- //Custom Theme files -->
<!-- web font -->
<%--<link href='//fonts.googleapis.com/css?family=Text+Me+One' rel='stylesheet' type='text/css'>--%>
<!-- //web font -->
<!-- js -->
<script src="js/jquery.min.js"></script>
<script src="js/easyResponsiveTabs.js" type="text/javascript"></script>
<script type="text/javascript">
    $(document).ready(function () {
	    $('#horizontalTab').easyResponsiveTabs({
		    type: 'default', //Types: default, vertical, accordion           
		    width: 'auto', //auto or any width like 600px
		    fit: true   // 100% fit in a container
	    });
    });
</script>
<!-- //js -->    
</head>
<body>
<!-- main -->
<div class="main">
    <h1>韩都衣舍</h1>
	<div class="main-info">
		<div class="sap_tabs">
			<div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
				<ul class="resp-tabs-list">
					<li class="resp-tab-item" aria-controls="tab_item-0"><h2><span>登陆</span></h2></li>
					<li class="resp-tab-item" aria-controls="tab_item-1"><span>注册</span></li> 
				</ul>	
				<div class="clear"> </div>	
				<div class="resp-tabs-container">
					<div class="tab-1 resp-tab-content" aria-labelledby="tab_item-0">
						<div class="agileits-login">
                            <form method="post" runat="server">
							    <input type="text" class="uname" name="Uname" placeholder="账号" value="" id="uname" runat="server" clientidmode="Static" required="required" onblur="dis('btn1')"/>
							    <input type="password" class="password" name="Password" id="pass" runat="server" clientidmode="Static" placeholder="密码" required="required" onmousemove="dis('btn1')"/>
							    <div class="wthree-text" style="line-height:3;"> 
								    <ul style="clear:both"> 
									    <li><a href="index.aspx">暂不登录</a></li>
									    <li> <a href="#">忘记密码?</a> </li>
								    </ul>
							    </div>  
							    <div class="w3ls-submit">
								    <div class="submit-text" style="display:none">
									    <input type="submit" runat="server" id="btn1" value="登陆" onserverclick="btn1_ServerClick"/> 
								    </div>	
							    </div>
                            </form>	
						</div> 
					</div>
					<div class="tab-1 resp-tab-content" aria-labelledby="tab_item-1">
						<div class="login-top sign-top">
							<div class="agileits-login">
								<form id="form2">
									<input type="text" name="user" placeholder="用户名" id="user" required="" onblur="dis('btn2')"/>
									<input type="password" class="password" name="pwd" id="pwd" placeholder="密码" required="" onblur="dis('btn2')"/>
                                    <input type="password" class="password" name="repwd" id="repwd" placeholder="确认密码" required="" onblur="dis('btn2')"/>
                                    <input type="text" class="phone" name="Phone" id="phone" placeholder="手机" required="" onblur="dis('btn2')"/>
                                    <input type="text" class="email" name="Email" id="email" placeholder="邮箱" required="" onmousemove="dis('btn2')"/>											 
									<div class="w3ls-submit">
										<div class="submit-text" style="display:none">
											<input type="button" class="register" name="ok" id="btn2" value="注册" />
                                            <input type="reset" id="reset" style="display:none" />
										</div>	
									</div>
								</form> 
							</div>  
						</div>
					</div>
				</div>	
			</div>
		</div>  
	</div>
</div>	
<!-- //main --> 
<script type="text/javascript">
    function dis(btn){
        var button = document.getElementById(btn);
        if (btn == "btn1"){
            var uname = document.getElementById('uname').value;
            var pass = document.getElementById('pass').value;
            if (uname != "" && pass != "" ){
                button.parentNode.style.display = "inline-block";
            }else{
                button.parentNode.style.display = "none";
            }
        }
        if (btn=="btn2"){
            var user = document.getElementById('user').value;
            var pwd = document.getElementById('pwd').value;
            var phone = document.getElementById('phone').value;
            var email = document.getElementById('email').value;
            if (user != "" && pwd != "" && phone != "" && email != ""){
                button.parentNode.style.display = "inline-block";
            }else {
                button.parentNode.style.display = "none";
            }
        }
    }
</script>
<script>
		$(function () {
		    $('input[id=btn2]').click(function () {
		        if ($("input[id=pwd]").val() != $("input[id=repwd]").val()) {
		            alert("两次密码不相同，请重新输入");
		            document.getElementById("pwd").value = "";
		            document.getElementById("repwd").value = "";
		            return;
		        }
		        if ($("#phone").val().length != 11) {
		            alert("手机格式不正确");
		            document.getElementById("phone").value = "";
		            return;
		        }
		        var em = $("#email").val();
		        if (em.indexOf("@") < 1 || (em.indexOf(".")== -1)|| (em.lastIndexOf(".") - em.indexOf("@") < 2)) {
		            alert("邮箱格式不正确")
		            return;
		        }
				$.ajax({
					url: 'ashx/RegHandler.ashx',
					type: 'POST',
					data:$('#form2').serialize()
				}).done(function (res) {
				    if (res === '200'){
				        alert("注册成功");
				        $("#reset").click();
				    }
				    else if (res == '400'){
				        alert('该昵称已被占用');
				        document.getElementById("user").value = "";
				    }
				    else
				        alert("注册失败")
				}).error(function () {
					alert("出现错误")
				})
		    })
		})
	</script>
</body>
</html>
