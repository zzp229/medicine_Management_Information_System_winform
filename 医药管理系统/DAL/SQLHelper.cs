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

        //public static DataSet GetDataSet(string sql, SqlParameter[] parameters)
        //{
        //    //SqlConnection conn = new SqlConnection(connStr);
        //    //SqlCommand cmd = conn.CreateCommand();
        //    //cmd.CommandText = sql;
        //    //cmd.Parameters.AddRange(parameters);

        //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    //DataSet ds = new DataSet();
        //    //try
        //    //{
        //    //    conn.Open();
        //    //    da.Fill(ds);
        //    //    return ds;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw ex;
        //    //}

        //    using(SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.Add(parameters);
        //        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
        //        {
        //            try
        //            {
        //                conn.Open();
        //                DataSet ds = new DataSet();
        //                da.Fill(ds);
        //                return ds;
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }

        //        }
        //    }
        //}

       
        public static DataSet GetDataSet(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);

                        return dataSet;
                    }
                }
            }
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
