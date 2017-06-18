namespace MyOwnLoginSystem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PicUserAvatar = new System.Windows.Forms.PictureBox();
            this.LblShowUserName = new System.Windows.Forms.Label();
            this.BtnInsertChina = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnInsertProvince = new System.Windows.Forms.Button();
            this.BtnInsertProvinceCity = new System.Windows.Forms.Button();
            this.BtnImportInfo = new System.Windows.Forms.Button();
            this.BtnUploadPic = new System.Windows.Forms.Button();
            this.TxtPicIntroduction = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(48, 362);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(195, 69);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PicUserAvatar
            // 
            this.PicUserAvatar.Location = new System.Drawing.Point(48, 104);
            this.PicUserAvatar.Name = "PicUserAvatar";
            this.PicUserAvatar.Size = new System.Drawing.Size(200, 200);
            this.PicUserAvatar.TabIndex = 1;
            this.PicUserAvatar.TabStop = false;
            // 
            // LblShowUserName
            // 
            this.LblShowUserName.AutoSize = true;
            this.LblShowUserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblShowUserName.Location = new System.Drawing.Point(42, 34);
            this.LblShowUserName.Name = "LblShowUserName";
            this.LblShowUserName.Size = new System.Drawing.Size(143, 33);
            this.LblShowUserName.TabIndex = 2;
            this.LblShowUserName.Text = "UserName";
            // 
            // BtnInsertChina
            // 
            this.BtnInsertChina.Enabled = false;
            this.BtnInsertChina.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsertChina.Location = new System.Drawing.Point(883, 408);
            this.BtnInsertChina.Name = "BtnInsertChina";
            this.BtnInsertChina.Size = new System.Drawing.Size(255, 83);
            this.BtnInsertChina.TabIndex = 3;
            this.BtnInsertChina.Text = "录入省市区信息";
            this.BtnInsertChina.UseVisualStyleBackColor = true;
            this.BtnInsertChina.Visible = false;
            this.BtnInsertChina.Click += new System.EventHandler(this.BtnInsertChina_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Enabled = false;
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Location = new System.Drawing.Point(849, 508);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(289, 61);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "是否有遗漏的查询查询";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Visible = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnInsertProvince
            // 
            this.BtnInsertProvince.Enabled = false;
            this.BtnInsertProvince.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsertProvince.Location = new System.Drawing.Point(883, 204);
            this.BtnInsertProvince.Name = "BtnInsertProvince";
            this.BtnInsertProvince.Size = new System.Drawing.Size(255, 81);
            this.BtnInsertProvince.TabIndex = 5;
            this.BtnInsertProvince.Text = "录入省信息";
            this.BtnInsertProvince.UseVisualStyleBackColor = true;
            this.BtnInsertProvince.Visible = false;
            this.BtnInsertProvince.Click += new System.EventHandler(this.BtnInsertProvince_Click);
            // 
            // BtnInsertProvinceCity
            // 
            this.BtnInsertProvinceCity.Enabled = false;
            this.BtnInsertProvinceCity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnInsertProvinceCity.Location = new System.Drawing.Point(883, 308);
            this.BtnInsertProvinceCity.Name = "BtnInsertProvinceCity";
            this.BtnInsertProvinceCity.Size = new System.Drawing.Size(255, 81);
            this.BtnInsertProvinceCity.TabIndex = 6;
            this.BtnInsertProvinceCity.Text = "录入省市信息";
            this.BtnInsertProvinceCity.UseVisualStyleBackColor = true;
            this.BtnInsertProvinceCity.Visible = false;
            this.BtnInsertProvinceCity.Click += new System.EventHandler(this.BtnInsertProvinceCity_Click);
            // 
            // BtnImportInfo
            // 
            this.BtnImportInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnImportInfo.Location = new System.Drawing.Point(883, 104);
            this.BtnImportInfo.Name = "BtnImportInfo";
            this.BtnImportInfo.Size = new System.Drawing.Size(255, 60);
            this.BtnImportInfo.TabIndex = 7;
            this.BtnImportInfo.Text = "录入信息";
            this.BtnImportInfo.UseVisualStyleBackColor = true;
            this.BtnImportInfo.Click += new System.EventHandler(this.BtnImportInfo_Click);
            // 
            // BtnUploadPic
            // 
            this.BtnUploadPic.Enabled = false;
            this.BtnUploadPic.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnUploadPic.Location = new System.Drawing.Point(523, 495);
            this.BtnUploadPic.Name = "BtnUploadPic";
            this.BtnUploadPic.Size = new System.Drawing.Size(300, 74);
            this.BtnUploadPic.TabIndex = 8;
            this.BtnUploadPic.Text = "后台上传图片按钮";
            this.BtnUploadPic.UseVisualStyleBackColor = true;
            this.BtnUploadPic.Visible = false;
            this.BtnUploadPic.Click += new System.EventHandler(this.BtnUploadPic_Click);
            // 
            // TxtPicIntroduction
            // 
            this.TxtPicIntroduction.Enabled = false;
            this.TxtPicIntroduction.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtPicIntroduction.Location = new System.Drawing.Point(523, 445);
            this.TxtPicIntroduction.Name = "TxtPicIntroduction";
            this.TxtPicIntroduction.Size = new System.Drawing.Size(300, 44);
            this.TxtPicIntroduction.TabIndex = 9;
            this.TxtPicIntroduction.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 603);
            this.Controls.Add(this.TxtPicIntroduction);
            this.Controls.Add(this.BtnUploadPic);
            this.Controls.Add(this.BtnImportInfo);
            this.Controls.Add(this.BtnInsertProvinceCity);
            this.Controls.Add(this.BtnInsertProvince);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnInsertChina);
            this.Controls.Add(this.LblShowUserName);
            this.Controls.Add(this.PicUserAvatar);
            this.Controls.Add(this.BtnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyOwnLoginSystem";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicUserAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// 在load时就获取MailDomain, 一是为了获取domain, 而是为了链接MySQL, 避免下面登录时过慢
        /// </summary>
        public string[] publicStraMailDomain = new string[20];

        /// <summary>
        /// 保存MailDomain的个数
        /// </summary>
        public int publicIntDomainCount = 0;

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.PictureBox PicUserAvatar;
        public System.Windows.Forms.Label LblShowUserName;
        private System.Windows.Forms.Button BtnInsertChina;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnInsertProvince;
        private System.Windows.Forms.Button BtnInsertProvinceCity;
        private System.Windows.Forms.Button BtnImportInfo;
        private System.Windows.Forms.Button BtnUploadPic;
        private System.Windows.Forms.TextBox TxtPicIntroduction;
    }
}