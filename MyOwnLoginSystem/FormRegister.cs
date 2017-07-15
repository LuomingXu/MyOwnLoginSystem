using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using Model;
using BusinessLogicLayer;
using PasswordSecurity;

namespace MyOwnLoginSystem
{
    public partial class FormRegister : Form 
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 此form内部的, 用来保存用户头像目录的string
        /// </summary>
        private string strAvatarFileName = string.Empty;

        private OpenFileDialog OpenAvatar = new OpenFileDialog()
        {
            Filter = "Picture Files(*.png,*.gif,*.jpg,*.bmp,*.jpeg)|*.png;*.gif;*.jpg;*.bmp;*.jpeg| ALL Files(*.*)|*.*",
        };

        private void FormRegister_Load(object sender, EventArgs e)
        {
            SQLExecute excute = new SQLExecute();
            DataSet ds = new DataSet();

            try
            {
                //似乎只要定义了为zoom之后, 只要不更改, 后续加载的图片还是zoom的
                PicAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                PicAvatar.Image = Image.FromFile(Environment.CurrentDirectory + "\\Pic\\LoadingPic.png");
            }
            catch (Exception)
            {
                ds = excute.GetAvatarLoadingPic("loadingPic");
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0][0]);
                PicAvatar.Image = Image.FromStream(ms);

                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Pic");
                PicAvatar.Image.Save(Environment.CurrentDirectory + "\\Pic\\LoadingPic.png");

               // MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ds = excute.GetMailDomain();

            intMailDomainCows = ds.Tables[0].DefaultView.Count;

