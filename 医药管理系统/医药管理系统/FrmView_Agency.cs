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

namespace UI
{
    public partial class FrmView_Agency : Form
    {
        public FrmView_Agency()
        {
            InitializeComponent();
        }

        


        //查询按钮
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //测试
            this.dgv.Columns.Clear();
            this.dgv.AutoGenerateColumns = true;
            string sqlConditon = GetSqlCondition();
            DataTable ds = new InfoManager().GetAgencyInfo(sqlConditon);
            if (ds.Rows.Count == 0)  //没有查询到数据
            {
                MessageBox.Show("没有内容");
                return;
            }
            this.dgv.DataSource = ds;
            this.dgv.Refresh();
        }


        //绘制时发生事件
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(this.dgv, e);   //给表格添加上行号
        }

        private void FrmView_Agency_Load(object sender, EventArgs e)
        {
            this.cmb_asex.SelectedIndex = -1;
        }


        /// <summary>
        /// 判断选择的框获取sql语句
        /// </summary>
        /// <returns></returns>
        private string GetSqlCondition()
        {
            bool isNull = false;    //判断是否有条件
            bool isAnd = false; //判断是否有添加
            string sqlCondition = " where ";

            if (this.txt_ano.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "ano=" + "'" + this.txt_ano.Text.Trim() + "' "; 
            }
                
            if (this.txt_aname.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "aname=" + "'" + this.txt_aname.Text.Trim() + "' "; 
            }
                
            if (this.cmb_asex.SelectedIndex == 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "asex=" + "'男' "; 
            }
                
            if (this.cmb_asex.SelectedIndex == 1)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "asex=" + "'女' "; 
            }
                
            if (this.txt_aphone.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "aphone=" + "'" + this.txt_aphone.Text.Trim() + "' "; 
            }
                
            if (this.txt_aremark.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                isNull = true;
                sqlCondition += "aremark=" + "'" + this.txt_aremark.Text.Trim() + "' "; 
            }
                

            if (isNull)
                return sqlCondition;
            else
                return null;
        }
    }
}
