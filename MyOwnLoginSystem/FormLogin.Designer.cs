namespace MyOwnLoginSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnForgetPwd = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(115, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(115, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(48, 178);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(140, 57);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(254, 178);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(154, 57);
            this.BtnRegister.TabIndex = 3;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(450, 178);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(166, 57);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnForgetPwd
            // 
            this.BtnForgetPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnForgetPwd.Location = new System.Drawing.Point(503, 50);
            this.BtnForgetPwd.Name = "BtnForgetPwd";
            this.BtnForgetPwd.Size = new System.Drawing.Size(170, 49);
            this.BtnForgetPwd.TabIndex = 5;
            this.BtnForgetPwd.Text = "忘记密码";
            this.BtnForgetPwd.UseVisualStyleBackColor = true;
            this.BtnForgetPwd.Click += new System.EventHandler(this.BtnForgetPwd_Click);
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtID.Location = new System.Drawing.Point(254, 50);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(208, 44);
            this.TxtID.TabIndex = 6;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwd.Location = new System.Drawing.Point(254, 115);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '▪';
            this.TxtPwd.Size = new System.Drawing.Size(208, 44);
            this.TxtPwd.TabIndex = 7;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(693, 292);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnForgetPwd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnForgetPwd;
        public System.Windows.Forms.TextBox TxtID;//为了在重置之后可以不需要在输入用户名, 所以public了
        private System.Windows.Forms.TextBox TxtPwd;
    }
}