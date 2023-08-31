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
using UI;

namespace 医药管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(object tag)
        {
            InitializeComponent();
            this.Tag = tag;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //没有创建公共静态类，使用Tag传递
            Admin admin = Tag as Admin;
            this.lbl_Title.Text = "欢迎" + admin.LoginName + "登录医药管理系统";
        }

        //查询按钮
        private void btn_Query_Click(object sender, EventArgs e)
        {
            FrmView frmView = new FrmView();
            frmView.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                Console.WriteLine(item.Text);
            }
        }
    }
}
