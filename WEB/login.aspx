<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta charset="utf-8"/>
	<title>Login</title>
	<link rel="shortcut icon" href="img/icon.ico" type="image/x-icon"/>
	<link rel="stylesheet" type="text/css" href="css/loginPage.css"/>
	<script type="text/javascript" src="js/jquery-1.7.2.js"></script>
	<script type="text/javascript" src="js/jquery.poshytip.min.js"></script>
	<script type="text/javascript">	    //tip提示框代码
	    $(document).ready(function () {
	        $("#demo-basic").poshytip();
	        $("#demo-tip-darkgray").poshytip({
	            className: 'tip-darkgray',
	            bgImageFrameSize: 11,
	            offsetX: -25
	        });
	        $('#demo-tip-skyblue').poshytip({
	            className: 'tip-skyblue',
	            bgImageFrameSize: 9,
	            offsetX: 0,
	            offsetY: 20
	        });
	        $('#userIDInput').poshytip({
	            className: 'tip-darkgray',
	            showOn: 'focus',
	            alignTo: 'target',
	            alignX: 'right',
	            alignY: 'center',
	            offsetX: 5
	        });
	        $('#passwordInput').poshytip({
	            className: 'tip-darkgray',
	            showOn: 'focus',
	            alignTo: 'target',
	            alignX: 'right',
	            alignY: 'center',
	            offsetX: 5
	        });
	    });
	</script>
</head>
<body>
	<div class="header">
     <img id="logo" src="pic/logo.png"/>
		<div>
			<p>欢迎您的到来！</p>
		</div>
	</div>
	<div class="container">

		<div class="login">
			<p>用户登录</p>
			<div class="loginForm">
				<form runat="server">
					<div class="section" align="center">
					    <div class="tooltip">
					        <input id="userIDInput" name="userID" type="text" placeholder="请输入11位手机号" autocomplete='off' maxlength="11" title="请输入11位手机号">
					    </div>
					</div>
					<div class="section" align="center">
					    <div class="tooltip">
					        <input id="passwordInput" name="userPassword" type="password" placeholder="请输入密码" autocomplete='off' maxlength="16" title="请输入密码">
					    </div>
					</div>
                    <asp:CheckBox ID="checkboxInput" runat="server" name="remember" Text=""/>
					<!--<input type="checkbox" id="checkboxInput" name="remember"></input>-->
						<label for="checkboxInput" id="checkboxLable">记住登录状态</label>
					
					<asp:Button ID="submitInput" runat="server" Text="登录" 
                        onclick="submitInput_Click" />
					
					<!--<input type="submit"  id="submitInput" value="登录"></input>-->
					<div class="lastHit" id="lastHit"></div>
				</form>
			</div>
			<div class="linker">
				<a href="#" id="linkForget">忘记密码？</a>
				<a href="register.aspx" id="linkRegister">注册</a>
			</div>
		</div>
	</div>
</body>
</html>
