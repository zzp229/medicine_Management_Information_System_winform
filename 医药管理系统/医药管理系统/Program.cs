using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医药管理系统
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            FrmLogin logIn = new FrmLogin();
            logIn.ShowDialog();
            if(logIn.DialogResult == DialogResult.OK )
            {
                logIn.Close();
                Application.Run(new FrmMain());
            }
            
        }
    }
}
