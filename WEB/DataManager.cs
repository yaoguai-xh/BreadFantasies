using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mysql;
using System.Data;
using MySql.Data.MySqlClient;


/// <summary>
///DataManager 的摘要说明
/// </summary>
/// 

namespace data
{
    public class Goodss
    {
        public string goodsId;
        public string goodsName;
        public double price;
        public int type;
        public string color;
        public string tatse;
        public int size;
        public string batching;
        public string introduce;
        public string toBadTime;
        public int flag;

        public Goodss()
        {
        }
        public Goodss(string goodsId, string goodsName, double price, int type, string color, string tatse,
            int size, string batching, string introduce, string toBadTime, int flag)
        {
            this.goodsId = goodsId;
            this.goodsName = goodsName;
            this.price = price;
            this.type = type;
            this.color = color;
            this.tatse = tatse;
            this.size = size;
            this.batching = batching;
            this.introduce = introduce;
            this.toBadTime = toBadTime;
            this.flag = flag;
        }

        public void copy(Goodss temp)
        {
            this.goodsId = temp.goodsId;
            this.goodsName = temp.goodsName;
            this.price = temp.price;
            this.type = temp.type;
            this.color = temp.color;
            this.tatse = temp.tatse;
            this.size = temp.size;
            this.batching = temp.batching;
            this.introduce = temp.introduce;
            this.toBadTime = temp.toBadTime;
            this.flag = temp.flag;
        }
    }
    public class Orders
    {
        public int goodsNum;
        public string userName;
        public string orderId;
        public string userId;
        public string goodsId;
        public string address;
        public string phone;
        public double price;
        public string goodsName;
        public int flag;    //0待发货，1待收货，2已完成

        public Orders()
        {
        }
        public Orders(int goodsNum,string userName,string orderId, string userId, string goodsId, string address, string phone,double price,string goodsName,int flag)
        {
            this.goodsNum = goodsNum;
            this.userName = userName;
            this.orderId = orderId;
            this.userId = userId;
            this.goodsId = goodsId;
            this.address = address;
            this.phone = phone;
            this.price = price;
            this.goodsName = goodsName;
            this.flag = flag;
        }
        public void copy(Orders temp)
        {
            this.goodsNum = temp.goodsNum;
            this.userName = temp.userName;
            this.orderId = temp.orderId;
            this.userId = temp.userId;
            this.goodsId = temp.goodsId;
            this.address = temp.address;
            this.phone = temp.phone;
            this.price = temp.price;
            this.goodsName = temp.goodsName;
            this.flag = temp.flag;
        }
    }
    public class Users
    {
        public string userId;
        public string passWord;
        public int type;
        public string nickName;
        public string birthday;
        public string address;
        public string phone;
        public int sex;
        //public string headUrl;

        public Users()
        {
        }
        public Users(string userId, string passWord, int type, string birthday, string nickName, string address, string phone, int sex)
        {
            this.userId = userId;
            this.passWord = passWord;
            this.type = type;
            this.nickName = nickName;
            this.birthday = birthday;
            this.address = address;
            this.phone = phone;
            this.sex = sex;
        }

        public void copy(Users temp)
        {
            this.userId = temp.userId;
            this.passWord = temp.passWord;
            this.type = temp.type;
            this.nickName = temp.nickName;
            this.birthday = temp.birthday;
            this.address = temp.address;
            this.phone = temp.phone;
            this.sex = temp.sex;
        }
    }

    public class DataManager
    {
        public MysqlManager mysql;
        public List<Goodss> goodss = new List<Goodss>();
        public List<Users> users = new List<Users>();
        public List<Orders> orders = new List<Orders>();


        public DataManager()
        {
            mysql = new MysqlManager();
            select();
        }
        public DataManager(int t)
        {
            mysql = new MysqlManager();
            selectShangJiaGoodss();
        }
        public DataManager(string s)
        {
            mysql = new MysqlManager();
        }


