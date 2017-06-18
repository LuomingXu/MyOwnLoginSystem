using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace MyOwnLoginSystem
{
    public partial class FormForgetPwdByPwdQuestion : Form
    {
        public FormForgetPwdByPwdQuestion()
        {
            InitializeComponent();
        }

        private void FormForgetPwdByPwdQuestion_Load(object sender, EventArgs e)
        {
            string strID = TxtID.Text.Trim();

            SQLExecute excute = new SQLExecute();
            DataSet ds = new DataSet();

            ds = excute.GetUserAuthentication(strID);

            TxtPwdQuestion.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);

            TxtPwdAnswer.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtPwdAnswer.Text = string.Empty;
            TxtPwdAnswer.Focus();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int ret = 0;
            string strID = TxtID.Text.Trim();
            string strPwdAnswer = TxtPwdAnswer.Text.Trim();

            SQLExecute excute = new SQLExecute();

            ret = excute.CompareUserIdentity(strID, strPwdAnswer);

            if (ret == 1)
            {
                MessageBox.Show("忘记密码成功!\n请输入新的信息", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormReUserPwd FrmRePwd = new FormReUserPwd();

                //传递用户名
                FrmRePwd.TxtID.Text = TxtID.Text.Trim();

                FrmRePwd.Show();

                Close();
                //提示用户要干什么
                MessageBox.Show("请输入新的密码!", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("除密码外其余若不想更改可为空!", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("忘记密码失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
