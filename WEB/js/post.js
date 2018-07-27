//显示全部蛋糕
function cakePost() {
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '2'},// key=2 全部商品
                success: function (result) {
                    var goodss = eval('(' + result + ')');
                    var count1 = goodss.count1;  //获取蛋糕的数量
                    for (var i = 0; i < count1; i++) {
                        var goodsId = goodss.data1[i].goodsId;           //获取到商品ID
                        var goodsName = goodss.data1[i].goodsName;        //获取到商品名字
                        var price = goodss.data1[i].price;            //获取到价格     double类型
                        var str11="<div class=\"col-xs-6 col-sm-4 product-item\"><a href=\"goods.html?id=";
                        var str12=goodsId+"\"  target=\"_blank\" ><img class=\"lazy img-responsive\" width=\"397\" height=\"397\" src=\"";
                        var str1=str11+str12;
                        var strImgUrl="img/"+goodsId+"_main.jpg";
                        var str2="\" style=\"display: block;\"><div class=\"item-tit\"><h3 class=\"pro-tit\"><b>";
                        var strGoodsName=goodsName;
                        var str3="</b></h3><span class=\"price\"><em class=\"text-success\">";
                        var strPrice="￥"+price;
                        var str4="</em></span></div></a></div>";
                        var strAll=str1+strImgUrl+str2+strGoodsName+str3+strPrice+str4;
                        document.getElementById("displayAllGoods").innerHTML+=strAll;
                    }
                },
                error: function () {
                    showMessageBox("cakePost error");
                }
            });
}

//显示全部面包
function breadPost() {
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '2'},// key=2 全部商品
                success: function (result) {
                    var goodss = eval('(' + result + ')');
                    var count2 = goodss.count2;  //获取面包的数量
                    for (var i = 0; i < count2; i++) {
                        var goodsId = goodss.data2[i].goodsId;           //获取到商品ID
                        var goodsName = goodss.data2[i].goodsName;        //获取到商品名字
                        var price = goodss.data2[i].price;            //获取到价格     double类型
                        var str11="<div class=\"col-xs-6 col-sm-4 product-item\"><a href=\"goods.html?id=";
                        var str12=goodsId+"\"  target=\"_blank\" ><img class=\"lazy img-responsive\" width=\"397\" height=\"397\" src=\"";
                        var str1=str11+str12;
                        var strImgUrl="img/"+goodsId+"_main.jpg";
                        var str2="\" style=\"display: block;\"><div class=\"item-tit\"><h3 class=\"pro-tit\"><b>";
                        var strGoodsName=goodsName;
                        var str3="</b></h3><span class=\"price\"><em class=\"text-success\">";
                        var strPrice="￥"+price;
                        var str4="</em></span></div></a></div>";
                        var strAll=str1+strImgUrl+str2+strGoodsName+str3+strPrice+str4;
                        document.getElementById("displayAllGoods").innerHTML+=strAll;
                    }
                },
                error: function () {
                    showMessageBox("breadPost error");
                }
            });
}

//显示全部点心
function pastryPost() {
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '2'},// key=2 全部商品
                success: function (result) {
                    var goodss = eval('(' + result + ')');
                    var count3 = goodss.count3;  //获取点心的数量
                    for (var i = 0; i < count3; i++) {
                        var goodsId = goodss.data3[i].goodsId;           //获取到商品ID
                        var goodsName = goodss.data3[i].goodsName;        //获取到商品名字
                        var price = goodss.data3[i].price;            //获取到价格     double类型
                        var str11="<div class=\"col-xs-6 col-sm-4 product-item\"><a href=\"goods.html?id=";
                        var str12=goodsId+"\"  target=\"_blank\" ><img class=\"lazy img-responsive\" width=\"397\" height=\"397\" src=\"";
                        var str1=str11+str12;
                        var strImgUrl="img/"+goodsId+"_main.jpg";
                        var str2="\" style=\"display: block;\"><div class=\"item-tit\"><h3 class=\"pro-tit\"><b>";
                        var strGoodsName=goodsName;
                        var str3="</b></h3><span class=\"price\"><em class=\"text-success\">";
                        var strPrice="￥"+price;
                        var str4="</em></span></div></a></div>";
                        var strAll=str1+strImgUrl+str2+strGoodsName+str3+strPrice+str4;
                        document.getElementById("displayAllGoods").innerHTML+=strAll;
                    }
                },
                error: function () {
                    showMessageBox("pastryPost error");
                }
            });
}