        //------------------单一不规矩封装区---------------------
        public Goodss selectGoodsFromId(string goodsId)
        {
            string sqlStr = "select * from goodss where goodsId = '"+goodsId+"'";
            WriteSqlSentence(sqlStr);
            DataTable goodsTable = mysql.ExecuteQuery();
            if (goodsTable.Rows.Count < 1)
                return null;
            Goodss temp = new Goodss();
            temp.goodsId = goodsTable.Rows[0]["goodsId"].ToString();
            temp.goodsName = goodsTable.Rows[0]["goodsName"].ToString();
            temp.price = (double)goodsTable.Rows[0]["price"];
            temp.type = (int)goodsTable.Rows[0]["type"];
            temp.color = goodsTable.Rows[0]["color"].ToString();
            temp.tatse = goodsTable.Rows[0]["tatse"].ToString();
            temp.size = (int)goodsTable.Rows[0]["size"];
            temp.batching = goodsTable.Rows[0]["batching"].ToString();
            temp.introduce = goodsTable.Rows[0]["introduce"].ToString();
            temp.toBadTime = goodsTable.Rows[0]["toBadTime"].ToString();
            temp.flag = (int)goodsTable.Rows[0]["flag"];
            return temp;
        }
        public Goodss selectGoodsFromName(string goodsName)
        {
            string sqlStr = "select * from goodss where goodsName = '" + goodsName + "'";
            WriteSqlSentence(sqlStr);
            DataTable goodsTable = mysql.ExecuteQuery();
            if (goodsTable.Rows.Count < 1)
                return null;
            Goodss temp = new Goodss();
            temp.goodsId = goodsTable.Rows[0]["goodsId"].ToString();
            temp.goodsName = goodsTable.Rows[0]["goodsName"].ToString();
            temp.price = (double)goodsTable.Rows[0]["price"];
            temp.type = (int)goodsTable.Rows[0]["type"];
            temp.color = goodsTable.Rows[0]["color"].ToString();
            temp.tatse = goodsTable.Rows[0]["tatse"].ToString();
            temp.size = (int)goodsTable.Rows[0]["size"];
            temp.batching = goodsTable.Rows[0]["batching"].ToString();
            temp.introduce = goodsTable.Rows[0]["introduce"].ToString();
            temp.toBadTime = goodsTable.Rows[0]["toBadTime"].ToString();
            temp.flag = (int)goodsTable.Rows[0]["flag"];
            return temp;
        }
        public List<Orders> selectOrdersFromId(string userId)
        {
            List<Orders> ordersData = new List<Orders>();
            //查询商品表
            string sqlStr = "select * from orders where userId = '" + userId + "'";
            WriteSqlSentence(sqlStr);
            DataTable ordersTable = mysql.ExecuteQuery();
            foreach (DataRow dr in ordersTable.Rows)
            {
                Orders temp = new Orders();
                temp.goodsNum = (int)dr["goodsNum"];
                temp.userName = dr["userName"].ToString();
                temp.orderId = dr["orderId"].ToString();
                temp.userId = dr["userId"].ToString();
                temp.goodsId = dr["goodsId"].ToString();
                temp.address = dr["address"].ToString();
                temp.phone = dr["phone"].ToString();
                temp.price = (double)dr["price"];
                temp.goodsName = dr["goodsName"].ToString();
                temp.flag = (int)dr["flag"];
                ordersData.Add(temp);
            }
            return ordersData;
        }
        public Users selectUsersFromId(string userId)
        {
            //查询用户表
            string sqlStr = "select * from users where userId = '" + userId + "'";
            WriteSqlSentence(sqlStr);
            DataTable usersTable = mysql.ExecuteQuery();
            if (usersTable.Rows.Count < 1)
            {
                return null;
            }
            Users temp = new Users();
            temp.userId = usersTable.Rows[0]["userId"].ToString();
            temp.passWord = usersTable.Rows[0]["passWord"].ToString();
            temp.type = (int)(usersTable.Rows[0]["type"]);
            temp.nickName = usersTable.Rows[0]["nickName"].ToString();
            temp.birthday = usersTable.Rows[0]["birthday"].ToString();
            temp.address = usersTable.Rows[0]["address"].ToString();
            temp.phone = usersTable.Rows[0]["phone"].ToString();
            temp.sex = (int)usersTable.Rows[0]["sex"];
            //temp.headUrl = dr["headUrl"].ToString();
            return temp;
        }
        public string selectUserNameFromId(string userId)
        {
            string sqlStr = "select nickName from users where userId = '" + userId + "'";
            WriteSqlSentence(sqlStr);
            return mysql.ExecuteScalar();
        }
        public string selectGoodsIdFromGoodsName(string goodsName)
        {
            string sqlStr = "select goodsId from goodss where goodsName = '" + goodsName + "'";
            WriteSqlSentence(sqlStr);
            return mysql.ExecuteScalar();
        }
        public DataSet getDataSet(int flag)
        {
            string sqlStr = "select * from orders where flag = " + flag;
            WriteSqlSentence(sqlStr);
            return mysql.getDataSet();
        }

