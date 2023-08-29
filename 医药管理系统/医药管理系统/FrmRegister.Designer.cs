namespace 医药管理系统
{
    partial class FrmRegister
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_LoginId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LoginPwd = new System.Windows.Forms.TextBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(103, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户注册";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入一下信息进行注册";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "角色";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(43, 124);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(75, 23);
            this.txt_LoginName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "账号";
            // 
            // txt_LoginId
            // 
            this.txt_LoginId.Location = new System.Drawing.Point(43, 182);
            this.txt_LoginId.Name = "txt_LoginId";
            this.txt_LoginId.Size = new System.Drawing.Size(198, 23);
            this.txt_LoginId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "密码";
            // 
            // txt_LoginPwd
            // 
            this.txt_LoginPwd.Location = new System.Drawing.Point(43, 260);
            this.txt_LoginPwd.Name = "txt_LoginPwd";
            this.txt_LoginPwd.Size = new System.Drawing.Size(198, 23);
            this.txt_LoginPwd.TabIndex = 2;
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(94, 312);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 31);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "立即注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(157, 124);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(84, 25);
            this.cmb_Role.TabIndex = 5;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.cmb_Role);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_LoginPwd);
            this.Controls.Add(this.txt_LoginId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_LoginId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LoginPwd;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.ComboBox cmb_Role;
    }
}