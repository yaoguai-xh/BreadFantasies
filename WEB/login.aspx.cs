using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using mysql;
using data;

namespace Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userId"] != null && Request.Cookies["userId"].Value != string.Empty)
            {
                checkboxInput.Checked = true;
            }
        }

        protected void submitInput_Click(object sender, EventArgs e)
        {
            if (Request.Form.Get("userID") != null && Request.Form.Get("userID").ToString() != "")
            {
                string userId = Request.Form.Get("userID").ToString();
                string passWd = Request.Form.Get("userPassword").ToString();
                MysqlManager manager = new MysqlManager();
                int loginJ = manager.testUserTrue(userId, passWd);
                if (loginJ != -1)
                {
                    //Response.Write("<script>alert('" + "userId: " + Request.Cookies["userId"].Value + "');</script>");
                    if (loginJ == 0)
                    {
                        DataManager data = new DataManager("i");
                        Response.Cookies["userId"].Value = userId;
                        string strcode = data.selectUserNameFromId(userId);
                        string userNameFromUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(strcode));
                        Response.Cookies["nickName"].Value = userNameFromUtf8;
                        Response.Cookies["passWd"].Value = passWd;

                        Response.Redirect("index.html");
                        Response.Write(new ShowMessageBox("欢迎您," + userNameFromUtf8 + ".").Text);
                    }
                    else
                    {
                        Response.Redirect("Default.aspx?user=xuhao");
                        Response.Write(new ShowMessageBox("管理员登录成功,即将转到管理员页面...").Text);
                    }
                }
                else
                    Response.Write(new ShowMessageBox("登录失败,请检查输入是否正确...").Text);
            }
        }
    }
}