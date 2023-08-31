namespace 医药管理系统
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Inquire = new System.Windows.Forms.ComboBox();
            this.btn_Query = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CheckIn = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_line = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询：";
            // 
            // cmb_Inquire
            // 
            this.cmb_Inquire.FormattingEnabled = true;
            this.cmb_Inquire.Location = new System.Drawing.Point(113, 115);
            this.cmb_Inquire.Name = "cmb_Inquire";
            this.cmb_Inquire.Size = new System.Drawing.Size(121, 25);
            this.cmb_Inquire.TabIndex = 1;
            // 
            // btn_Query
            // 
            this.btn_Query.Location = new System.Drawing.Point(113, 156);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(75, 34);
            this.btn_Query.TabIndex = 2;
            this.btn_Query.Text = "查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "录入";
            // 
            // cmb_CheckIn
            // 
            this.cmb_CheckIn.FormattingEnabled = true;
            this.cmb_CheckIn.Location = new System.Drawing.Point(331, 115);
            this.cmb_CheckIn.Name = "cmb_CheckIn";
            this.cmb_CheckIn.Size = new System.Drawing.Size(121, 25);
            this.cmb_CheckIn.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "录入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_line
            // 
            this.lbl_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_line.Location = new System.Drawing.Point(53, 62);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(576, 1);
            this.lbl_line.TabIndex = 3;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.Location = new System.Drawing.Point(216, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(194, 22);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "欢迎***登录医药管理系统";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "注销";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 505);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.cmb_CheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Inquire);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主页";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Inquire;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_CheckIn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button3;
    }
}

