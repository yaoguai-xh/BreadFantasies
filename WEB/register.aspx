<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Web.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta charset="utf-8">
	<link rel="shortcut icon" href="img/icon.ico" type="image/x-icon">
	<link rel="stylesheet" type="text/css" href="css/registerPage.css">
	<script type="text/javascript" src="js/jquery-3.2.1.min.js"></script>
  	<script type="text/javascript" src="js/city2.js"></script>
  	<script type="text/javascript" src="js/myJavaScript.js"></script>
	<title>Register</title>
</head>
<body onload="showDay()">
	<div class="header">
    <img  id="Img1" style="width: 300px" src="pic/logo.png">
		<div >
			<p>欢迎注册！</p>
		</div>
	</div>
	
	<div class="container" align="center">
		<p id="p_container">用户注册</p>
		<form class="RegisterForm" onmousemove="CheckboxJudge()" runat="server">
					
					<div class="TextInput">
						<label><img src="img/phone.png" width="40px" height="40px" class="ImageIcon"></label>
						<input  type="text" id="phone" name="phone"  placeholder="请输入11位手机号码" maxlength="11"       onblur="phoneJudge()">
						<div class="hit" id="phoneHit"></div>
					</div>
					
					<div class="TextInput">
						<label><img src="img/account.png" width="40px" height="40px" class="ImageIcon"></label>
						<input type="text" id="userName" name="userName" placeholder="请取一个帅帅的昵称" maxlength="16" onblur="userNameJudge()">
						<div class="hit" id="userNameHit"></div>
					</div>
					
					<div class="TextInput">
						<label><img src="img/password.png" width="40px" height="40px" class="ImageIcon"></label>
						<input type="password" id="password1" name="password1" placeholder="请设置您的密码(9~16位)" maxlength="16" onkeyup="passwordJudge()">
						<div class="hit" id="password1Hit"></div>
					</div>
					
					<div class="TextInput">
						<label><img src="img/security.png" width="40px" height="40px" class="ImageIcon"></label>
						<input type="password" id="password2" name="password2" placeholder="请确认您的密码" maxlength="16" onkeyup="passwordJudge()">
						<div class="hit" id="password2Hit"></div>
					</div>
					
					
					<div id="chooseSex">
						<label><img src="img/sex.png" width="40px" height="40px" class="ImageIcon"></label>
						<div class="inputContainer">
							<input type="radio" value="none" name="sex" checked>保密
							<input type="radio" value="male" name="sex">男
							<input type="radio" value=female name="sex">女
						</div>
					</div>

					<div id="chooseBirth">
						<label><img src="img/birthday2.png" width="40px" height="40px" class="ImageIcon"></label>
						<div>
							<select id="year" name="year" onchange="showDay()">
									<option value="none">请选择年</option>
									<script language="javascript">									    //下拉列表———年
									    //获得当前系统时间;
									    var now = new Date();
									    var year = now.getFullYear();
									    //用一个方法循环输出年份;
									    for (i = year - 80; i <= year; i++) {
									        if (i == year - 20) {
									            document.write("<option  value=" + i + ">" + i + "</option>");
									        } else {
									            document.write("<option value=" + i + ">" + i + "</option>");
									        }
									    }
								    </script>
							</select>
							<select id="month" name="month" onchange="showDay()">
									<option value="none">请选择月</option>
									<script type="text/javascript">									    //下拉列表———月
									    //添加12个月
									    for (j = 1; j <= 12; j++) {
									        document.write("<option value=" + j + ">" + j + "</option>");
									    }
								    </script>
							</select>
							<select name="days" id="days"></select>
						</div>
					</div>
					<div class="lastHit" id="chooseBirthHit"></div>

					<div id="selectAddress">
						<label><img src="img/area.png" width="40px" height="40px" class="ImageIcon"></label>
						<div>
							<select class="province" id="prov" name="province"></select>
							<select class="citys" id="city" name="citys"></select>
							<select class="district" id="area" name="district"></select>
						</div>
					</div>
					<div class="lastHit" id="selectAddressHit"></div>
							<script type="text/javascript">
							    //新建一个CitySelect
							    var selectVa1 = new CitySelect({
							        data: data,
							        provId: "#prov",
							        cityId: '#city',
							        areaId: '#area',
							        isSelect: false
							    });
							</script>
					

					<div id="inputAddress">
						<label><img src="img/local.png" width="40px" height="40px" class="ImageIcon"></label>
						<div>
							<label id="p_textarea">详细地址</label>
							<label><textarea  id="inputTextarea" name="lastAdress" cols="23" rows="2"  title="请输入详细地址"></textarea></label>
						</div>
					</div>
					<div class="lastHit" id="inputAddressHit"></div>
					
					
					<div id="chooseAgreement">
						<input type="checkbox" id="checkboxAgreement" name="agree">
						<label for="checkboxAgreement" id="checkboxAgreementLabel">
								阅读并同意《
								<a href = "javascript:void(0)"  id="checkboxAgreementLink" onclick = "document.getElementById('userAgreement').style.display='block';document.getElementById('fade').style.display='block'">用户协议</a>
								》
						</label>
					</div>
					<div class="lastHit" id="lastHit"></div>

					<div id="userAgreement" class="white_content">
						<div>
							<h1 align="center">《用户服务条款》</h1>
							<br/>
							<p class="p_userAgreement">&nbsp;&nbsp;(1) 遵守中国有关法律法规的规定。</P>
							<p class="p_userAgreement">&nbsp;&nbsp;(2) 不利用服务作非法用途。</P>
							<p class="p_userAgreement">&nbsp;&nbsp;(3) 不干扰服务的正常进行。</P>
							<p class="p_userAgreement">&nbsp;&nbsp;(4) 遵守所有与使用服务有关的网络协议、规定、程序和惯例。</P>
							<p class="p_userAgreement">&nbsp;&nbsp;(5)不得以任何形式侵犯面包幻想的知识产权。您违反本协议<br/>&nbsp;&nbsp;的约定导致我站或他人损失的，应承担赔偿责任。
							</P>
							
							<input type="button" value="关闭"   id="closeWindow" href = "javascript:void(0)" onclick = "document.getElementById('userAgreement').style.display='none';document.getElementById('fade').style.display='none'">
						</div>
				        	
					</div> 
				    <div id="fade" class="black_overlay"></div>
                    <asp:Button ID="btnRegsiter" runat="server" Text="点击注册" 
                        onclick="btnRegsiter_Click"/>
					<!--<input type="submit" id="btnRegsiter" name="btnRegsiter" value="点击注册"></input>-->
		</form>
	</div>
</body>
</html>