//根据id填充goods.html
function goodsPost() {
            var id = window.location.href.split("=")[1];//从url获取商品id
            if(id.length > 5){
            	id = id.split("#")[0];
            }
            	
            var idFirst=parseInt(parseInt(id)/10000);
            if (idFirst==1) {
		      document.getElementById("showType").innerHTML="蛋糕";
		      document.getElementById("goodsTitle").innerHTML="<h class=\"type\"><span class=\"eng\">CAKE</span><i class=\"cutline\">/</i> <i class=\"name\">蛋糕</i> </h><br><h class=\"typeintro\">面包幻想将蛋糕与更多的情感元素和艺术气息联系并融合到一起。每一个装饰，每一件作品，都是匠人用真诚的心，用温暖的爱灌输而成，在温馨的现场烘焙下，幸福即刻体验。</h>";
		      document.getElementById("goodsTitle1").innerHTML="面包幻想将蛋糕与更多的情感元素和艺术气息联系并融合到一起。每一个装饰，每一件作品，都是匠人用真诚的心，用温暖的爱灌输而成，在温馨的现场烘焙下，幸福即刻体验。";
		      document.getElementById("goodsTitle2").innerHTML="面包幻想将蛋糕与更多的情感元素和艺术气息联系并融合到一起。每一个装饰，每一件作品，都是匠人用真诚的心，用温暖的爱灌输而成，在温馨的现场烘焙下，幸福即刻体验。";

		  	}
		  	else if (idFirst==2) {
		      document.getElementById("showType").innerHTML="面包";
		      document.getElementById("goodsTitle").innerHTML="<h class=\"type\"><span class=\"eng\">BREAD</span><i class=\"cutline\">/</i> <i class=\"name\">面包</i> </h><br><h class=\"typeintro\">面包幻想将面包与更多的营养元素和自然滋味联系并融合到一起。取之天然的优质食材，配合 “低糖、低油、低 盐”三低天然烘焙，在面包幻想的精心编织下,演绎着面包的自然味道。</h>";
		      document.getElementById("goodsTitle1").innerHTML="面包幻想将面包与更多的营养元素和自然滋味联系并融合到一起。取之天然的优质食材，配合 “低糖、低油、低 盐”三低天然烘焙，在面包幻想的精心编织下,演绎着面包的自然味道。";
		      document.getElementById("goodsTitle2").innerHTML="面包幻想将面包与更多的营养元素和自然滋味联系并融合到一起。取之天然的优质食材，配合 “低糖、低油、低 盐”三低天然烘焙，在面包幻想的精心编织下,演绎着面包的自然味道。";

		  	}
		  	else if (idFirst==3) {
		      document.getElementById("showType").innerHTML="点心";
		      document.getElementById("goodsTitle").innerHTML="<h class=\"type\"><span class=\"eng\">PASTRY</span><i class=\"cutline\">/</i> <i class=\"name\">点心</i> </h><br><h class=\"typeintro\">面包幻想将点心与更多的美味元素和地域文化联系并融合到一起。冲破地域的局限，精选各地优质原料，打造异地特色点心，在大师的精心制作下，成就一场美味与文化并重的人文盛宴。</h>";
		      document.getElementById("goodsTitle1").innerHTML="面包幻想将点心与更多的美味元素和地域文化联系并融合到一起。冲破地域的局限，精选各地优质原料，打造异地特色点心，在大师的精心制作下，成就一场美味与文化并重的人文盛宴。";
		      document.getElementById("goodsTitle2").innerHTML="面包幻想将点心与更多的美味元素和地域文化联系并融合到一起。冲破地域的局限，精选各地优质原料，打造异地特色点心，在大师的精心制作下，成就一场美味与文化并重的人文盛宴。";
		  	}
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '3', ID: id },//key=3 获取单个商品详情
                success: function (result) {
                    var goods = eval('(' + result + ')');
                    var goodsName = goods.goodsName;        //获取到商品名字
                    var goodsId = goods.goodsId;           //获取到商品ID
                    var batching = goods.batching;         //获取到配料
                    var introduce = goods.introduce;        //获取到介绍
                    var toBadTime = goods.toBadTime;        //获取到保质期
                    var price = goods.price;//获取到价格     double类型
                	document.getElementById("goodsImage_main").src="img/"+id+"_main.jpg";
				  	document.getElementById("goodsImage_1").src="img/"+id+"_1.jpg";
				  	document.getElementById("goodsImage_2").src="img/"+id+"_2.jpg";
				  	document.getElementById("goodsImage_3").src="img/"+id+"_3.jpg";
				  	document.getElementById("goodsImage_4").src="img/"+id+"_4.jpg";
                    document.getElementById("showTitle").innerHTML+=goodsName;
				  	document.getElementById("showGoodsName").innerHTML=goodsName;
				  	document.getElementById("showBatching").innerHTML="配料："+batching;
				  	document.getElementById("showToBadTime").innerHTML=toBadTime;
				  	document.getElementById("showToBadTime1").innerHTML=toBadTime;
				  	document.getElementById("showGoodsId").innerHTML=id;
				  	document.getElementById("showIntroduce").innerHTML="介绍："+introduce;
				  	document.getElementById("showPrice").innerHTML=price;
                },
                error: function () {
                    showMessageBox("goodsPost error");
                }
            });
}


