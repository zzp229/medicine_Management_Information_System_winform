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
            this.cmb_Inquire.SelectedIndex = 2;
        }

        //查询按钮
        private void btn_Query_Click(object sender, EventArgs e)
        {
            if(cmb_Inquire.SelectedIndex == 0)
            {
                FrmView_Client frmView = new FrmView_Client();
                frmView.ShowDialog();
            } 
            else if (cmb_Inquire.SelectedIndex == 1)
            {
                FrmView_Agency frmView_Agency = new FrmView_Agency();
                frmView_Agency.ShowDialog();
            }
            else
            {
                FrmView_Medicine frmView_Medicine = new FrmView_Medicine();
                frmView_Medicine.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                Console.WriteLine(item.Text);
            }
        }


        //注销该账号
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("是否确认注销该账号！", "注销提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                FrmLogout frmLogout = new FrmLogout();
                frmLogout.Tag = Tag;    //这个窗口的Tag装的也是这个类
                DialogResult = frmLogout.ShowDialog();
                if(DialogResult == DialogResult.OK) 
                {
                    this.Close();
                }
            }
        }


        //关闭时发生
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
