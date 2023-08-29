namespace 医药管理系统
{
    partial class FrmLogin
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
            this.txt_LoginId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoginPwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // txt_LoginId
            // 
            this.txt_LoginId.Location = new System.Drawing.Point(164, 56);
            this.txt_LoginId.Margin = new System.Windows.Forms.Padding(6);
            this.txt_LoginId.Name = "txt_LoginId";
            this.txt_LoginId.Size = new System.Drawing.Size(180, 33);
            this.txt_LoginId.TabIndex = 1;
            this.txt_LoginId.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // txt_LoginPwd
            // 
            this.txt_LoginPwd.Location = new System.Drawing.Point(164, 101);
            this.txt_LoginPwd.Margin = new System.Windows.Forms.Padding(6);
            this.txt_LoginPwd.Name = "txt_LoginPwd";
            this.txt_LoginPwd.PasswordChar = '*';
            this.txt_LoginPwd.Size = new System.Drawing.Size(180, 33);
            this.txt_LoginPwd.TabIndex = 1;
            this.txt_LoginPwd.Text = "root123";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(102, 189);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(81, 31);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(231, 189);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(81, 31);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Register.Location = new System.Drawing.Point(164, 235);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 25);
            this.btn_Register.TabIndex = 3;
            this.btn_Register.Text = "注册";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 283);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_LoginPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_LoginId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LoginId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LoginPwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Register;
    }
}