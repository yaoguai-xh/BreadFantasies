using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using data;

namespace Web
{
    public partial class register : System.Web.UI.Page
    {
        DataManager manager;
        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new DataManager("不执行查询");
        }

        protected void btnRegsiter_Click(object sender, EventArgs e)
        {
            string phone = Request.Form.Get("phone").ToString();
            string userName = Request.Form.Get("userName").ToString();
            string passWord1 = Request.Form.Get("password1").ToString();
            string passWord2 = Request.Form.Get("password2").ToString();
            string sexTxt = Request.Form.Get("sex").ToString();
            int sex;
            if (sexTxt == "no")
                sex = -1;
            else if (sexTxt == "male")
                sex = 1;
            else
                sex = 0;
            string year = Request.Form.Get("year").ToString();
            string month = Request.Form.Get("month").ToString();
            string day = Request.Form.Get("days").ToString();
            string birthday = year + "年" + month + "月" + day + "日";
            string province = Request.Form.Get("province").ToString();
            string city = Request.Form.Get("citys").ToString();
            string district = Request.Form.Get("district").ToString();
            string txtArea = Request.Form.Get("lastAdress").ToString();
            string address = province + "*" + city + "*" + district + "*" + txtArea;
            Users currentUser = new Users(phone, passWord1, 0, birthday, userName, address, phone, sex);
            if (manager.addUser(currentUser))
            {
                Response.Write(new ShowMessageBox("注册成功,即将转到登录页面...").Text);
                Response.Redirect("login.aspx");
            }
            else
                Response.Write(new ShowMessageBox("注册失败,存在同名情况...").Text);
        }
    }
}