        private void selectShangJiaGoodss()
        {
            string sqlStr = "select * from goodss where flag =0";
            WriteSqlSentence(sqlStr);
            DataTable goodsTable = mysql.ExecuteQuery();
            for (int i = 0; i < goodsTable.Rows.Count; i++)
            {
                Goodss temp = new Goodss();
                temp.goodsId = goodsTable.Rows[i]["goodsId"].ToString();
                temp.goodsName = goodsTable.Rows[i]["goodsName"].ToString();
                temp.price = (double)goodsTable.Rows[i]["price"];
                temp.type = (int)goodsTable.Rows[i]["type"];
                temp.color = goodsTable.Rows[i]["color"].ToString();
                temp.tatse = goodsTable.Rows[i]["tatse"].ToString();
                temp.size = (int)goodsTable.Rows[i]["size"];
                temp.batching = goodsTable.Rows[i]["batching"].ToString();
                temp.introduce = goodsTable.Rows[i]["introduce"].ToString();
                temp.toBadTime = goodsTable.Rows[i]["toBadTime"].ToString();
                temp.flag = (int)goodsTable.Rows[i]["flag"];
                goodss.Add(temp);
            }
        }
        public DataTable selectOrders(int flag)
        {
            //查询商品表
            string sqlStr = "select * from orders where flag = " + flag.ToString();
            WriteSqlSentence(sqlStr);
            return mysql.ExecuteQuery();
        }
        public bool setOrderFlag(string orderId,int flag)
        {
            string temp = "update orders set ";
            temp += "flag=";
            temp += flag;
            temp += " where orderId=\"";
            temp += orderId;
            temp += "\"";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            select();
            return vo;
        }
        public bool receiveGoods(string orderId)
        {
            string temp = "update orders set ";
            temp += "flag=";
            temp += 2;
            temp += " where orderId=\"";
            temp += orderId;
            temp += "\"";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            select();
            return vo;
        }
        public int getGoodsNum(int type)
        {
            string sqlStr = "select goodsId from goodss where type=" + type;
            WriteSqlSentence(sqlStr);
            DataTable goodsTable = mysql.ExecuteQuery();
            return goodsTable.Rows.Count;
        }

        //------------------单一不规矩封装区---------------------


        private void WriteSqlSentence(string str)
        {
            mysql.CreateCommand(str);
        }

