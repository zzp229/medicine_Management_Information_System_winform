using Models;
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

namespace 医药管理系统
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }



        //登录按钮
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //判断是否为空
            string LoginId = this.txt_LoginId.Text.Trim();
            string LoginPwd = this.txt_LoginPwd.Text.Trim();

            if (string.IsNullOrEmpty(LoginId))
            {
                MessageBox.Show("账号不能为空！");
                txt_LoginId.Focus();
                return;
            }

            if (string.IsNullOrEmpty(LoginPwd))
            {
                MessageBox.Show("密码不能为空！");
                txt_LoginPwd.Focus();
                return;
            }

            Admin admin = new Admin()  //封装账号和密码
            {
                LoginId = this.txt_LoginId.Text.Trim(),
                LoginPwd = this.txt_LoginPwd.Text.Trim(),
            };

            //验证账号和密码是否正确
            LoginManager loginManager = new LoginManager(); //调用Manager类
            
            if(loginManager.CheckIdPwd(admin) == UserState.NoExist)
            {
                MessageBox.Show("该账号未注册");
            } 
            else if(loginManager.CheckIdPwd(admin)==UserState.PwdError)
            {
                MessageBox.Show("密码错误！");
            }
            else
            {
                Tag = loginManager.GetAdmin(admin); //将当前用户的信息传出去
                FrmMain frmMain = new FrmMain(Tag);
                frmMain.Show();
                
                //初始化窗口
                this.txt_LoginId.Text = null;
                this.txt_LoginPwd.Text = null;

            }
           
        }


        //退出
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        //注册按钮
        private void btn_Register_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }
    }
}
