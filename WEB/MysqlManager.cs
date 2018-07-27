using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System;
using MySql.Data.MySqlClient;
using System.Data;

/// <summary>
///MysqlManager 的摘要说明
/// </summary>
/// 

namespace mysql
{
    public class MysqlManager
    {

        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private MySqlDataReader sdr = null;

        public MysqlManager()
        {
            string connStr = "server=127.0.0.1;database=bread_fantasy;uid=root;pwd=960923;charset=utf8";
            conn = new MySqlConnection(connStr);
        }


        /// <summary>创建Command对象 
        /// 
        /// </summary> 
        /// <param name="sql">SQL语句</param> 
        public void CreateCommand(string sql)
        {
            conn.Open();
            cmd = new MySqlCommand(sql, conn);
        }


        /// <summary>添加参数 
        /// 
        /// </summary> 
        /// <param name="paramName">参数名称</param> 
        /// <param name="value">值</param> 
        public void AddParameter(string paramName, object value)
        {
            cmd.Parameters.Add(new MySqlParameter(paramName, value));
        }


        /// <summary>执行不带参数的增删改SQL语句 
        /// 
        /// </summary> 
        /// <param name="cmdText">增删改SQL语句</param> 
        /// <param name="ct">命令类型</param> 
        /// <returns></returns> 

        public bool ExecuteNonQuery()
        {
            int res;
            try
            {
                res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                //...
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }

        public DataSet getDataSet()
        {
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet set = new DataSet();
            ada.Fill(set);
            return set;
        }

        /// <summary>执行查询SQL语句 
        /// 
        /// </summary> 
        /// <param name="cmdText">查询SQL语句</param> 
        /// <returns></returns> 
        public DataTable ExecuteQuery()
        {
            DataTable dt = new DataTable();
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }

        public int testUserTrue(string userId, string passWd)
        {
            string sqlStr = "select type from users where userId = '" + userId + "' and passWord = '" + passWd + "'";
            CreateCommand(sqlStr);
            sqlStr = ExecuteScalar();
            if (sqlStr == null || sqlStr == "")
                return -1;
            return int.Parse(sqlStr);
        }


        /// <summary>返回查询SQL语句查询出的结果的第一行第一列的值 
        /// 
        /// </summary> 
        /// <returns></returns> 
        public string ExecuteScalar()
        {
            string res = "";
            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    res = obj.ToString();
                }
            }
            catch (Exception)
            {
                //...
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return res;
        }
    }
}