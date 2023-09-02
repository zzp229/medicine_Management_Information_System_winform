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


        /// <summary>
        /// 使用部分参数的获取DataSet，第二个参数可传可不传
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if(parameters.Count() >  0)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        try
                        {
                            conn.Open();
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet);

                            return dataSet;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        
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


        /// <summary>
        /// 修改后的
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int Update(string sql, SqlParameter[] parameters)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddRange(parameters);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
