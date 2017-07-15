using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessLogicLayer;
using DataBaseAccessLayer;

namespace MyOwnLoginSystem
{
    public partial class FormMain : Form, CHange
    {
        private OpenFileDialog OpenPic = new OpenFileDialog();

        public FormMain()
        {
            InitializeComponent();
        }

        public void ChangeLbl(string Lbl)
        {
            LblShowUserName.Text = Lbl;
        }

        public void ImageChange(Image image)
        {
            PicUserAvatar.Image = image;
        }

        #region 2017.6.12.16:33 为了从SQLserver中转移省市区数据到MySQL而写的代码, 有关控件都unvisible, unenable; 需要using DAL; 其中有关select语句返回-1的代码是错误的, 由于对我已经没用了, 所以就不改了, 特此告知

        private void BtnInsertChina_Click(object sender, EventArgs e)
        {
            int ret = 0;
            int count = 0;

            Access DBAccess = new Access();

            DataSet dsProvince = new DataSet();
            DataSet dsCity = new DataSet();
            DataSet dsDistrict = new DataSet();

            string strSqlProvince = string.Empty;
            string strSqlCity = string.Empty;
            string strSqlDistrict = string.Empty;
            string strSqlInsert = string.Empty;

            int intProvinceCount = 0;
            int intCityCount = 0;
            int intDistrictCount = 0;

            string strProvinceID = string.Empty;
            string strCityID = string.Empty;

            string strProvinceName = string.Empty;
            string strCityName = string.Empty;
            string strDistrictName = string.Empty;

            strSqlProvince = $"select ProvinceID,ProvinceName from S_Province";

            dsProvince = DBAccess.ReadSQLserver(strSqlProvince, "temp");
            intProvinceCount = dsProvince.Tables[0].DefaultView.Count;

            for (int i = 0; i < intProvinceCount; i++)
            {
                strProvinceID = dsProvince.Tables[0].Rows[i][0].ToString();
                strSqlCity = $"select CityID,CityName from S_City where ProvinceID='{strProvinceID}'";
                dsCity = DBAccess.ReadSQLserver(strSqlCity, "temp");
                intCityCount = dsCity.Tables[0].DefaultView.Count;

                for (int j = 0; j < intCityCount; j++)
                {
                    strCityID = dsCity.Tables[0].Rows[j][0].ToString();
                    strSqlDistrict = $"select DistrictName from S_District where CityID='{strCityID}'";
                    dsDistrict = DBAccess.ReadSQLserver(strSqlDistrict, "temp");
                    intDistrictCount = dsDistrict.Tables[0].DefaultView.Count;

                    for (int k = 0; k < intDistrictCount; k++)
                    {
                        strProvinceName = dsProvince.Tables[0].Rows[i][1].ToString();
                        strCityName = dsCity.Tables[0].Rows[j][1].ToString();
                        strDistrictName = dsDistrict.Tables[0].Rows[k][0].ToString();

                        strSqlInsert = $"insert into china(number,province,city,district) " +
                            $"values('{Convert.ToString(i)}','{strProvinceName}','{strCityName}','{strDistrictName}')";

                        ret = DBAccess.ReadMySQL(strSqlInsert);

                        if (ret == 1)
                        {
                            count++;
                        }
                    }
                }

                DialogResult DRret;

                DRret = MessageBox.Show("已完成:" + strProvinceName + "的记录是否继续?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DRret.Equals(DialogResult.No))
                {
                    break;
                }
            }

            MessageBox.Show(Convert.ToString(count), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnInsertProvinceCity_Click(object sender, EventArgs e)
        {
            int ret = 0;
            int count = 0;

            Access DBAccess = new Access();

            DataSet dsProvince = new DataSet();
            DataSet dsCity = new DataSet();

            string strSqlProvince = string.Empty;
            string strSqlCity = string.Empty;
            string strSqlInsert = string.Empty;

            int intProvinceCount = 0;
            int intCityCount = 0;

            string strProvinceID = string.Empty;
            string strCityID = string.Empty;

            string strProvinceName = string.Empty;
            string strCityName = string.Empty;

            strSqlProvince = $"select ProvinceID,ProvinceName from S_Province";

            dsProvince = DBAccess.ReadSQLserver(strSqlProvince, "temp");
            intProvinceCount = dsProvince.Tables[0].DefaultView.Count;

            for (int i = 0; i < intProvinceCount; i++)
            {
                strProvinceID = dsProvince.Tables[0].Rows[i][0].ToString();
                strSqlCity = $"select CityID,CityName from S_City where ProvinceID='{strProvinceID}'";
                dsCity = DBAccess.ReadSQLserver(strSqlCity, "temp");
                intCityCount = dsCity.Tables[0].DefaultView.Count;

                for (int j = 0; j < intCityCount; j++)
                {
                    strCityID = dsCity.Tables[0].Rows[j][0].ToString();

                    strProvinceName = dsProvince.Tables[0].Rows[i][1].ToString();
                    strCityName = dsCity.Tables[0].Rows[j][1].ToString();


                    strSqlInsert = $"insert into provinceandcity(province,city) " +
                        $"values('{strProvinceName}','{strCityName}')";

                    ret = DBAccess.ReadMySQL(strSqlInsert);

                    if (ret == 1)
                    {
                        count++;
                    }

                }

                DialogResult DRret;

                DRret = MessageBox.Show("已完成:" + strProvinceName + "的记录是否继续?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DRret.Equals(DialogResult.No))
                {
                    break;
                }
            }
        }

        private void BtnInsertProvince_Click(object sender, EventArgs e)
        {
            int ret = 0;
            int count = 0;

            Access DBAccess = new Access();

            DataSet dsProvince = new DataSet();

            string strSqlProvince = string.Empty;
            string strSqlInsert = string.Empty;

            int intProvinceCount = 0;

            string strProvinceID = string.Empty;

            string strProvinceName = string.Empty;
            string strCityName = string.Empty;

            strSqlProvince = $"select ProvinceName from S_Province";

            dsProvince = DBAccess.ReadSQLserver(strSqlProvince, "temp");
            intProvinceCount = dsProvince.Tables[0].DefaultView.Count;

            for (int i = 0; i < intProvinceCount; i++)
            {
                strProvinceName = dsProvince.Tables[0].Rows[i][0].ToString();

                strSqlInsert = $"insert into province(province) " +
                    $"values('{strProvinceName}')";

                ret = DBAccess.ReadMySQL(strSqlInsert);

                if (ret == 1)
                {
                    count++;
                }

                DialogResult DRret;

                DRret = MessageBox.Show("已完成:" + strProvinceName + "的记录是否继续?", "提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DRret.Equals(DialogResult.No))
                {
                    break;
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string strDistrict = string.Empty;
            int intCount = 0;
            int ret = 0;
            int intNumberCount = 0;

            Access DBAccess = new Access();
            DataSet ds = new DataSet();

            string strSql = string.Empty;
            strSql = $"select DistrictName from S_District";
            ds = DBAccess.ReadSQLserver(strSql, "temp");
            intCount = ds.Tables[0].DefaultView.Count;

            for (int i = 0; i < intCount; i++)
            {
                strDistrict = ds.Tables[0].Rows[i][0].ToString();
                strSql = $"select * from china where district='{strDistrict}'";
                ret = DBAccess.ReadMySQL(strSql);

                if (ret != -1)
                {
                    MessageBox.Show("不存在" + strDistrict, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    intNumberCount++;
                    if (intNumberCount % 500 == 0)
                    {
                        MessageBox.Show("已完成" + Convert.ToString(intNumberCount) + "条数据查询", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            MessageBox.Show("完成" + Convert.ToString(intNumberCount) + "条数据查询", "提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                SQLExecute excute = new SQLExecute();
                DataSet ds = new DataSet();

                ds = excute.GetMailDomain();

                publicIntDomainCount = ds.Tables[0].DefaultView.Count;

                for (int i = 0; i < publicIntDomainCount; i++)
                {
                    publicStraMailDomain[i] = Convert.ToString(ds.Tables[0].Rows[i][0]);
                }

                //如果已经在本地保存了图片, 就直接到保存图片的文件里面去加载, 否则从数据库中读取
                try
                {
                    PicUserAvatar.SizeMode = PictureBoxSizeMode.Zoom;
                    //PicUserAvatar.Image = Image.FromFile(Environment.CurrentDirectory + @"\Pic\LoadingPic.png");
                    PicUserAvatar.LoadAsync(Environment.CurrentDirectory + @"\Pic\LoadingPic.png");
                }
                catch (Exception)
                {
                    ds = excute.GetAvatarLoadingPic("LoadingPic");

                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0][0]);
                    PicUserAvatar.Image = Image.FromStream(ms);

                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\Pic");
                    PicUserAvatar.Image.Save(Environment.CurrentDirectory + @"\Pic\LoadingPic.png");
                }
                             
                //为了在开始就能够连接, 为了后续的连接能够快一点, 在load事件里面就连接,
                //但如果没有一个messagebox的话, 后续的连接依旧是异常的慢, 所以...
                MessageBox.Show("已连接数据库!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FormMain_Load:" + ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FormLogin FrmLogin = new FormLogin(this,this);
            FrmLogin.Show();
        }

        private void BtnImportInfo_Click(object sender, EventArgs e)
        {
            FormUserInfoInsert FrmImport = new FormUserInfoInsert();
            FrmImport.Show();
        }

        private void BtnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                int ret = 0;
                PicUserAvatar.Image = Image.FromFile(openFile.FileName);
                ImageConverter imgconv = new ImageConverter();
                byte[] bytesPic = (byte[])imgconv.ConvertTo(PicUserAvatar.Image, typeof(byte[]));
                SQLExecute excute = new SQLExecute();
                ret = excute.UplodaFile(bytesPic, TxtPicIntroduction.Text.Trim());
                if (ret == 1)
                {
                    MessageBox.Show("上传成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