            try
            {
                for (int i = 0; i < intMailDomainCows; i++)
                {
                    straMailDomain[i] = Convert.ToString(ds.Tables[0].Rows[i][0]);
                    LstMailAddress.Items.Add(straMailDomain[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            SQLExecute excute = new SQLExecute();
            string strID = TxtID.Text.Trim();
            int ret = 0;

            ret = excute.JudegeIfExitThisID(strID);

            if (ret == 1)
            {
                BtnRegister.Enabled = false;
                LblWhetherIDExit.Text = "此账户名已存在!";
                LblWhetherIDExit.ForeColor = Color.Red;
                LblWhetherIDExit.Visible = true;
            }
            else
            {
                BtnRegister.Enabled = true;
                LblWhetherIDExit.Text = "可用的用户名";
                LblWhetherIDExit.ForeColor = Color.Green;
                LblWhetherIDExit.Visible = true;
            }
        }

        private void BtnUploadAvatar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请先输入账户名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (OpenAvatar.ShowDialog() == DialogResult.OK)
            {
                PicAvatar.Image = Image.FromFile(OpenAvatar.FileName);
                string ext = Pic.GetExtension(PicAvatar.Image);

                Directory.CreateDirectory(Environment.CurrentDirectory + "\\UsersAvatars");

                //将保存的图片的位置暂存, 在下面保存到User里面
                strAvatarFileName = Environment.CurrentDirectory + "\\UsersAvatars\\" +
                    TxtID.Text.Trim() + ext;

                PicAvatar.Image.Save(strAvatarFileName);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (PicAvatar.Image == null)
            {
                DialogResult DRret;
                DRret = MessageBox.Show("要上传头像吗", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DRret == DialogResult.Yes)
                {
                    return;
                }
                else
                {

                }
            }
            else
            {
                
            }

            int ret = 0;
            DialogResult retDR;

            User user = new User()
            {
                ID = TxtID.Text.Trim(),
                Nickname = TxtNickName.Text.Trim(),
                Mailaddress = TxtMailAddress.Text.Trim(),
                PwdQuestion = CmbPwdQuestion.Text.Trim(),
                PwdAnswer = TxtPwdAnswer.Text.Trim(),
                FileNameOfAvatar = strAvatarFileName,
            };

            if (TxtPwd.Text.Trim().Equals(TxtPwdConfirm.Text.Trim()) != true)
            {
                MessageBox.Show("您输入的密码前后不一样!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                TxtPwd.Text = string.Empty;
                TxtPwdConfirm.Text = string.Empty;
                TxtPwd.Focus();

                return;
            }

            if (user.ID.Equals(string.Empty) || TxtPwd.Text.Trim().Equals(string.Empty) || user.Mailaddress.Equals(string.Empty) || TxtPwdConfirm.Text.Trim().Equals(string.Empty) || user.PwdQuestion.Equals(string.Empty) || user.PwdAnswer.Equals(string.Empty))
            {
                MessageBox.Show("您有选项没有输入!", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (TxtVerticationCode.Text.Trim().Equals(strVttCode) == false || TxtVerticationCode.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("验证码不正确!\n或不能为空", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            //将image转为byte[]保存到数据库MEDIUMBLOB里面
            byte[] bytesAvatar = null;
            ImageConverter imgconv = new ImageConverter();
            bytesAvatar = (byte[])imgconv.ConvertTo(PicAvatar.Image, typeof(byte[]));
            user.Avatar = bytesAvatar;

            //将密码转为hash保存到数据库
            user.Password = PasswordStorage.CreateHash(TxtPwd.Text.Trim());

            retDR = MessageBox.Show("您确定注册?", "询问",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retDR == DialogResult.Yes)
            {
                try
                {
                    SQLExecute Excute = new SQLExecute();
                    ret = Excute.InsertUserInfo(user);

                    if (ret > 0)
                    {
                        MessageBox.Show("注册成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("请登录!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtID.Text = string.Empty;
                    TxtID.Focus();
                }
            }
            else
            {
                //用户选择了不注册, 就什么都不干
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtID.Text = string.Empty;
            TxtNickName.Text = string.Empty;
            TxtPwd.Text = string.Empty;
            TxtPwdConfirm.Text = string.Empty;
            TxtMailAddress.Text = string.Empty;
            TxtVerticationCode.Text = string.Empty;
            CmbPwdQuestion.Text = string.Empty;
            TxtPwdAnswer.Text = string.Empty;

            TxtID.Focus();
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            //随机出一个6位验证码
            Random RdNumber = new Random();
            int i = RdNumber.Next();
            i %= 1000000;
            //保存在Form全局变量中, 以便验证校对
            strVttCode = i.ToString();

            //获取需要发送的邮箱
            string strMailTo = string.Empty;
            strMailTo = TxtMailAddress.Text.Trim();

            try
            {//被注释掉的东西是原来用163发送邮件的代码
                SmtpClient client = new SmtpClient()
                {
                    //Host = "smtp.163.com",
                    //UseDefaultCredentials = true,
                    //DeliveryMethod = SmtpDeliveryMethod.Network,
                    //Credentials = new NetworkCredential("xlm46566696", "xlm123")

                    Host = "smtp.qq.com",
                   // Port = 587,
                    EnableSsl = true,//这个是关键, 如果没有这个, 就不能发送回提示need EHLO and AUTH first
                    UseDefaultCredentials = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential("3084951871", "uupoxkgfrnzgdgej")
                };
                
                MailMessage mailMessage = new MailMessage()
                {
                    //From = new MailAddress("xlm46566696@163.com", "徐络溟", Encoding.UTF8),
                    From = new MailAddress("3084951871@qq.com", "徐络溟", Encoding.UTF8),
                    Subject = "徐络溟的验证码测试",
                    Body = "验证码\n" + strVttCode,
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

            //在listbox里面添加MailDomain
            for (int i = 0; i < intMailDomainCows; i++)
            {
                LstMailAddress.Items.Add(TxtMailAddress.Text.Trim() + straMailDomain[i]);
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtMailAddress.Text = LstMailAddress.Items[0].ToString();
                LstMailAddress.Visible = false;

                //光标定位到最后
                TxtMailAddress.Select(TxtMailAddress.Text.Length, 1);
            }
        }

        private void LstMailAddress_MouseMove(object sender, MouseEventArgs e)
        {
            ListBox eObj = sender as ListBox;
            eObj.SelectedIndex = eObj.IndexFromPoint(e.Location);
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
    }
}