function userPost() {
            var id = window.location.href.split("=")[1];//从url获取用户id
            alert("用户id："+id);
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '1', ID: id },// key= 1获取单个用户全部信息
                success: function (result) {
                    var user = eval('(' + result + ')');
                    var userId = user.userId;           //获取到ID
                    var userPassWord=user.passWord;
                    var userType=user.type;
                    var userNickName = user.nickName;
                    var userBithday = user.birthday;
                    var userAddress=user.address;
                    var userPhone=user.phone;
                    var userSex=user.sex;
                },
                error: function () {
                    showMessageBox("userPost error");
                }
            });
}


function orderPost() {
            var id = $.cookie("userId"); // 从cookie获取用户id
            //判断是否登录
            if(id==null){
            	showLoginMessageBox();
                //showMessageBox("请先登录！");
                //window.history.back();  //返回上一页
            }
            document.getElementById("list1").innerHTML="";
            document.getElementById("list2").innerHTML="";
            document.getElementById("list3").innerHTML="";
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '4', ID: id },// key= 4获取订单
                success: function (result) {
                    var order = eval('(' + result + ')');
                    var orderCount=order.length;//
                    for (i=0;i<orderCount;i++) {
                        var orderId=order[i].orderId;
                        var goodsNum=order[i].goodsNum;
                        var userName=order[i].userName;
                        var userId=order[i].userId;
                        var goodsId=order[i].goodsId;
                        var address=order[i].address;
                        var provValue=address.split("*")[0];
                        var cityValue=address.split("*")[1];
                        var areaValue=address.split("*")[2];
                        var lastAddressValue=address.split("*")[3];//分割地址
                        var phone=order[i].phone;
                        var price=order[i].price;
                        var goodsName=order[i].goodsName;
                        var flag=order[i].flag;
                        if (flag==0) {
                            document.getElementById("list1").innerHTML+="<div class=\"list\"><div class=\"id\">"+orderId+"</div><div class=\"name\"><img src=\"img/"+goodsId+"_main.jpg\">"+goodsName+"</div><div class=\"num\">"+goodsNum+"</div><div class=\"price\">￥"+price+"</div></div>";
                            
                        }
                        else if(flag==1){
                            document.getElementById("list2").innerHTML+="<div class=\"list\"><div class=\"id\">"+orderId+"</div><div class=\"name\"><img src=\"img/"+goodsId+"_main.jpg\">"+goodsName+"</div><div class=\"num\">"+goodsNum+"</div><div class=\"price\">￥"+price+"</div><button onclick=\"receive("+orderId+")\">确认收货</button></div>";

                        }
                        else if(flag==2){
                            document.getElementById("list3").innerHTML+="<div class=\"list\"><div class=\"id\">"+orderId+"</div><div class=\"name\"><img src=\"img/"+goodsId+"_main.jpg\">"+goodsName+"</div><div class=\"num\">"+goodsNum+"</div><div class=\"price\">￥"+price+"</div></div>";

                        }
                    }
                },
                error: function () {
                    showMessageBox("orderPost error");
                }
            });
}
//收货
function receive(orderId){
    $.ajax({
        type: 'post',
        url: 'Handler.ashx',
        async: true,
        data: { KEY: '8', ID: orderId},// key= 8改变订单状态
        success: function (result) {
            if(result != "f"){
                showMessageBox("收货成功！");
                //alert("收货成功！");
                orderPost();
            }
            else{
                showMessageBox("收货失败,请检查后重试！");
                //alert("收货失败！");
            }
        },
        error: function () {
            showMessageBox("userPost error");
        }
    });
}




