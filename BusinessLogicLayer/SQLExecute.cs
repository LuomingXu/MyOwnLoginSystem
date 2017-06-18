using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataBaseAccessLayer;
using System.Data;
using System.Windows.Forms;

namespace BusinessLogicLayer
{
    /// <summary>
    /// SQL语句的处理
    /// </summary>
   public class SQLExecute
    {
        /// <summary>
        /// 读取数据库, 获得MailDomain的ds
        /// </summary>
        /// <returns>DataSet</returns>
        public DataSet GetMailDomain()
        {
            string strSQL = $"select address from mailaddress order by HotIndex desc";

            try
            {
                DataSet ds = new DataSet();

                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSQL, "MailDomain");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetMailDomain:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        /// <summary>
        /// 在数据库当中插入用户数据
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响的行数</returns>
        public int InsertUserInfo(User user)
        {
            string strSQL = string.Empty;
            int ret = 0;

            strSQL = $"insert into users(ID,nickname,password,mailaddress,pwdquestion,pwdanswer,avatar) " +
                     $"values('{user.ID}','{user.Nickname}','{user.Password}','{user.Mailaddress}','{user.PwdQuestion}','{user.PwdAnswer}',@byteAvatar)";

            Access DBAccess = new Access();

            ret = DBAccess.ReadMySQL(strSQL,user.Avatar);

            return ret;
        }

        /// <summary>
        /// 使得用户点击的MailDomain的HotIndex+1
        /// </summary>
        /// <param name="strMailDomain">需要+1的MailDomain</param>
        /// <returns>影响的行数</returns>
        public int MailDomainHotIndexPlus(string strMailDomain)
        {
            int ret = 0;
            string strSQL = string.Empty;

            strSQL = $"update MailAddress set HotIndex +=1 where address='{strMailDomain}'";

            Access DBAccess = new Access();

            ret = DBAccess.ReadSQLserver(strSQL);

            return ret;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="strID">账号</param>
        /// <param name="strPwd">密码</param>
        /// <returns>影响的行数</returns>
        public int UserLogin(string strID, string strPwd)
        {
            string strSQL = string.Empty;
            int ret = 0;

            strSQL = $"select * from users where ID='{strID}' and password='{strPwd}'";

            Access DBAccess = new Access();
            DataSet ds = new DataSet();

            ds = DBAccess.ReadMySQL(strSQL, "temp");

            ret = ds.Tables[0].DefaultView.Count;

            return ret;
        }

        /// <summary>
        /// 获取用户的密码提示问题
        /// </summary>
        /// <param name="strID">账号</param>
        /// <returns>DataSet</returns>
        public DataSet GetUserAuthentication(string strID)
        {
            string strSQL = string.Empty;

            strSQL = $"select pwdquestion from users where ID='{strID}'";

            try
            {
                DataSet ds = new DataSet();

                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSQL,"temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetUserAuthentication:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        /// <summary>
        /// 获取用户的邮箱账号
        /// </summary>
        /// <param name="strID">账号</param>
        /// <returns>DataSet</returns>
        public DataSet GetUserMailAddress(string strID)
        {
            string strSQL = string.Empty;

            strSQL = $"select mailaddress from users where ID='{strID}'";

            try
            {
                DataSet ds = new DataSet();

                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSQL, "temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetUserMailAddress:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }        
        }

        /// <summary>
        /// 比较账号, 密码答案, 确定是否正确
        /// </summary>
        /// <param name="strID">账号</param>
        /// <param name="strPwdAnswer">密码答案</param>
        /// <returns>影响的行数</returns>
        public int CompareUserIdentity(string strID, string strPwdAnswer)
        {
            int ret = 0;
            string strSQL = string.Empty;

            strSQL = $"select * from users where ID='{strID}' and pwdanswer='{strPwdAnswer}'";

            try
            {
                DataSet ds = new DataSet();

                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSQL, "temp");

                ret = ds.Tables[0].DefaultView.Count;

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show("CompareUserIdentity:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return 0;
            }
        }

        /// <summary>
        /// 更新用户数据, 来自忘记密码
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns>影响的行数</returns>
        public int UpdateUserInfo(User user)
        {
            int ret = 0;
            string strSQL = string.Empty;
            DBNull dbNull = DBNull.Value;

            strSQL = $"update users " +
                $"set nickname='{user.Nickname}',password='{user.Password}'," +
                $"mailaddress='{user.Mailaddress}',pwdquestion='{user.PwdQuestion}',pwdanswer='{user.PwdQuestion}' " +
                $"where ID='{user.ID}'";

            Access DBAccess = new Access();

            ret = DBAccess.ReadMySQL(strSQL);

            return ret;
        }

        /// <summary>
        /// 在更新密码时获得除密码之外的用户数据
        /// </summary>
        /// <param name="strUserId"></param>
        /// <returns></returns>
        public DataSet GetUserInfo(string strUserId)
        {
            string strSql = string.Empty;
            
            Access DBAccess = new Access();

            strSql = $"select nickname,mailaddress,pwdquestion,pwdanswer from users where ID='{strUserId}'";

            try
            {
                DataSet ds = new DataSet();
                ds = DBAccess.ReadMySQL(strSql, "temp");
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetUserInfo: " + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        /// <summary>
        /// 后台上传图片数据
        /// </summary>
        /// <param name="bytes">头像的二进制数据</param>
        /// <param name="strID">用户ID</param>
        /// <returns>影响的行数</returns>
        public int UplodaFile(byte[] FileBytes, string strPicIntroduction)
        {
            int ret = 0;
            string strSql = string.Empty;
            Access DBAccess = new Access();

            strSql = $"update files set file=@byteAvatar where introduction='{strPicIntroduction}'";

            ret = DBAccess.ReadMySQL(strSql, FileBytes);

            return ret;
        }

        /// <summary>
        /// 获得用户头像数据
        /// </summary>
        /// <param name="strID">用户ID</param>
        /// <returns>DataSet</returns>
        public DataSet GetUserAvatar(string strID)
        {
            string strSql = string.Empty;

            strSql = $"select avatar from users where ID='{strID}'";
          
            try
            {
                Access DBAccess = new Access();
                DataSet ds = new DataSet();
                ds = DBAccess.ReadMySQL(strSql, "temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetUserAvatar: " + e.Message, "警告", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                DataSet ds = new DataSet();
                return ds;
            }
        }

        /// <summary>
        /// 获取用户头像的加载图片
        /// </summary>
        /// <param name="strWhatsFilesIntroduction">FileIntroduction</param>
        /// <returns>DataSet</returns>
        public DataSet GetAvatarLoadingPic(string strWhatsFilesIntroduction)
        {
            Access DBAccess = new Access();
            try
            {
                DataSet ds = new DataSet();
                string strSQL = string.Empty;

                strSQL = $"select file from files where introduction='{strWhatsFilesIntroduction}'";

                ds = DBAccess.ReadMySQL(strSQL, "temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetAvatarLoadingPic: " + e.Message, "错误", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        #region 从数据库获取省市区的信息

        /// <summary>
        /// 从数据库获取所有省的信息
        /// </summary>
        /// <returns>ds.省</returns>
        public DataSet GetProvince()
        {
            string strSql = string.Empty;

            strSql = $"select province from province";

            try
            {
                DataSet ds = new DataSet();
                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSql, "temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetProvince: " + e.Message, "警告", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        /// <summary>
        /// 从数据库获取市的信息
        /// </summary>
        /// <param name="Province">省</param>
        /// <returns>ds.市</returns>
        public DataSet GetCityByProvince(string Province)
        {
            string strSql = string.Empty;

            strSql = $"select city from provinceandcity where province='{Province}'";

            try
            {
                DataSet ds = new DataSet();
                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSql, "temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetCityByProvince: " + e.Message, "警告", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        /// <summary>
        /// 从数据库获取区的信息
        /// </summary>
        /// <param name="Province">省</param>
        /// <param name="City">市</param>
        /// <returns>ds.区</returns>
        public DataSet GetDistrictByProvinceAndCity(string Province, string City)
        {
            string strSql = string.Empty;

            strSql = $"select district from china where province='{Province}' and city='{City}'";

            try
            {
                DataSet ds = new DataSet();
                Access DBAccess = new Access();

                ds = DBAccess.ReadMySQL(strSql, "temp");

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetDistrictByProvinceAndCity: " + e.Message, "警告", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }
        }

        #endregion
    }
}
