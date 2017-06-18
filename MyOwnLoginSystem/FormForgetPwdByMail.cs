using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using BusinessLogicLayer;

namespace MyOwnLoginSystem
{
    public partial class FormForgetPwdByMail : Form
    {
        public FormForgetPwdByMail()
        {
            InitializeComponent();
        }

        private void FormForgetPwdByMail_Load(object sender, EventArgs e)
        {
            string strID = TxtID.Text.Trim();

            DataSet ds = new DataSet();

            SQLExecute excute = new SQLExecute();

            ds = excute.GetUserMailAddress(strID);

            TxtMailAddress.Text = Convert.ToString(ds.Tables[0].Rows[0][0]);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtVttCode.Text = string.Empty;
            TxtVttCode.Focus();
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            //随机出一个6位验证码
            Random RdNumber = new Random();
            int i = RdNumber.Next();
            i %= 1000000;
            //保存在全Form变量中, 以便验证校对
            PrivateStrVttCode = i.ToString();

            //获取需要发送的邮箱
            string strMailTo = string.Empty;
            strMailTo = TxtMailAddress.Text.Trim();

            try
            {
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.163.com",
                    UseDefaultCredentials = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential("xlm46566696", "xlm123")
                };

                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress("xlm46566696@163.com", "徐络溟", Encoding.UTF8),
                    Subject = "徐络溟的验证码测试",
                    Body = "验证码\n" + PrivateStrVttCode,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    Priority = MailPriority.High,
                    IsBodyHtml = true,
                };
                //防止被当做垃圾邮件的秘密/抠鼻
                mailMessage.Headers.Add("X-QQ-FEAT", "zA6doese0mJ197rkmu99KEGGq7KYg01VBRljUe6NE1fFR/Dv/P86Z73saQHl+" +
                    "ocTCUB6X9p4jMmSrhA7EmKfSBrqaFSknIVJqMWaXQBuOS/EkrHiUk6jNMEzDd6ySnxFgW1t" +
                    "SZXuYHhJ7hivENLW238mgBZByFb+4UviauuVinsrops07fw80fIQtMScpn2KhoFJoR4NaES" +
                    "oEbWfljklo6CiYl+NaU1aOOf32x8gaaE=");
                mailMessage.Headers.Add("X-QQ-SSF", "00010000000000F000000000000000S");
                mailMessage.Headers.Add("X-HAS-ATTACH", "no");
                mailMessage.Headers.Add("X-QQ-BUSINESS-ORIGIN", "2");
                mailMessage.Headers.Add("X-Originating-IP", "153.101.48.119");
                mailMessage.Headers.Add("X-QQ-mid", "webmail367t1495970966t8880412");
                mailMessage.Headers.Add("X-QQ-MIME", "TCMime 1.0 by Tencent");
                mailMessage.Headers.Add("X-Mailer", "QQMail 2.x");
                mailMessage.Headers.Add("X-QQ-Mailer", "QQMail 2.x");
                mailMessage.Headers.Add("X-QQ-SENDSIZE", "520");
                mailMessage.Headers.Add("X-CM-TRANSID", "e8CowED58UKXtCpZcO1WBA--.15282S3");
                mailMessage.Headers.Add("X-Coremail-Antispam", "1Uf129KBjDUn29KB7ZKAUJUUUUU529EdanIXcx71UUUUU7v73" +
                    "VFW2AGmfu7bjvjm3AaLaJ3UbIYCTnIWIevJa73UjIFyTuYvjxU-SoXUUUUU");

                mailMessage.To.Add(strMailTo);

                client.Send(mailMessage);

                MessageBox.Show("发送成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (TxtVttCode.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("验证码不能为空!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            DialogResult DRret;

            DRret = MessageBox.Show("确认重置?", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DRret == DialogResult.Yes)
            {
                if (TxtVttCode.Text.Trim().Equals(PrivateStrVttCode))
                {
                    MessageBox.Show("验证码正确!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormReUserPwd FrmRePwd = new FormReUserPwd();

                    FrmRePwd.TxtID.Text = TxtID.Text.Trim();

                    FrmRePwd.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("验证码不正确!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

            }
        }
    }
}