        private void select()
        {
            selectGoodss();
            selectUsers();
            selectOrders();
        }
        private void selectGoodss()
        {
            //查询商品表
            string sqlStr = "select * from goodss";
            WriteSqlSentence(sqlStr);
            goodss.Clear();
            DataTable goodsTable = mysql.ExecuteQuery();
            for (int i = 0; i < goodsTable.Rows.Count; i++)
            {
                Goodss temp = new Goodss();
                temp.goodsId = goodsTable.Rows[i]["goodsId"].ToString();
                temp.goodsName = goodsTable.Rows[i]["goodsName"].ToString();
                temp.price = (double)goodsTable.Rows[i]["price"];
                temp.type = (int)goodsTable.Rows[i]["type"];
                temp.color = goodsTable.Rows[i]["color"].ToString();
                temp.tatse = goodsTable.Rows[i]["tatse"].ToString();
                temp.size = (int)goodsTable.Rows[i]["size"];
                temp.batching = goodsTable.Rows[i]["batching"].ToString();
                temp.introduce = goodsTable.Rows[i]["introduce"].ToString();
                temp.toBadTime = goodsTable.Rows[i]["toBadTime"].ToString();
                temp.flag = (int)goodsTable.Rows[i]["flag"];
                goodss.Add(temp);
            }
        }
        private void selectUsers()
        {
            //查询用户表
            string sqlStr = "select * from users";
            WriteSqlSentence(sqlStr);
            DataTable usersTable = mysql.ExecuteQuery();
            foreach (DataRow dr in usersTable.Rows)
            {
                Users temp = new Users();
                temp.userId = dr["userId"].ToString();
                temp.passWord = dr["passWord"].ToString();
                temp.type = (int)(dr["type"]);
                temp.nickName = dr["nickName"].ToString();
                temp.birthday = dr["birthday"].ToString();
                temp.address = dr["address"].ToString();
                temp.phone = dr["phone"].ToString();
                temp.sex = (int)dr["sex"];
                //temp.headUrl = dr["headUrl"].ToString();
                users.Add(temp);
            }
        }
        private void selectOrders()
        {
            //查询商品表
            string sqlStr = "select * from orders";
            WriteSqlSentence(sqlStr);
            DataTable ordersTable = mysql.ExecuteQuery();
            foreach (DataRow dr in ordersTable.Rows)
            {
                Orders temp = new Orders();
                temp.goodsNum = (int)dr["goodsNum"];
                temp.userName = dr["userName"].ToString();
                temp.orderId = dr["orderId"].ToString();
                temp.userId = dr["userId"].ToString();
                temp.goodsId = dr["goodsId"].ToString();
                temp.address = dr["address"].ToString();
                temp.phone = dr["phone"].ToString();
                temp.price = (double)dr["price"];
                temp.goodsName = dr["goodsName"].ToString();
                temp.flag = (int)dr["flag"];
                orders.Add(temp);
            }
        }

        //查询并返回承载数据的对象
        public Goodss selectGoods(string goodsId)
        {
            Goodss temp = new Goodss();
            foreach (Goodss i in goodss)
            {
                if (i.goodsId == goodsId)
                {
                    temp.copy(i);
                    return temp;
                }
            }
            return null;
        }
        public Users selectUser(string userId)
        {
            Users temp = new Users();
            foreach (Users i in users)
            {
                if (i.userId == userId)
                {
                    temp.copy(i);
                    return temp;
                }
            }
            return null;
        }

        public Orders selectOrder(string orderId)
        {
            Orders temp = new Orders();
            foreach (Orders i in orders)
            {
                if (i.orderId == orderId)
                {
                    temp.copy(i);
                    return temp;
                }
            }
            return null;
        }

