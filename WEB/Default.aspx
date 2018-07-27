<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"  Inherits="Web.Default"%>

<!DOCTYPE html >
<html>
<head id="Head1" runat="server">
    <title>管理界面</title>
    <script src="jQuery.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Clear() {
            $("asp:TextBox").text = "";
        }
    </script>
    <style type="text/css">
        html, body, form
        {
            width: 100%;
            height: 100%;
            padding: 0px;
            margin: 0px;
        }
        #labShow
        {
            position:fixed;
            top:1px;
            height: 50px;
            width: 100%;
            background-color: #ff8b31;
            font-family:"@黑体";
            font-size:32px;
            color:white;
            text-align:center;
            left: -2px;
        }
        label
        {
            font-size:20px;
            background-color: white;
            width:10%;
            height:30px;
            text-align:center;
        }
        #btnClear, #btnClear:visited {
	        background: #ff8b31;
	        display: inline-block;
	        padding: 5px 10px 6px;
	        color: #fff;
	        text-decoration: none;
	        -moz-border-radius: 6px;
	        -webkit-border-radius: 6px;
	        -moz-box-shadow: 0 1px 3px rgba(0,0,0,0.6);
	        -webkit-box-shadow: 0 1px 3px rgba(0,0,0,0.6);
	        text-shadow: 0 -1px 1px rgba(0,0,0,0.25);
	        border-bottom: 1px solid rgba(0,0,0,0.25);
	        position:absolute;
	        cursor: pointer;
        }
        .user
        {
            width:90%;
            margin-top:5% ;
            margin-left:5%;
            float:left;
           
            }
            .userp,.goodsp,.orderp,.fap,.shoup
            {   float:left;
                width:20%;
                height:15%;
                background-color:#ffad46;
             margin-top:2%;
               
                }
                .userp p,.goodsp p,.orderp p,.fap p,.shoup p
                { font-size:30px;
                  margin-left:30px;
                  font-family:"黑体";
                    }
                .userlist
                {float:left;
                 background-color:#E8E8E8;
                 width:70%;
                 padding-left:5%;
         
        }
        .goods
        {width:90%;
            margin-top:5% ;
            margin-left:5%;
            float:left;
            }
                  .goodslist
                {float:left;
                 background-color:#E8E8E8;
                 width:70%;
                 padding-left:5%;
         
        }
        .order
        {width:90%;
            margin-top:5% ;
            margin-left:5%;
            float:left;
            }
            .orderlist
            {float:left;
                 background-color:#E8E8E8;
                 width:70%;
                 padding-left:5%;
                }
                .fa,.shou
                {width:90%;
            margin-top:5% ;
            margin-left:5%;
            float:left;
                    }
                    .falist,.shoulist
                    {
                        float:left;
                 background-color:#E8E8E8;
                 width:70%;
                 padding-left:5%;
                 padding-top:50px;}
        
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    商品管理:
    订单管理:<asp:Label ID="labShow" runat="server" Text="管理员管理界面"></asp:Label>



    <div><!-------------------------管理盒子---------------------------->
    <!----------------------------------------用户控件---------------------------------------->
      <div class="user">
         <div class="userp">
             <p>用户信息管理:</p></div>
         <div class="userlist">
 <asp:Label ID="Label1" runat="server" Text="用户：" style="margin-top:30px"></asp:Label>
        <asp:TextBox ID="txt1UserId" runat="server" Height="27px" style="margin-top:30px"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="txt1PassWd" runat="server" Height="27px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="类型："></asp:Label>
             <asp:DropDownList ID="txt1TypeList" runat="server">
                 <asp:ListItem Value="0">普通用户</asp:ListItem>
                 <asp:ListItem Value="1">管理员</asp:ListItem>

             </asp:DropDownList>
        <!--<asp:TextBox ID="txt1Type" runat="server" Height="27px"></asp:TextBox>--><br/>

        <asp:Label ID="Label12" runat="server" Text="昵称："></asp:Label>
        <asp:TextBox ID="txt1NickName" runat="server" Height="27px"></asp:TextBox>
        <asp:Label ID="Label15" runat="server" Text="生日："></asp:Label>
        <asp:TextBox ID="txt1Birthday" runat="server" Height="27px"></asp:TextBox>
        <asp:Label ID="Label18" runat="server" Text="地址："></asp:Label>
        <asp:TextBox ID="txt1Address" runat="server" Height="27px"></asp:TextBox><br/>
        <asp:Label ID="Label21" runat="server" Text="手机："></asp:Label>
        <asp:TextBox ID="txt1Phone" runat="server" Height="27px"></asp:TextBox>
        <asp:Label ID="Label24" runat="server" Text="性别："></asp:Label>
             <asp:DropDownList ID="txt1SexList" runat="server" Height="27px" Width="146px">
                 <asp:ListItem Value="0">女</asp:ListItem>
                 <asp:ListItem Value="1">男</asp:ListItem>
             </asp:DropDownList>
        <!--<asp:TextBox ID="txt12Sex" runat="server" Height="27px"></asp:TextBox>-->&nbsp;<br />
             <br/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn1Select" runat="server" Text="查询" Height="32px" Width="61px" 
                 onclick="btn1Select_Click"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn1Update" runat="server" Text="修改" Height="32px" Width="61px" 
                 onclick="btn1Update_Click"/>
        &nbsp;&nbsp;
        <asp:Button ID="btn1Delete" runat="server" Text="删除"  Height="32px" Width="61px" 
                 onclick="btn1Delete_Click"/>
        &nbsp;&nbsp;
        <asp:Button ID="btn1Add" runat="server" Text="增加"  Height="32px" Width="61px"/>
        &nbsp;&nbsp;&nbsp;
        </div>
      </div>
     <!----------------------------------------用户控件---------------------------------------->




     <!----------------------------------------商品控件---------------------------------------->
       <div  class="goods">
       <div class="goodsp"><p>&nbsp;商品管理</p>
           </div>
           <div class="goodslist" id="txt2GoodsDiv">
        <asp:Label ID="Label2" runat="server" Text="商品ID：" style="margin-top:30px"></asp:Label>
        <asp:TextBox ID="txt2GoodsId" runat="server" Height="27px" style="margin-top:30px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="名字："></asp:Label>
        <asp:TextBox ID="txt2GoodsName" runat="server" Height="27px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Text="价格："></asp:Label>
        <asp:TextBox ID="txt2GoodsPrice" runat="server" Height="27px"></asp:TextBox>
               <br />
        <asp:Label ID="Label13" runat="server" Text="类型："></asp:Label>
               <asp:DropDownList ID="txt2GoodsNewType" runat="server" Height="27px" 
                   Width="170px">
                   <asp:ListItem Value="1">蛋糕</asp:ListItem>
                   <asp:ListItem Value="2">面包</asp:ListItem>
                   <asp:ListItem Value="3">点心</asp:ListItem>
               </asp:DropDownList>

        &nbsp;&nbsp;
        <asp:Label ID="Label16" runat="server" Text="颜色："></asp:Label>
        <asp:TextBox ID="txt2GoodsColor" runat="server" Height="27px"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:Label ID="Label19" runat="server" Text="味道："></asp:Label>
        <asp:TextBox ID="txt2GoodsTatse" runat="server" Height="27px"></asp:TextBox>
               <br />
        <asp:Label ID="Label22" runat="server" Text="大小："></asp:Label>
        <asp:DropDownList ID="listSize" runat="server" Height="20px" Width="146px" 
                   style="margin-bottom: 6px">
            <asp:ListItem>大</asp:ListItem>
            <asp:ListItem>中</asp:ListItem>
            <asp:ListItem>小</asp:ListItem>
        </asp:DropDownList>
               &nbsp;&nbsp;&nbsp;<asp:Label ID="Label32" runat="server" Text="上架："></asp:Label>
        <asp:DropDownList ID="listFlag" runat="server" Height="20px" Width="152px">
            <asp:ListItem>上架</asp:ListItem>
            <asp:ListItem>下架</asp:ListItem>
        </asp:DropDownList>
               &nbsp;
        <asp:Label ID="Label30" runat="server" Text="保质期："></asp:Label>
        <asp:TextBox ID="txt2Year" runat="server" Height="17px" Width="149px"></asp:TextBox>
        <asp:Label ID="Label35" runat="server" Text="天"></asp:Label>
               <br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <br />
        <asp:Label ID="Label28" runat="server" Text="介绍："></asp:Label>
        <asp:TextBox ID="txt2GoodsIntroduce" runat="server" Height="60px" Width="310px" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label25" runat="server" Text="配料："></asp:Label>
        <asp:TextBox ID="txt2GoodsBatching" runat="server" Height="60px" Width="343px" TextMode="MultiLine"></asp:TextBox>
               <br />
               图片必填：<br />
        <asp:Label ID="Label36" runat="server" Text="图片1："></asp:Label>
        <asp:FileUpload ID="imageMain" runat="server" />
        <asp:Label ID="Label37" runat="server" Text="图片2："></asp:Label>
        <asp:FileUpload ID="image1" runat="server" />
               <br />
        <asp:Label ID="Label38" runat="server" Text="图片3："></asp:Label>
        <asp:FileUpload ID="image2" runat="server" />
        <asp:Label ID="Label39" runat="server" Text="图片4："></asp:Label>
        <asp:FileUpload ID="image3" runat="server" />
               <br />
        <asp:Label ID="Label40" runat="server" Text="图片5："></asp:Label>
        <asp:FileUpload ID="image4" runat="server" />
               <br />
               <br />
