namespace MyOwnLoginSystem
{
    partial class FormUserInfoInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInfoInsert));
            this.CmbProvince = new System.Windows.Forms.ComboBox();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.CmbDistrict = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmbProvince
            // 
            this.CmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProvince.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbProvince.FormattingEnabled = true;
            this.CmbProvince.Location = new System.Drawing.Point(117, 156);
            this.CmbProvince.Name = "CmbProvince";
            this.CmbProvince.Size = new System.Drawing.Size(209, 41);
            this.CmbProvince.TabIndex = 0;
            this.CmbProvince.SelectedIndexChanged += new System.EventHandler(this.CmbProvince_SelectedIndexChanged);
            // 
            // CmbCity
            // 
            this.CmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(117, 252);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(209, 41);
            this.CmbCity.TabIndex = 1;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // CmbDistrict
            // 
            this.CmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDistrict.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbDistrict.FormattingEnabled = true;
            this.CmbDistrict.Location = new System.Drawing.Point(117, 344);
            this.CmbDistrict.Name = "CmbDistrict";
            this.CmbDistrict.Size = new System.Drawing.Size(209, 41);
            this.CmbDistrict.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "省";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(47, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "市";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(47, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "区";
            // 
            // FormUserInfoInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 761);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbDistrict);
            this.Controls.Add(this.CmbCity);
            this.Controls.Add(this.CmbProvince);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserInfoInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserInfoInsert";
            this.Load += new System.EventHandler(this.FormUserInfoInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbProvince;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.ComboBox CmbDistrict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}