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

namespace 医药管理系统
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }


        //注册按钮
        private void btn_Register_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin()
            {
                LoginId = this.txt_LoginId.Text.Trim(),
                LoginPwd = this.txt_LoginName.Text.Trim(),
                Role = Convert.ToInt32(this.cmb_Role.SelectedIndex),
                LoginName = this.txt_LoginName.Text.Trim()
            };

            int count = new LoginManager().NewRole(admin);
            if(count > 0) 
            {
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("该账号已注册");
            }
        }
    }
}
