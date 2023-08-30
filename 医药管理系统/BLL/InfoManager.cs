using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InfoManager
    {
        public DataTable GetClientInfo()
        {
            string sql = "select * from client;";
            DataTable dt = SQLHelper.GetDataSet(sql).Tables[0];
            return dt;
        }
    }
}
