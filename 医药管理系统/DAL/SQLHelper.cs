using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SQLHelper
    {
        //配置文件中获取登录信息
        public static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;


        public static DataSet GetDataSet(string sql)
        {
            //创建连接器
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)    //异常向上抛出
            {
                throw ex;
            }
            finally { conn.Close(); }   
        }

       
        /// <summary>
        /// SQL的Update命令
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>影响的条数</returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        }
    }
}
