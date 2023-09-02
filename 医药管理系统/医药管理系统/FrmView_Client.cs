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
    public partial class FrmView_Client : Form
    {
        public FrmView_Client()
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
            DataTable ds = new InfoManager().GetClientInfo();
            this.dgv.DataSource = ds;
            this.dgv.Refresh();
        }
    }
}
