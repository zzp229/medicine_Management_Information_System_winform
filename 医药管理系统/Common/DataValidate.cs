using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 验证通用类
    /// </summary>
    public class DataValidate
    {
        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsInteger(string txt)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(txt);
        }

        /// <summary>
        /// 验证密码是否符合要求
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsPwd(string txt)
        {
            Regex objReg = new Regex(@"^(?![0-9]+$)(?![a-zA-Z]+$)[0-9A-Za-z]{8,16}$");
            return objReg.IsMatch(txt);
        }
    }
}
