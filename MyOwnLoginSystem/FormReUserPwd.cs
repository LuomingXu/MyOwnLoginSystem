using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BusinessLogicLayer;

namespace MyOwnLoginSystem
{
    public partial class FormReUserPwd : Form
    {
        public FormReUserPwd()
        {
            InitializeComponent();
        }

        private void FormReUserPwd_Load(object sender, EventArgs e)
        {
            TxtPwd.Focus();

            DataSet ds = new DataSet();
            SQLExecute excute = new SQLExecute();

            ds = excute.GetUserInfo(TxtID.Text.Trim());

            TxtNickName.Text = ds.Tables[0].Rows[0][0].ToString();
            TxtMailAddress.Text = ds.Tables[0].Rows[0][1].ToString();
            CmbPwdQuestion.Text = ds.Tables[0].Rows[0][2].ToString();
            TxtPwdAnswer.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void BtnShowPwd_MouseHover(object sender, EventArgs e)
        {
            TxtPwd.PasswordChar = '\0';
            TxtPwdConfirm.PasswordChar = '\0';
        }

        private void BtnShowPwd_MouseLeave(object sender, EventArgs e)
        {
            TxtPwd.PasswordChar = '▪';
            TxtPwdConfirm.PasswordChar = '▪';
        }

        private void BtnRePwd_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (TxtID.Text.Trim().Equals(string.Empty) != true)
            {
                user.ID = TxtID.Text.Trim();
            }
            if (TxtNickName.Text.Trim().Equals(string.Empty) != true)
            {
                user.Nickname = TxtNickName.Text.Trim();
            }
            if (TxtPwd.Text.Trim().Equals(string.Empty) != true)
            {
                user.Password = TxtPwd.Text.Trim();
            }
            if (TxtMailAddress.Text.Trim().Equals(string.Empty) != true)
            {
                user.Mailaddress = TxtMailAddress.Text.Trim();
            }
            if (CmbPwdQuestion.Text.Trim().Equals(string.Empty) != true)
            {
                user.PwdQuestion = CmbPwdQuestion.Text.Trim();
            }
            if (TxtPwdAnswer.Text.Trim().Equals(string.Empty) != true)
            {
                user.PwdAnswer = TxtPwdAnswer.Text.Trim();
            }

            int ret = 0;
            string strPwdConfirm = TxtPwdConfirm.Text.Trim();
            DialogResult DRret;

            if (user.Password.Equals(strPwdConfirm) != true)
            {
                MessageBox.Show("您输入的密码前后不一样!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                TxtPwd.Text = string.Empty;
                TxtPwdConfirm.Text = string.Empty;
                TxtPwd.Focus();

                return;
            }

            if (user.Password.Equals(string.Empty) || strPwdConfirm.Equals(string.Empty))
            {
                MessageBox.Show("密码和密码确认不可空缺!", "警告",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DRret = MessageBox.Show("确定重置?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DRret == DialogResult.Yes)
            {
                SQLExecute excute = new SQLExecute();

                ret = excute.UpdateUserInfo(user);

                if (ret == 1)
                {
                    MessageBox.Show("重置成功!\n请重新登录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormLogin FrmLogin = new FormLogin();

                    FrmLogin.TxtID.Text = TxtID.Text.Trim();

                    FrmLogin.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtNickName.Text = string.Empty;
            TxtPwd.Text = string.Empty;
            TxtPwdConfirm.Text = string.Empty;
            TxtMailAddress.Text = string.Empty;
            CmbPwdQuestion.Text = string.Empty;
            TxtPwdAnswer.Text = string.Empty;

            TxtPwd.Focus();
        }

        private void TxtMailAddress_TextChanged(object sender, EventArgs e)
        {
            LstMailAddress.Items.Clear();

            //在用户没有输入或者删除了输入时使listbox不可见
            if (TxtMailAddress.Text.Trim().Equals(string.Empty))
            {
                LstMailAddress.Visible = false;
            }
            else
            {
                LstMailAddress.Visible = true;
            }

            FormMain FrmM = new FormMain();

            //在listbox里面添加MailDomain
            for (int i = 0; i < FrmM.publicIntDomainCount; i++)
            {
                LstMailAddress.Items.Add(TxtMailAddress.Text.Trim() + FrmM.publicStraMailDomain[i]);
            }
        }

        private void TxtMailAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                string[] strTemp = TxtMailAddress.Text.Trim().Split('@');

                TxtMailAddress.Text = strTemp[0];

                //光标定位到最后
                TxtMailAddress.Select(TxtMailAddress.Text.Length, 1);
            }
        }

        private void LstMailAddress_Click(object sender, EventArgs e)
        {
            TxtMailAddress.Text = LstMailAddress.Text.Trim().ToString();
            LstMailAddress.Visible = false;
            LstMailAddress.Items.Clear();

            string[] strTemp = TxtMailAddress.Text.Trim().Split('@');
            string strMailDomain = "@" + strTemp[1].ToString();

            SQLExecute excute = new SQLExecute();

            excute.MailDomainHotIndexPlus(strMailDomain);
        }

        private void LstMailAddress_MouseMove(object sender, MouseEventArgs e)
        {
            ListBox eObj = sender as ListBox;
            eObj.SelectedIndex = eObj.IndexFromPoint(e.Location);
        }
    }
}
