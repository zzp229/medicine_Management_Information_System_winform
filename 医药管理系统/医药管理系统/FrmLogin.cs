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
            //this.DialogResult = DialogResult.OK;
            //这里的登录逻辑还需要优化一下
            
            //判断是否为空
            if(this.txt_LoginId.Text.Trim()=="" || this.txt_LoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("账号或密码不能为空！");
            }
            else
            {
                Admin admin = new Admin()  //封装账号和密码
                {
                    LoginId = this.txt_LoginId.Text.Trim(),
                    LoginPwd = this.txt_LoginPwd.Text.Trim(),
                };

                //验证账号和密码是否正确
                LoginManager loginManager = new LoginManager(); //调用Manager类
                if(loginManager.CheckIdPwd(admin) == UserState.NoExist)
                {
                    MessageBox.Show("请验证账号是否填写正确");
                } 
                else if(loginManager.CheckIdPwd(admin)==UserState.PwdError)
                {
                    MessageBox.Show("密码错误！");
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }
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
