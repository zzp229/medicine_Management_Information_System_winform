namespace UI
{
    partial class FrmView_Medicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_line = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_ToExcel = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mefficacy = new System.Windows.Forms.TextBox();
            this.cmb_mmode = new System.Windows.Forms.ComboBox();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.txt_mno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Query = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_line
            // 
            this.lbl_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_line.Location = new System.Drawing.Point(28, 38);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(726, 1);
            this.lbl_line.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(315, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(80, 17);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "药品信息查询";
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(18, 224);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(462, 314);
            this.dgv.TabIndex = 5;
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // btn_ToExcel
            // 
            this.btn_ToExcel.Location = new System.Drawing.Point(196, 566);
            this.btn_ToExcel.Name = "btn_ToExcel";
            this.btn_ToExcel.Size = new System.Drawing.Size(102, 23);
            this.btn_ToExcel.TabIndex = 6;
            this.btn_ToExcel.Text = "导出到Excel";
            this.btn_ToExcel.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(322, 566);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(75, 23);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.Text = "报表";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(415, 566);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "打印";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mefficacy);
            this.groupBox1.Controls.Add(this.cmb_mmode);
            this.groupBox1.Controls.Add(this.txt_mname);
            this.groupBox1.Controls.Add(this.txt_mno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Query);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择查询的信息(默认查询全部)：";
            // 
            // txt_mefficacy
            // 
            this.txt_mefficacy.Location = new System.Drawing.Point(225, 69);
            this.txt_mefficacy.Name = "txt_mefficacy";
            this.txt_mefficacy.Size = new System.Drawing.Size(110, 23);
            this.txt_mefficacy.TabIndex = 3;
            // 
            // cmb_mmode
            // 
            this.cmb_mmode.FormattingEnabled = true;
            this.cmb_mmode.Items.AddRange(new object[] {
            "内服",
            "外用"});
            this.cmb_mmode.Location = new System.Drawing.Point(240, 22);
            this.cmb_mmode.Name = "cmb_mmode";
            this.cmb_mmode.Size = new System.Drawing.Size(95, 25);
            this.cmb_mmode.TabIndex = 2;
            // 
            // txt_mname
            // 
            this.txt_mname.Location = new System.Drawing.Point(55, 69);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(100, 23);
            this.txt_mname.TabIndex = 1;
            // 
            // txt_mno
            // 
            this.txt_mno.Location = new System.Drawing.Point(55, 28);
            this.txt_mno.Name = "txt_mno";
            this.txt_mno.Size = new System.Drawing.Size(100, 23);
            this.txt_mno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "功效：";
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(377, 69);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 0;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "服用方法：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "编号：";
            // 
            // FrmView_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_ToExcel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_line);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmView_Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_ToExcel;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mefficacy;
        private System.Windows.Forms.ComboBox cmb_mmode;
        private System.Windows.Forms.TextBox txt_mname;
        private System.Windows.Forms.TextBox txt_mno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}