&nbsp;
        <asp:Button ID="btn2Select" runat="server" Text="查询" Height="38px" Width="66px" 
                   onclick="btn2Select_Click"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2Update" runat="server" Text="修改" Height="37px" Width="63px" 
                   onclick="btn2Update_Click"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2Delete" runat="server" Text="删除" Height="36px" Width="65px" 
                   onclick="btn2Delete_Click"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2Add" runat="server" Text="增加" Height="36px" Width="60px" 
                   onclick="btn2Add_Click"/>
        </div>
        </div>
     <!----------------------------------------商品控件---------------------------------------->



     <!----------------------------------------订单控件---------------------------------------->
       <div  class="order" style="display:none">
          <div class="orderp"><p>订单管理</p>
           </div>
           
           <br /> 
           <div class="orderlist">
        <asp:Label ID="Label5" runat="server" Text="商品ID：" style="margin-top:30px"></asp:Label>
        <asp:TextBox ID="txt3GoodsId" runat="server" Height="27px" style="margin-top:30px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label8" runat="server" Text="用户ID："></asp:Label>
        <asp:TextBox ID="txt3UserId" runat="server" Height="27px"></asp:TextBox>
               &nbsp;&nbsp;&nbsp;<asp:Label ID="Label11" runat="server" Text="订单ID："></asp:Label>
        <asp:TextBox ID="txt3OrderId" runat="server" Height="27px"></asp:TextBox>
               <br />
        <asp:Label ID="Label14" runat="server" Text="地址："></asp:Label>
        <asp:TextBox ID="txt3Address" runat="server" Height="27px"></asp:TextBox>
               &nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label17" runat="server" Text="手机："></asp:Label>
        <asp:TextBox ID="txt3Phone" runat="server" Height="27px"></asp:TextBox>
               <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn3Select" runat="server" Text="查询" Height="34px" Width="68px"/>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn3Update" runat="server" Text="修改" Height="34px" Width="59px"  />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn3Delete" runat="server" Text="删除" Height="32px" Width="51px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn3Add" runat="server" Text="增加" Height="35px" Width="55px" />
       </div></div>
    <!----------------------------------------订单控件---------------------------------------->

    </div>



