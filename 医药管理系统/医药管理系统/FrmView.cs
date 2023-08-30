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
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }


        //查询按钮
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //测试
            this.dgv.Rows.Clear();
            this.dgv.Columns.Clear();
            this.dgv.AutoGenerateColumns = true;
            DataTable ds = new InfoManager().GetClientInfo();
            this.dgv.DataSource = ds;
            this.dgv.Refresh();
        }
    }
}
