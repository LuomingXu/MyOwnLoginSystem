﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using System.IO;

namespace MyOwnLoginSystem
{
    public partial class FormLogin : Form
    {
        private CHange LblChange;
        private CHange ImageChange;

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(CHange LblChange, CHange ImageChange)
        {
            InitializeComponent();
            this.LblChange = LblChange;
            this.ImageChange = ImageChange;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TxtID.Focus();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister FrmRegister = new FormRegister();
            FrmRegister.Show();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtID.Text = string.Empty;
            TxtPwd.Text = string.Empty;

            TxtID.Focus();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int ret = 0;
            string strID = string.Empty;
            string strPwd = string.Empty;

            strID = TxtID.Text.Trim();
            strPwd = TxtPwd.Text.Trim();

            SQLExecute excute = new SQLExecute();

            ret = excute.UserLogin(strID, strPwd);

            if (ret > 0)
            {
                MessageBox.Show("登录成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //FormMain FrmM = new FormMain();
                //FrmM.LblShowUserName.Text = "欢迎" + TxtID.Text.Trim();
                LblChange.ChangeLbl("欢迎您: " + TxtID.Text.Trim());
                //发现这边要是用show方法的话, main窗体show不出来, 就尝试在另一个线程里运行
                //new System.Threading.Thread(() =>
                //    {
                //        Application.Run(FrmM);
                //    }).Start();

                DataSet ds = new DataSet();
                byte[] bytes = null;
                ds = excute.GetUserAvatar(TxtID.Text.Trim());
                bytes = (byte[])ds.Tables["temp"].Rows[0][0];

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Image image = Image.FromStream(ms);
                    ImageChange.ImageChange(image);
                }
                Close();
            }
            else
            {
                MessageBox.Show("失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnForgetPwd_Click(object sender, EventArgs e)
        {
            DialogResult ret;

            if (TxtID.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名\n或者您未注册!", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ret = MessageBox.Show("您要注册吗?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ret.Equals(DialogResult.Yes))
                {
                    FormRegister frmRegister = new FormRegister();
                    frmRegister.Show();

                    Close();
                }

                return;
            }

            ret = MessageBox.Show("您是否还记的您的密码提示问题?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (ret.Equals(DialogResult.Yes))
            {
                FormForgetPwdByPwdQuestion FrmFgPwd = new FormForgetPwdByPwdQuestion();
                FrmFgPwd.TxtID.Text = TxtID.Text.Trim();

                FrmFgPwd.Show();
                Close();

                MessageBox.Show("请输入密码提示问题的答案", "提示",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
            {
                ret = MessageBox.Show("确定通过邮箱验证身份吗?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (ret.Equals(DialogResult.Yes))
                {
                    FormForgetPwdByMail FrmFgPwd = new FormForgetPwdByMail();
                    FrmFgPwd.TxtID.Text = TxtID.Text.Trim();

                    FrmFgPwd.Show();

                    Close();

                    return;
                }
                else
                {

                }
            }          
        }     
    }
}
