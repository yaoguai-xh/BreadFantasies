<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsShow.aspx.cs" Inherits="Web.GoodsShow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>梦想面包店</title>
    <script src="jQuery.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Post() {
            var id = "001";
            $.ajax({
                type: 'post',
                url: 'Handler.ashx',
                async: true,
                data: { KEY: '3', ID: id },
                success: function (result) {
                    var goods = eval('(' + result + ')');
                    var goodsId = goods.goodsId;           //获取到商品ID
                    var goodsName = goods.goodsName;        //获取到商品名字
                    var batching = goods.batching;         //获取到配料
                    var introduce = goods.introduce;        //获取到介绍
                    var toBadTime = goods.toBadTime;        //获取到保质期
                    var price = goods.price;            //获取到价格     double类型
                    var size = goods.size;             //获取到size,大号1、中号2、小号3   int类型
                },
                error: function () {
                    document.getElementById("labTest").innerHTML = "ERROR!";
                }
            });
        }
        function show2(result) {
            var goodss = eval('(' + result + ')');
            var str = "";

            var count1 = goodss.count1;  //获取蛋糕的数量
            for (var i = 0; i < count1; i++) {
                var goodsId = goodss.data1[i].goodsId;           //获取到商品ID
                var goodsName = goodss.data1[i].goodsName;        //获取到商品名字
                var batching = goodss.data1[i].batching;         //获取到配料
                var introduce = goodss.data1[i].introduce;        //获取到介绍
                var toBadTime = goodss.data1[i].toBadTime;        //获取到保质期
                var price = goodss.data1[i].price;            //获取到价格     double类型
                var size = goodss.data1[i].size;             //获取到size,大号1、中号2、小号3   int类型
                if (str == "")
                    str += "<br/>";
                str += "蛋糕：<br/>goodsId:" + goodsId;
                str += "<br/>goodsName:" + goodsName;
                str += "<br/>batching:" + batching;
                str += "<br/>introduce:" + introduce;
                str += "<br/>toBadTime:" + toBadTime;
                str += "<br/>price:" + price;
                str += "<br/>size:" + size;
                str += "<br/><br/>";
            }
            var count2 = goodss.count2;  //获取面包的数量
            for (var i = 0; i < count2; i++) {
                var goodsId = goodss.data2[i].goodsId;           //获取到商品ID
                var goodsName = goodss.data2[i].goodsName;        //获取到商品名字
                var batching = goodss.data2[i].batching;         //获取到配料
                var introduce = goodss.data2[i].introduce;        //获取到介绍
                var toBadTime = goodss.data2[i].toBadTime;        //获取到保质期
                var price = goodss.data2[i].price;            //获取到价格     double类型
                var size = goodss.data2[i].size;             //获取到size,大号1、中号2、小号3   int类型

                if (str == "")
                    str += "<br/>";
                str += "面包：<br/>goodsId:";
                str += goodsId;
                str += "<br/>goodsName:" + goodsName;
                str += "<br/>batching:" + batching;
                str += "<br/>introduce:" + introduce;
                str += "<br/>toBadTime:" + toBadTime;
                str += "<br/>price:" + price;
                str += "<br/>size:" + size;
                str += "<br/><br/>";
            }
            var count3 = goodss.count3;  //获取点心的数量
            for (var i = 0; i < count3; i++) {
                var goodsId = goodss.data3[i].goodsId;           //获取到商品ID
                var goodsName = goodss.data3[i].goodsName;        //获取到商品名字
                var batching = goodss.data3[i].batching;         //获取到配料
                var introduce = goodss.data3[i].introduce;        //获取到介绍
                var toBadTime = goodss.data3[i].toBadTime;        //获取到保质期
                var price = goodss.data3[i].price;            //获取到价格     double类型
                var size = goodss.data3[i].size;             //获取到size,大号1、中号2、小号3   int类型
                if (str == "")
                    str += "<br/>";
                str += "点心：<br/>goodsId:" + goodsId;
                str += "<br/>goodsName:" + goodsName;
                str += "<br/>batching:" + batching;
                str += "<br/>introduce:" + introduce;
                str += "<br/>toBadTime:" + toBadTime;
                str += "<br/>price:" + price;
                str += "<br/>size:" + size;
                str += "<br/><br/>";
            }
            document.getElementById("labTest").innerHTML = str;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <button id="btnTest" type="button" onclick="Post()">我是Button</button>
        <br />
        <label id="labTest"></label>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        9
    </div>
    </form>
</body>
</html>