        //通过对象添加数据
        public bool addGoods(Goodss goods)
        {
            string temp = "insert into goodss values (\"";
            temp += goods.goodsId;
            temp += "\",\"";
            temp += goods.goodsName;
            temp += "\",";
            temp += goods.price;
            temp += ",";
            temp += goods.type;
            temp += ",\"";
            temp += goods.color;
            temp += "\",\"";
            temp += goods.tatse;
            temp += "\",";
            temp += goods.size;
            temp += ",\"";
            temp += goods.batching;
            temp += "\",\"";
            temp += goods.introduce;
            temp += "\",\"";
            temp += goods.toBadTime;
            temp += "\",";
            temp += goods.flag;
            temp += ")";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
        public bool addOrder(Orders order)
        {
            string temp = "insert into orders values (\"";
            temp += order.orderId;
            temp += "\",";
            temp += order.goodsNum;
            temp += ",\"";
            temp += order.userName;
            temp += "\",\"";
            temp += order.userId;
            temp += "\",\"";
            temp += order.goodsId;
            temp += "\",\"";
            temp += order.address;
            temp += "\",\"";
            temp += order.phone;
            temp += "\",";
            temp += order.price;
            temp += ",\"";
            temp += order.goodsName;
            temp += "\",";
            temp += order.flag;
            temp += ")";
            WriteSqlSentence(temp); 
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
        public bool addUser(Users user)
        {
            string temp = "insert into users values (\"";
            temp += user.userId;
            temp += "\",\"";
            temp += user.passWord;
            temp += "\",";
            temp += user.type;
            temp += ",\"";
            temp += user.nickName;
            temp += "\",\"";
            temp += user.birthday;
            temp += "\",\"";
            temp += user.address;
            temp += "\",\"";
            temp += user.phone;
            temp += "\",";
            temp += user.sex;
            temp += ")";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }

        //通过Id号删除表中一条数据
        public bool delGoods(string goodsId)
        {
            WriteSqlSentence("delete from goodss where goodsId=\"" + goodsId + "\";");
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
        public bool delUser(string userId)
        {
            WriteSqlSentence("delete from users where userId=\"" + userId + "\";");
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
        public bool delOrder(string orderId)
        {
            WriteSqlSentence("delete from users where orderId=\"" + orderId + "\";");
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }

        //通过对象修改表数据
        public bool reGoods(Goodss goods)
        {
            string temp = "update goodss set ";
            temp += "goodsId=\"";
            temp += goods.goodsId;
            temp += "\",goodsName=\"";
            temp += goods.goodsName;
            temp += "\",price=";
            temp += goods.price;
            temp += ",type=";
            temp += goods.type;
            temp += ",color=\"";
            temp += goods.color;
            temp += "\",tatse=\"";
            temp += goods.tatse;
            temp += "\",size=";
            temp += goods.size;
            temp += ",batching=\"";
            temp += goods.batching;
            temp += "\",introduce=\"";
            temp += goods.introduce;
            temp += "\",toBadTime=\"";
            temp += goods.toBadTime;
            temp += "\",flag=";
            temp += goods.flag;
            temp += " where goodsId=\"";
            temp += goods.goodsId;
            temp += "\"";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
        public bool reOrder(Orders order)
        {
            string temp = "update orders set ";
            temp += "orderId=\"";
            temp += order.orderId;
            temp += "\",goodsNum=";
            temp += order.goodsNum;
            temp += ",userName=\"";
            temp += order.userName;
            temp += "\",userId=\"";
            temp += order.userId;
            temp += "\",goodsId=\"";
            temp += order.goodsId;
            temp += "\",address=\"";
            temp += order.address;
            temp += "\",phone=\"";
            temp += order.phone;
            temp += "\",price=";
            temp += order.price;
            temp += ",goodsName=\"";
            temp += order.goodsName;
            temp += "\",flag=";
            temp += order.flag;
            temp += " where orderId=\"";
            temp += order.orderId;
            temp += "\"";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
        public bool reUser(Users user)
        {
            string temp = "update orders set ";
            temp += "userId=\"";
            temp += user.userId;
            temp += "\",passWord=\"";
            temp += user.passWord;
            temp += "\",type=";
            temp += user.type;
            temp += ",nickName=\"";
            temp += user.nickName;
            temp += "\",birthday=\"";
            temp += user.birthday;
            temp += "\",address=\"";
            temp += user.address;
            temp += "\",phone=\"";
            temp += user.phone;
            temp += "\",sex=";
            temp += user.sex;
            temp += " where userId=\"";
            temp += user.userId;
            temp += "\"";
            WriteSqlSentence(temp);
            bool vo = mysql.ExecuteNonQuery();
            //select();
            return vo;
        }
    }
}