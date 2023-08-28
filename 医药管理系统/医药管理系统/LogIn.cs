using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医药管理系统
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }



        //登录按钮
        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
