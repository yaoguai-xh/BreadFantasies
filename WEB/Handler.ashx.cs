using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using data;

namespace Web
{
    /// <summary>
    /// Summary description for Handler
    /// </summary>
    public class Handler : IHttpHandler
    {
        public void ProcessRequest(HttpContext content)
        {
            string JsonString = "";
            string key = content.Request["KEY"].ToString();
            string id = "";
            if(content.Request["ID"] != null)
                id = content.Request["ID"].ToString();
            if (key == "1")                                  //根据userId获取单个用户所有信息
            {
                DataManager data = new DataManager("i");
                Users user = data.selectUsersFromId(id);
                JsonString = JsonConvert.SerializeObject(user);
            }
            else if (key == "2")                            //获取所有商品信息
            {
                PageData pageData = new PageData();
                JsonString = JsonConvert.SerializeObject(pageData);
            }
            else if (key == "3")                            //根据goodsId获取单个商品所有信息
            {
                DataManager data = new DataManager("i");
                Goodss goods = data.selectGoodsFromId(id);
                JsonString = JsonConvert.SerializeObject(goods);
            }
            else if (key == "4")                            //根据userId获取该用户所有订单信息
            {
                DataManager data = new DataManager("i");
                List<Orders> order = data.selectOrdersFromId(id);
                JsonString = JsonConvert.SerializeObject(order);
            }
            else if (key == "5")
            {
                DataManager data = new DataManager("i");
                JsonString = data.selectUserNameFromId(id);
            }
            else if (key == "6")    //返回cookies，当前登录
            {
                //login s = new login();
                //JsonString = s.Request.Cookies["userId"].Value;
                //s = null;
                JsonString = content.Request.Cookies["userId"].Value;
            }
            else if (key == "7")    //下单
            {
                DataManager data = new DataManager("i");
                int goodsNum = int.Parse(content.Request["goodsNum"]);
                string userName = content.Request["userName"];
                double price = double.Parse(content.Request["price"]);
                string userId = content.Request.Cookies["userId"].Value;
                string phone = content.Request["phone"];
                string address = content.Request["address"];
                string goodsName = content.Request["goodsName"];
                string goodsId = content.Request["goodsId"];

                string hour = DateTime.Now.Hour.ToString();
                if (hour.Length < 2)
                {
                    hour = "0" + hour;
                }
                string minute = DateTime.Now.Minute.ToString();
                if (minute.Length < 2)
                {
                    minute = "0" + minute;
                }
                string second = DateTime.Now.Second.ToString();
                if (second.Length < 2)
                {
                    second="0"+second;
                }

                string orderId = goodsId + hour + minute + second;
                Orders order = new Orders(goodsNum,userName,orderId,userId,goodsId,address,phone,price,goodsName,0);
                if (data.addOrder(order))
                    JsonString = "s";
                else
                    JsonString = "f";
            }
            else if (key == "8")    //下单
            {
                DataManager data = new DataManager("i");
                if (data.receiveGoods(id))
                    JsonString = "s";
                else
                    JsonString = "f";
            }
            content.Response.Write(JsonString);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}