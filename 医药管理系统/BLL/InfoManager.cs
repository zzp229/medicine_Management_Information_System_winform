﻿using DAL;
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
            //这里只是测试
            string sql = "select * from client;";
            DataTable dt = SQLHelper.GetDataSet(sql).Tables[0];
            return dt;
        }
    }
}
