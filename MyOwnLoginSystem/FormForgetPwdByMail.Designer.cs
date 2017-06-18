namespace MyOwnLoginSystem
{
    partial class FormForgetPwdByMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgetPwdByMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSendMail = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtMailAddress = new System.Windows.Forms.TextBox();
            this.TxtVttCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(95, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "邮箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(95, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "验证码";
            // 
            // BtnOK
            // 
            this.BtnOK.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(91, 426);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(165, 73);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "确认重置";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(402, 426);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(165, 73);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSendMail
            // 
            this.BtnSendMail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSendMail.ForeColor = System.Drawing.Color.Red;
            this.BtnSendMail.Location = new System.Drawing.Point(189, 224);
            this.BtnSendMail.Name = "BtnSendMail";
            this.BtnSendMail.Size = new System.Drawing.Size(299, 70);
            this.BtnSendMail.TabIndex = 5;
            this.BtnSendMail.Text = "发送验证邮件";
            this.BtnSendMail.UseVisualStyleBackColor = true;
            this.BtnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtID.Location = new System.Drawing.Point(297, 42);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(270, 44);
            this.TxtID.TabIndex = 6;
            // 
            // TxtMailAddress
            // 
            this.TxtMailAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtMailAddress.Location = new System.Drawing.Point(297, 148);
            this.TxtMailAddress.Name = "TxtMailAddress";
            this.TxtMailAddress.ReadOnly = true;
            this.TxtMailAddress.Size = new System.Drawing.Size(270, 44);
            this.TxtMailAddress.TabIndex = 7;
            // 
            // TxtVttCode
            // 
            this.TxtVttCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtVttCode.Location = new System.Drawing.Point(297, 338);
            this.TxtVttCode.Name = "TxtVttCode";
            this.TxtVttCode.Size = new System.Drawing.Size(270, 44);
            this.TxtVttCode.TabIndex = 8;
            // 
            // FormForgetPwdByMail
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(664, 529);
            this.Controls.Add(this.TxtVttCode);
            this.Controls.Add(this.TxtMailAddress);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnSendMail);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormForgetPwdByMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重置密码";
            this.Load += new System.EventHandler(this.FormForgetPwdByMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 此Form内部的验证码
        /// </summary>
        private string PrivateStrVttCode = string.Empty;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSendMail;
        public System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtMailAddress;
        private System.Windows.Forms.TextBox TxtVttCode;
    }
}