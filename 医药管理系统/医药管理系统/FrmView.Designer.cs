namespace UI
{
    partial class FrmView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Query = new System.Windows.Forms.TextBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.lbl_line = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_ToExcel = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入查询的信息：";
            // 
            // txt_Query
            // 
            this.txt_Query.Location = new System.Drawing.Point(137, 84);
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.Size = new System.Drawing.Size(100, 23);
            this.txt_Query.TabIndex = 1;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(248, 84);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 23);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
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
            this.lbl_title.Location = new System.Drawing.Point(298, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(83, 17);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "***的信息查询";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(28, 125);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(726, 314);
            this.dgv.TabIndex = 5;
            // 
            // btn_ToExcel
            // 
            this.btn_ToExcel.Location = new System.Drawing.Point(484, 466);
            this.btn_ToExcel.Name = "btn_ToExcel";
            this.btn_ToExcel.Size = new System.Drawing.Size(102, 23);
            this.btn_ToExcel.TabIndex = 6;
            this.btn_ToExcel.Text = "导出到Excel";
            this.btn_ToExcel.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(610, 466);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(75, 23);
            this.btn_Report.TabIndex = 6;
            this.btn_Report.Text = "报表";
            this.btn_Report.UseVisualStyleBackColor = true;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(703, 466);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 6;
            this.btn_Print.Text = "打印";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // FrmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 508);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_ToExcel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmView";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Query;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_ToExcel;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Print;
    }
}