namespace MyOwnLoginSystem
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNickName = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtPwdConfirm = new System.Windows.Forms.TextBox();
            this.TxtMailAddress = new System.Windows.Forms.TextBox();
            this.TxtVerticationCode = new System.Windows.Forms.TextBox();
            this.CmbPwdQuestion = new System.Windows.Forms.ComboBox();
            this.TxtPwdAnswer = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnShowPwd = new System.Windows.Forms.Button();
            this.BtnSendMail = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LstMailAddress = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PicAvatar = new System.Windows.Forms.PictureBox();
            this.BtnUploadAvatar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(61, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "昵称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(61, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码确认";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(61, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "邮箱";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(47, 760);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "验证码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(7, 860);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 33);
            this.label7.TabIndex = 6;
            this.label7.Text = "密码提示问题";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(61, 958);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 33);
            this.label8.TabIndex = 7;
            this.label8.Text = "答案";
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtID.Location = new System.Drawing.Point(249, 40);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(222, 44);
            this.TxtID.TabIndex = 1;
            // 
            // TxtNickName
            // 
            this.TxtNickName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNickName.Location = new System.Drawing.Point(247, 322);
            this.TxtNickName.Name = "TxtNickName";
            this.TxtNickName.Size = new System.Drawing.Size(222, 44);
            this.TxtNickName.TabIndex = 2;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwd.Location = new System.Drawing.Point(247, 412);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '▪';
            this.TxtPwd.Size = new System.Drawing.Size(222, 44);
            this.TxtPwd.TabIndex = 3;
            // 
            // TxtPwdConfirm
            // 
            this.TxtPwdConfirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwdConfirm.Location = new System.Drawing.Point(247, 508);
            this.TxtPwdConfirm.Name = "TxtPwdConfirm";
            this.TxtPwdConfirm.PasswordChar = '▪';
            this.TxtPwdConfirm.Size = new System.Drawing.Size(222, 44);
            this.TxtPwdConfirm.TabIndex = 4;
            // 
            // TxtMailAddress
            // 
            this.TxtMailAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtMailAddress.Location = new System.Drawing.Point(211, 598);
            this.TxtMailAddress.Name = "TxtMailAddress";
            this.TxtMailAddress.Size = new System.Drawing.Size(310, 44);
            this.TxtMailAddress.TabIndex = 5;
            this.TxtMailAddress.TextChanged += new System.EventHandler(this.TxtMailAddress_TextChanged);
            this.TxtMailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMailAddress_KeyPress);
            // 
            // TxtVerticationCode
            // 
            this.TxtVerticationCode.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtVerticationCode.Location = new System.Drawing.Point(247, 760);
            this.TxtVerticationCode.Name = "TxtVerticationCode";
            this.TxtVerticationCode.Size = new System.Drawing.Size(222, 44);
            this.TxtVerticationCode.TabIndex = 6;
            // 
            // CmbPwdQuestion
            // 
            this.CmbPwdQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPwdQuestion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbPwdQuestion.FormattingEnabled = true;
            this.CmbPwdQuestion.Items.AddRange(new object[] {
            "喜欢的人",
            "父母的姓名",
            "宿舍号"});
            this.CmbPwdQuestion.Location = new System.Drawing.Point(247, 860);
            this.CmbPwdQuestion.Name = "CmbPwdQuestion";
            this.CmbPwdQuestion.Size = new System.Drawing.Size(243, 41);
            this.CmbPwdQuestion.TabIndex = 7;
            // 
            // TxtPwdAnswer
            // 
            this.TxtPwdAnswer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwdAnswer.Location = new System.Drawing.Point(247, 958);
            this.TxtPwdAnswer.Name = "TxtPwdAnswer";
            this.TxtPwdAnswer.Size = new System.Drawing.Size(222, 44);
            this.TxtPwdAnswer.TabIndex = 8;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(101, 1051);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(138, 62);
            this.BtnRegister.TabIndex = 9;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnShowPwd
            // 
            this.BtnShowPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShowPwd.Location = new System.Drawing.Point(508, 402);
            this.BtnShowPwd.Name = "BtnShowPwd";
            this.BtnShowPwd.Size = new System.Drawing.Size(84, 162);
            this.BtnShowPwd.TabIndex = 10;
            this.BtnShowPwd.Text = "显示密码";
            this.BtnShowPwd.UseVisualStyleBackColor = true;
            this.BtnShowPwd.MouseLeave += new System.EventHandler(this.BtnShowPwd_MouseLeave);
            this.BtnShowPwd.MouseHover += new System.EventHandler(this.BtnShowPwd_MouseHover);
            // 
            // BtnSendMail
            // 
            this.BtnSendMail.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSendMail.ForeColor = System.Drawing.Color.Red;
            this.BtnSendMail.Location = new System.Drawing.Point(167, 669);
            this.BtnSendMail.Name = "BtnSendMail";
            this.BtnSendMail.Size = new System.Drawing.Size(239, 62);
            this.BtnSendMail.TabIndex = 11;
            this.BtnSendMail.Text = "发送验证邮件";
            this.BtnSendMail.UseVisualStyleBackColor = true;
            this.BtnSendMail.Click += new System.EventHandler(this.BtnSendMail_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(373, 1051);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(148, 62);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LstMailAddress
            // 
            this.LstMailAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LstMailAddress.FormattingEnabled = true;
            this.LstMailAddress.ItemHeight = 33;
            this.LstMailAddress.Location = new System.Drawing.Point(211, 638);
            this.LstMailAddress.Name = "LstMailAddress";
            this.LstMailAddress.Size = new System.Drawing.Size(310, 169);
            this.LstMailAddress.TabIndex = 13;
            this.LstMailAddress.Visible = false;
            this.LstMailAddress.Click += new System.EventHandler(this.LstMailAddress_Click);
            this.LstMailAddress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LstMailAddress_MouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(73, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 33);
            this.label9.TabIndex = 14;
            this.label9.Text = "头像";
            // 
            // PicAvatar
            // 
            this.PicAvatar.InitialImage = global::MyOwnLoginSystem.Properties.Resources.题_1_灰;
            this.PicAvatar.Location = new System.Drawing.Point(249, 122);
            this.PicAvatar.Name = "PicAvatar";
            this.PicAvatar.Size = new System.Drawing.Size(222, 160);
            this.PicAvatar.TabIndex = 15;
            this.PicAvatar.TabStop = false;
            // 
            // BtnUploadAvatar
            // 
            this.BtnUploadAvatar.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnUploadAvatar.Location = new System.Drawing.Point(508, 122);
            this.BtnUploadAvatar.Name = "BtnUploadAvatar";
            this.BtnUploadAvatar.Size = new System.Drawing.Size(75, 160);
            this.BtnUploadAvatar.TabIndex = 16;
            this.BtnUploadAvatar.Text = "上传头像";
            this.BtnUploadAvatar.UseVisualStyleBackColor = true;
            this.BtnUploadAvatar.Click += new System.EventHandler(this.BtnUploadAvatar_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(614, 1229);
            this.Controls.Add(this.BtnUploadAvatar);
            this.Controls.Add(this.PicAvatar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LstMailAddress);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSendMail);
            this.Controls.Add(this.BtnShowPwd);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtPwdAnswer);
            this.Controls.Add(this.CmbPwdQuestion);
            this.Controls.Add(this.TxtVerticationCode);
            this.Controls.Add(this.TxtMailAddress);
            this.Controls.Add(this.TxtPwdConfirm);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtNickName);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 此Form内部的VttCode
        /// </summary>
        private string strVttCode = string.Empty;

        /// <summary>
        /// 存储熊数据库读取的MailDomain
        /// </summary>
        private string[] straMailDomain = new string[20];

        /// <summary>
        /// 有多少的MailDomain
        /// </summary>
        private int intMailDomainCows = 0;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtNickName;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtPwdConfirm;
        private System.Windows.Forms.TextBox TxtMailAddress;
        private System.Windows.Forms.TextBox TxtVerticationCode;
        private System.Windows.Forms.ComboBox CmbPwdQuestion;
        private System.Windows.Forms.TextBox TxtPwdAnswer;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnShowPwd;
        private System.Windows.Forms.Button BtnSendMail;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ListBox LstMailAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox PicAvatar;
        private System.Windows.Forms.Button BtnUploadAvatar;
    }
}