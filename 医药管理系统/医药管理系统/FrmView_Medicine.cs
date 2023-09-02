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
    public partial class FrmView_Medicine : Form
    {
        public FrmView_Medicine()
        {
            InitializeComponent();
        }


        //绘制时发生事件
        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            new DataGridViewStyle().DgvRowPostPaint(this.dgv, e);   //给表格添加上行号
        }


        //查询按钮
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //测试
            this.dgv.Columns.Clear();
            this.dgv.AutoGenerateColumns = true;
            string sqlCondition = GetSqlCondition();
            DataTable ds = new InfoManager().GetMedicineInfo(sqlCondition);
            if(ds.Rows.Count == 0)  //没有查询到数据

            {
                MessageBox.Show("没有内容");
                return;
            }
            this.dgv.DataSource = ds;
            this.dgv.Refresh();
        }



        /// <summary>
        /// 判断选择的框获取sql语句
        /// </summary>
        /// <returns></returns>
        private string GetSqlCondition()
        {
            bool isNull = false;    //判断应该返回空值
            bool isAnd = false; //判断是否有添加
            string sqlCondition = " where ";

            if (this.txt_mno.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                sqlCondition += "mno=" + "'" + this.txt_mno.Text.Trim() + "' ";
                isNull = true;
            }

            if (this.txt_mname.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                sqlCondition += "mname=" + "'" + this.txt_mname.Text.Trim() + "' ";
                isNull = true;
            }

            if (this.txt_mefficacy.Text.Length > 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                sqlCondition += "mefficacy=" + "'" + this.txt_mefficacy.Text.Trim() + "' ";
                isNull = true;
            }

            if(this.cmb_mmode.SelectedIndex == 0)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                sqlCondition += "mmode=" + "'内服' ";
                isNull = true;
            }
            if (this.cmb_mmode.SelectedIndex == 1)
            {
                if (isAnd)
                    sqlCondition += " and ";
                isAnd = true;
                sqlCondition += "mmode=" + "'外用' ";
                isNull = true;
            }


            if (isNull)
                return sqlCondition;
            else
                return null;
        }
    }
}
