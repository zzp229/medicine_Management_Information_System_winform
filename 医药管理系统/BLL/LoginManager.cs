using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    /// <summary>
    /// 用户登录的枚举类型
    /// </summary>
    public enum UserState
    {
        Ok,
        NoExist,
        PwdError
    }

    /// <summary>
    /// 登录管理类
    /// </summary>
    public class LoginManager
    {
        /// <summary>
        /// 验证是否有这个账号和密码是否正确
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserState CheckIdPwd(Admin user)
        {
            string sql = "select * from users where LoginId = '{0}';";
            sql = string.Format(sql, user.LoginId);
            DataSet dataSet = SQLHelper.GetDataSet(sql);

            //先判断是否有这个账号
            if (dataSet.Tables[0].Rows.Count == 0)
            {
                return UserState.NoExist;
            }

            ///好像没有返回空

            //判断密码是否正确
            string pwdFromSql = dataSet.Tables[0].Rows[0]["LoginPwd"].ToString();
            if(pwdFromSql != user.LoginPwd)
            {
                return UserState.PwdError;
            }

            //全部正确，可以登录
            return UserState.Ok;
        }


        /// <summary>
        /// 新账户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>返回影响的条数</returns>
        public int NewRole(Admin user)
        {
            string sql = "insert into users values('{0}', '{1}', '{2}', {3});";
            sql = string.Format(sql, user.LoginId, user.LoginName, user.LoginPwd, user.Role);
            return SQLHelper.Update(sql);
        }
    }
}
