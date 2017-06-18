namespace MyOwnLoginSystem
{
    partial class FormReUserPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReUserPwd));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMailAddress = new System.Windows.Forms.TextBox();
            this.CmbPwdQuestion = new System.Windows.Forms.ComboBox();
            this.TxtPwdAnswer = new System.Windows.Forms.TextBox();
            this.TxtPwdConfirm = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNickName = new System.Windows.Forms.TextBox();
            this.BtnRePwd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnShowPwd = new System.Windows.Forms.Button();
            this.LstMailAddress = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(93, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "答案";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(39, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "密码提示问题";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(97, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "邮箱";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(71, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "密码确认";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(97, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(97, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "昵称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(109, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // TxtMailAddress
            // 
            this.TxtMailAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtMailAddress.Location = new System.Drawing.Point(292, 381);
            this.TxtMailAddress.Name = "TxtMailAddress";
            this.TxtMailAddress.Size = new System.Drawing.Size(278, 44);
            this.TxtMailAddress.TabIndex = 4;
            this.TxtMailAddress.TextChanged += new System.EventHandler(this.TxtMailAddress_TextChanged);
            this.TxtMailAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMailAddress_KeyPress);
            // 
            // CmbPwdQuestion
            // 
            this.CmbPwdQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPwdQuestion.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbPwdQuestion.FormattingEnabled = true;
            this.CmbPwdQuestion.Items.AddRange(new object[] {
            "喜欢的人",
            "寝室号",
            "父母的姓名"});
            this.CmbPwdQuestion.Location = new System.Drawing.Point(292, 482);
            this.CmbPwdQuestion.Name = "CmbPwdQuestion";
            this.CmbPwdQuestion.Size = new System.Drawing.Size(278, 41);
            this.CmbPwdQuestion.TabIndex = 5;
            // 
            // TxtPwdAnswer
            // 
            this.TxtPwdAnswer.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwdAnswer.Location = new System.Drawing.Point(292, 577);
            this.TxtPwdAnswer.Name = "TxtPwdAnswer";
            this.TxtPwdAnswer.Size = new System.Drawing.Size(278, 44);
            this.TxtPwdAnswer.TabIndex = 6;
            // 
            // TxtPwdConfirm
            // 
            this.TxtPwdConfirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwdConfirm.Location = new System.Drawing.Point(292, 291);
            this.TxtPwdConfirm.Name = "TxtPwdConfirm";
            this.TxtPwdConfirm.PasswordChar = '▪';
            this.TxtPwdConfirm.Size = new System.Drawing.Size(278, 44);
            this.TxtPwdConfirm.TabIndex = 3;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPwd.Location = new System.Drawing.Point(292, 195);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '▪';
            this.TxtPwd.Size = new System.Drawing.Size(278, 44);
            this.TxtPwd.TabIndex = 2;
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtID.Location = new System.Drawing.Point(292, 26);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(278, 44);
            this.TxtID.TabIndex = 16;
            // 
            // TxtNickName
            // 
            this.TxtNickName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtNickName.Location = new System.Drawing.Point(292, 108);
            this.TxtNickName.Name = "TxtNickName";
            this.TxtNickName.Size = new System.Drawing.Size(278, 44);
            this.TxtNickName.TabIndex = 1;
            // 
            // BtnRePwd
            // 
            this.BtnRePwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRePwd.Location = new System.Drawing.Point(89, 658);
            this.BtnRePwd.Name = "BtnRePwd";
            this.BtnRePwd.Size = new System.Drawing.Size(199, 66);
            this.BtnRePwd.TabIndex = 23;
            this.BtnRePwd.Text = "重置";
            this.BtnRePwd.UseVisualStyleBackColor = true;
            this.BtnRePwd.Click += new System.EventHandler(this.BtnRePwd_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(439, 658);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(199, 66);
            this.BtnCancel.TabIndex = 24;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnShowPwd
            // 
            this.BtnShowPwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnShowPwd.Location = new System.Drawing.Point(603, 195);
            this.BtnShowPwd.Name = "BtnShowPwd";
            this.BtnShowPwd.Size = new System.Drawing.Size(75, 153);
            this.BtnShowPwd.TabIndex = 25;
            this.BtnShowPwd.Text = "显示密码";
            this.BtnShowPwd.UseVisualStyleBackColor = true;
            this.BtnShowPwd.MouseLeave += new System.EventHandler(this.BtnShowPwd_MouseLeave);
            this.BtnShowPwd.MouseHover += new System.EventHandler(this.BtnShowPwd_MouseHover);
            // 
            // LstMailAddress
            // 
            this.LstMailAddress.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LstMailAddress.FormattingEnabled = true;
            this.LstMailAddress.ItemHeight = 33;
            this.LstMailAddress.Location = new System.Drawing.Point(292, 418);
            this.LstMailAddress.Name = "LstMailAddress";
            this.LstMailAddress.Size = new System.Drawing.Size(278, 169);
            this.LstMailAddress.TabIndex = 26;
            this.LstMailAddress.Visible = false;
            this.LstMailAddress.Click += new System.EventHandler(this.LstMailAddress_Click);
            this.LstMailAddress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LstMailAddress_MouseMove);
            // 
            // FormReUserPwd
            // 
            this.AcceptButton = this.BtnRePwd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(740, 769);
            this.Controls.Add(this.LstMailAddress);
            this.Controls.Add(this.BtnShowPwd);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRePwd);
            this.Controls.Add(this.TxtNickName);
            this.Controls.Add(this.TxtMailAddress);
            this.Controls.Add(this.CmbPwdQuestion);
            this.Controls.Add(this.TxtPwdAnswer);
            this.Controls.Add(this.TxtPwdConfirm);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReUserPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码重置";
            this.Load += new System.EventHandler(this.FormReUserPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMailAddress;
        private System.Windows.Forms.ComboBox CmbPwdQuestion;
        private System.Windows.Forms.TextBox TxtPwdAnswer;
        private System.Windows.Forms.TextBox TxtPwdConfirm;
        private System.Windows.Forms.TextBox TxtPwd;
        public System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtNickName;
        private System.Windows.Forms.Button BtnRePwd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnShowPwd;
        private System.Windows.Forms.ListBox LstMailAddress;
    }
}