<!----------------------------------------待发货控件---------------------------------------->
    <div class="fa">
        <div class="fap">
            <p>待发货</p></div>
    <div class="falist">
    
    <asp:ListBox ID="list1_1" runat="server"></asp:ListBox>
    <asp:ListBox ID="list1_2" runat="server"></asp:ListBox>
    <asp:ListBox ID="list1_3" runat="server"></asp:ListBox>
    <asp:ListBox ID="list1_4" runat="server"></asp:ListBox>
    <asp:ListBox ID="list1_5" runat="server"></asp:ListBox>
    <asp:ListBox ID="list1_6" runat="server"></asp:ListBox>
    <asp:ListBox ID="list1_7" runat="server"></asp:ListBox>
        <br />
    <asp:Button ID="btnSelect1" runat="server" Height="34px"  Text="查询" Width="133px" 
            onclick="btnSelect1_Click" />
    <asp:Button ID="btnSend" runat="server" Height="33px" Text="发货" Width="130px" 
            onclick="btnSend_Click" /><h6>P:选中订单号发货</h6>
    </div></div>
<!----------------------------------------待发货控件---------------------------------------->



<!----------------------------------------待收货控件---------------------------------------->
    <div>
  <div class="shou">
  <div class="shoup"><p>待收货:</p></div>
  <div class="shoulist">
    <asp:ListBox ID="list2_1" runat="server"></asp:ListBox>
    <asp:ListBox ID="list2_2" runat="server"></asp:ListBox>
    <asp:ListBox ID="list2_3" runat="server"></asp:ListBox>
    <asp:ListBox ID="list2_4" runat="server"></asp:ListBox>
    <asp:ListBox ID="list2_5" runat="server"></asp:ListBox>
    <asp:ListBox ID="list2_6" runat="server"></asp:ListBox>
    <asp:ListBox ID="list2_7" runat="server"></asp:ListBox>
      <br />
    <asp:Button ID="btnSelect2" runat="server" Height="36px"  Text="查询" Width="127px" 
          onclick="btnSelect2_Click" />
    </div></div></br>
<!----------------------------------------待收货控件---------------------------------------->
    
    </form>

    <p>
        &nbsp;</p>
</body>
</html>
