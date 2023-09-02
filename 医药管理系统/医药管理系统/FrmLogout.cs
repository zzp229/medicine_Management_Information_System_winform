using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using Models;

namespace UI
{
    public partial class FrmLogout : Form
    {
        public FrmLogout()
        {
            InitializeComponent();
        }


        //验证密码
        private void btn_Verify_Click(object sender, EventArgs e)
        {
            Admin admin = Tag as Admin;
            admin.LoginPwd = this.txt_pwd.Text.Trim();  //更新密码
            LoginManager loginManager = new LoginManager();
            if(loginManager.CheckIdPwd(admin) == UserState.PwdError)
            {
                MessageBox.Show("密码错误！,请确认这个是你的账户");
                this.Close();
            }
            else
            {
                //密码对了才删除账户
                if (loginManager.DeleteAcount(admin) >= 0)
                {
                    MessageBox.Show("注销成功！");
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("注销失败！");
                
                this.Close();
            }
        }
    }
}