function toFixed(va){
	var t = parseInt(parseFloat(va)*100);
	return parseFloat(t)/100;
}
function openWindow(){
    var id = $.cookie("userId"); // 获得cookie
    //判断是否登录
    if(id==null){
        showLoginMessageBox();
    }
    else{
        document.getElementById('fade').style.display='block';//设置样式表
        document.getElementById('confirmOrder').style.display='block';  
    }
    document.getElementById("price").innerHTML=$("#showPrice").text();//获取价格
    document.getElementById("goodsNum").value=1;//设置默认数量为1
    //增加
    $("#add").click(function() {
        var num = parseInt($("#goodsNum").val()) || 0;
        var price=parseFloat($("#showPrice").text());
        num=num+1;
        $("#goodsNum").val(num);
        var temp = toFixed(num*price);
        document.getElementById("price").innerHTML= temp;
    });
    //减去
    $("#sub").click(function() {
        var num = parseInt($("#goodsNum").val()) || 0;
        var price=parseFloat($("#showPrice").text());
        num = num - 1;
        num = num < 1 ? 1 : num;
        $("#goodsNum").val(num);
        var temp = toFixed(num*price);
        document.getElementById("price").innerHTML= temp;
    }); 

    
    //alert("用户id："+id);
    $.ajax({
        type: 'post',
        url: 'Handler.ashx',
        async: true,
        data: { KEY: '1', ID: id },// key= 1获取单个用户全部信息
        success: function (result) {
            var user = eval('(' + result + ')');
            var userId = user.userId;           //获取到ID
            var userNickName = user.nickName;
            var userAddress=user.address;
            var userPhone=user.phone;
            document.getElementById("userName").value=userNickName;//填充用户名
            document.getElementById("phone").value=userPhone;//填充电话

            var selectProv = document.getElementById("prov");
            var selectCity = document.getElementById("city");
            var selectArea = document.getElementById("area");
            var provValue=userAddress.split("*")[0];
            var cityValue=userAddress.split("*")[1];
            var areaValue=userAddress.split("*")[2];
            var lastAddressValue=userAddress.split("*")[3];//分割地址

            selectProv.options[selectProv.selectedIndex].value = provValue;
            selectProv.options[selectProv.selectedIndex].innerHTML = provValue;

            selectCity.options[selectCity.selectedIndex].value = cityValue;
            selectCity.options[selectCity.selectedIndex].innerHTML = cityValue;

            selectArea.options[selectArea.selectedIndex].value = areaValue;
            selectArea.options[selectArea.selectedIndex].innerHTML = areaValue;//地址单选下拉列表

            document.getElementById("inputTextarea").value=lastAddressValue;//地址输入框

        },
        error: function () {
            showMessageBox("openWindow post error");
        }
    });
}





          //send,发送表单数据到服务器...
          function sendData() {
              var addressString = "";
              addressString += $("#prov").val() + "*" + $("#city").val() + "*" + $("#area").val() + "*" + $("#inputTextarea").val();
               
              $.ajax({
                  type: 'post',
                  url: 'Handler.ashx',
                  async: true,
                  data: { KEY: '7', goodsNum: $("#goodsNum").val(), price: $("#price").text(), userName:
                  $("#userName").val(), phone: $("#phone").val(), address: addressString, goodsId: $("#showGoodsId").text(),
                      goodsName: $("#showGoodsName").text()
                  },
                  success: function (result) {
                      if (result != "f") {
                          showS();
                      }
                      else {
                          showF();
                      }
                  },
                  error:function(){
                  		showError();
                  }
              });
          }
          function showS() {
              document.getElementById('confirmOrder').style.display = 'none';
              document.getElementById('fade').style.display = 'none';
              showMessageBox("下单成功,请耐心等待.");
              //alert("下单成功,请耐心等待.");
          }
          function showF() {
              showMessageBox("下单失败,请检查网络并刷新后重试.");
              //alert("下单失败,或需要重新提交.");
          }
          function showError() {
              showMessageBox("网络错误,请刷新后再试！");
              //alert("网络错误,请刷新后再试！");
          }

//显示提示框
function showMessageBox(showStr){
    $('#QMessageBox').dialogBox({
        title: '小提示：',
        hasClose: true,
        hasMask: true,
        width: 400,
        height: 200,
        effect: 'fall',
        content: '<h1 style="text-align:center">' +showStr+'</h1>'
    });
}
//带登录按钮的提示框
function showLoginMessageBox(){
    $('#QMessageBox').dialogBox({
        title: '小提示：',
        hasClose: true,
        hasMask: true,
		hasBtn: true,
		confirmValue: '登录',
		confirm: function(){
			window.location="login.aspx";
		},
		cancelValue: '取消',
        width: 400,
        height: 200,
        effect: 'fall',
        content: '<h1 style="text-align:center">请先登录.</h1>'
    });
}






