using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using data;

namespace Web
{
    public class ShowMessageBox
    {
        public string Text;
        public ShowMessageBox(string str)
        {
            Text = "<link rel=\"stylesheet\" type=\"text/css\" href=\"css/jquery.dialogbox.css\"> <script type=\"text/javascript\" src=\"js/jquery-3.2.1.min.js\"></script> <script type=\"text/javascript\" src=\"js/post.js\"></script> <script src=\"js/jquery.dialogBox.js\"></script> <div id=\"QMessageBox\" z-index=999></div> <script>showMessageBox('" + str + "');</script>";
        }
    }
    public partial class Default : System.Web.UI.Page
    {
        public DataManager data;
        bool isHaveDian = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["user"] == null || Request["user"].ToString() != "xuhao")
            {
                Response.Redirect("index.html");
            }
            data = new DataManager();
            if (IsPostBack)
                return;
            //txt2GoodsId.ReadOnly = true;
            //bindData(0);
            //bindData(1);
        }

        protected void btn1Select_Click(object sender, EventArgs e)
        {
            Users temp = null;
            temp = data.selectUser(txt1UserId.Text);
            if (temp == null)
                Response.Write(new ShowMessageBox("查询为空.").Text);
            else
            {
                txt1Address.Text = temp.address;
                txt1Birthday.Text = temp.birthday;
                txt1NickName.Text = temp.nickName;
                txt1PassWd.Text = temp.passWord;
                txt1Phone.Text = temp.phone;
                txt1TypeList.SelectedIndex = temp.type;
                txt1SexList.SelectedIndex = temp.sex;

                //txt1Sex.Text = temp.sex.ToString();
                //txt1Type.Text = temp.type.ToString();
            }
        }

        protected void btn1Update_Click(object sender, EventArgs e)
        {
            Users user = new Users(txt1UserId.Text, txt1PassWd.Text, txt1TypeList.SelectedIndex,
                txt1Birthday.Text, txt1NickName.Text, txt1Address.Text, txt1Phone.Text, txt1SexList.SelectedIndex);
            try
            {
                if(data.reUser(user))
                    Response.Write(new ShowMessageBox("修改成功").Text);
                else
                    Response.Write(new ShowMessageBox("修改失败").Text);
            }
            catch
            {
                Response.Write(new ShowMessageBox("修改出错了").Text);
            }
        }

        protected void btn1Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(data.delUser(txt1UserId.Text))
                    Response.Write(new ShowMessageBox("删除成功").Text);
                else
                    Response.Write(new ShowMessageBox("删除失败").Text);
            }
            catch
            {
                Response.Write(new ShowMessageBox("删除失败,id错误").Text);
            }
        }

        protected void btn1Add_Click(object sender, EventArgs e)
        {
            Users user = new Users(txt1UserId.Text, txt1PassWd.Text, txt1TypeList.SelectedIndex,
                txt1Birthday.Text, txt1NickName.Text, txt1Address.Text, txt1Phone.Text, txt1SexList.SelectedIndex);
            try
            {
                if(data.addUser(user))
                    Response.Write(new ShowMessageBox("添加成功").Text);
                else
                    Response.Write(new ShowMessageBox("添加失败").Text);
            }
            catch
            {
                Response.Write(new ShowMessageBox("添加失败").Text);
            }
        }

        protected void btn2Select_Click(object sender, EventArgs e)
        {
            Goodss goods = null;
            if(txt2GoodsId.Text != "")
                goods = data.selectGoodsFromId(txt2GoodsId.Text);
            else if (txt2GoodsName.Text != "")
                goods = data.selectGoodsFromName(txt2GoodsName.Text);
            if (goods == null)
            {
                Response.Write(new ShowMessageBox("查询为空.").Text);
                return;
            }
            txt2GoodsBatching.Text = goods.batching;
            txt2GoodsColor.Text = goods.color;
            txt2GoodsId.Text = goods.goodsId;
            txt2GoodsIntroduce.Text = goods.introduce;
            txt2GoodsName.Text = goods.goodsName;
            txt2GoodsPrice.Text = goods.price.ToString();
            txt2GoodsTatse.Text = goods.tatse;
            txt2GoodsNewType.SelectedIndex = goods.type-1;
            listFlag.SelectedIndex = goods.flag;
            listSize.SelectedIndex = goods.size;
            string toBadTime = goods.toBadTime;
            string[] year = toBadTime.Split(new char[1] {'天'});
            txt2Year.Text = year[0];
        }

        protected void btn2Update_Click(object sender, EventArgs e)
        {
            string date = txt2Year.Text + "天";
            Goodss goods = new Goodss(txt2GoodsId.Text, txt2GoodsName.Text, double.Parse(txt2GoodsPrice.Text), int.Parse(txt2GoodsNewType.SelectedValue),
                txt2GoodsColor.Text, txt2GoodsTatse.Text, listSize.SelectedIndex + 1, txt2GoodsBatching.Text,
                txt2GoodsIntroduce.Text, date, listFlag.SelectedIndex);
            if (!data.reGoods(goods))
                Response.Write(new ShowMessageBox("修改失败，数据格式有误...").Text);
            else
                Response.Write(new ShowMessageBox("数据库修改成功...").Text);
        }

        protected void btn2Delete_Click(object sender, EventArgs e)
        {
            if(!data.delGoods(txt2GoodsId.Text))
                Response.Write(new ShowMessageBox("删除失败，ID格式有误或无此ID...").Text);
            else
                Response.Write(new ShowMessageBox("删除成功...").Text);
        }

        protected void btn2Add_Click(object sender, EventArgs e)
        {
            try
            {
                int type = int.Parse(txt2GoodsNewType.SelectedValue);
                int head = type * 10000 + data.getGoodsNum(type) + 1;
                string goodId = "" + head;
                string date = txt2Year.Text + "天";
                Goodss goods = new Goodss(goodId, txt2GoodsName.Text, double.Parse(txt2GoodsPrice.Text), type,
                    txt2GoodsColor.Text, txt2GoodsTatse.Text, listSize.SelectedIndex + 1, txt2GoodsBatching.Text,
                    txt2GoodsIntroduce.Text, date, listFlag.SelectedIndex);


                if (!data.addGoods(goods))
                    throw new Exception();

                string nowPath = Server.MapPath(".") + "\\img\\";
                string img1 = nowPath + goodId + "_main.jpg";
                imageMain.SaveAs(img1);
                string img2 = nowPath + goodId + "_1.jpg";
                image1.SaveAs(img2);
                string img3 = nowPath + goodId + "_2.jpg";
                image2.SaveAs(img3);
                string img4 = nowPath + goodId + "_3.jpg";
                image3.SaveAs(img4);
                string img5 = nowPath + goodId + "_4.jpg";
                image4.SaveAs(img5);

                Response.Write(new ShowMessageBox("添加成功...").Text);
            }
            catch
            {
                //...
                Response.Write(new ShowMessageBox("数据填写有误，不要调皮捣蛋...").Text);
            }
        }

        protected void btn3Select_Click(object sender, EventArgs e)
        {
            Orders order = null;
            order = data.selectOrder(txt3OrderId.Text);
            if (order == null)
                Response.Write(new ShowMessageBox("查询为空.").Text);
            else
            {
                txt3Address.Text = order.address;
                txt3GoodsId.Text = order.goodsId;
                txt3OrderId.Text = order.orderId;
                txt3Phone.Text = order.phone;
                txt3UserId.Text = order.userId;
            }
        }

        protected void btn3Update_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn3Delete_Click(object sender, EventArgs e)
        {

        }

        protected void btn3Add_Click(object sender, EventArgs e)
        {

        }

        protected void btnSelect1_Click(object sender, EventArgs e)
        {
            bindData(0);
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (data.setOrderFlag(list1_1.SelectedValue, 1))
            {
                Response.Write(new ShowMessageBox("发货成功..").Text);
                bindData(0);
                bindData(1);
            }
            else
                Response.Write(new ShowMessageBox("发货失败,请重试...").Text);
        }

        protected void btnSelect2_Click(object sender, EventArgs e)
        {
            bindData(1);
        }

        public void bindData(int flag)
        {
            DataTable ordersTable = data.selectOrders(flag);
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            list1.Add("订单号");
            list2.Add("用户名");
            list3.Add("商品ID");
            list4.Add("商品名");
            list5.Add("商品数量");
            list6.Add("商品价格");
            list7.Add("客户地址");

            foreach (DataRow dr in ordersTable.Rows)
            {
                list1.Add(dr["orderId"].ToString());
                list2.Add(dr["userName"].ToString());
                list3.Add(dr["goodsId"].ToString());
                list4.Add(dr["goodsName"].ToString());
                list5.Add(dr["goodsNum"].ToString());
                list6.Add(dr["price"].ToString());
                list7.Add(dr["address"].ToString().Replace("*",""));
            }
            if (flag == 0)
            {
                list1_1.DataSource = list1;
                list1_2.DataSource = list2;
                list1_3.DataSource = list3;
                list1_4.DataSource = list4;
                list1_5.DataSource = list5;
                list1_6.DataSource = list6;
                list1_7.DataSource = list7;
                list1_1.DataBind();
                list1_2.DataBind();
                list1_3.DataBind();
                list1_4.DataBind();
                list1_5.DataBind();
                list1_6.DataBind();
                list1_7.DataBind();
                list1_1.Rows = list1.Count+1;
                list1_2.Rows = list2.Count+1;
                list1_3.Rows = list3.Count+1;
                list1_4.Rows = list4.Count + 1;
                list1_5.Rows = list5.Count + 1;
                list1_6.Rows = list6.Count + 1;
                list1_7.Rows = list7.Count + 1;
            }
            else
            {
                list2_1.DataSource = list1;
                list2_2.DataSource = list2;
                list2_3.DataSource = list3;
                list2_4.DataSource = list4;
                list2_5.DataSource = list5;
                list2_6.DataSource = list6;
                list2_7.DataSource = list7;

                list2_1.DataBind();
                list2_2.DataBind();
                list2_3.DataBind();
                list2_4.DataBind();
                list2_5.DataBind();
                list2_6.DataBind();
                list2_7.DataBind();

                list2_1.Rows = list1.Count+1;
                list2_2.Rows = list2.Count+1;
                list2_3.Rows = list3.Count + 1;
                list2_4.Rows = list4.Count + 1;
                list2_5.Rows = list5.Count + 1;
                list2_6.Rows = list6.Count + 1;
                list2_7.Rows = list7.Count + 1;
            }
        }
    }
}