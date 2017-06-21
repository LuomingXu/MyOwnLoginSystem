using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataBaseAccessLayer
{
    /// <summary>
    /// 链接数据库
    /// </summary>
    public class Access
    {
        /// <summary>
        /// 操作MySQL数据库,获取DataSet
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="strDsName">DataSet的名字</param>
        /// <returns>DataSet</returns>
        public DataSet ReadMySQL(string strSQL, string strDsName)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection()
                {
                    ConnectionString = "server=182.254.223.162;user id=root;password=113210xlm~!XJY;persistsecurityinfo=True;database=word",
                };

                conn.Open();

                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                MySqlDataAdapter Mda = new MySqlDataAdapter()
                {
                    SelectCommand = cmd,
                };

                DataSet ds = new DataSet();

                Mda.Fill(ds, strDsName);

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("1 ReadMySQL:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }         
        }

        /// <summary>
        /// 操作MySQL数据库, 使用ExecuteNonQuery
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <returns>影响的行数</returns>
        public int ReadMySQL(string strSQL)
        {
            try
            {
                int ret = 0;

                MySqlConnection conn = new MySqlConnection()
                {
                    ConnectionString = "server=182.254.223.162;user id=root;password=113210xlm~!XJY;persistsecurityinfo=True;database=word",
                };

                conn.Open();

                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };
                
                ret = cmd.ExecuteNonQuery();

                conn.Close();

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show("2 ReadMySQL:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }           
        }

        /// <summary>
        /// 向数据库中添加图片文件
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="ImageBytes"></param>
        /// <returns></returns>
        public int ReadMySQL(string strSQL, byte[] ImageBytes)
        {
            try
            {
                int ret = 0;

                MySqlConnection conn = new MySqlConnection()
                {
                    ConnectionString = "server=182.254.223.162;user id=root;password=113210xlm~!XJY;persistsecurityinfo=True;database=word",
                };

                conn.Open();

                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                cmd.Parameters.AddWithValue("@byteAvatar", ImageBytes);

                ret = cmd.ExecuteNonQuery();

                conn.Close();

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show("3 ReadMySQL:" + e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// 向数据库中添加图片目录
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="FileName">文件目录</param>
        /// <param name="isFile">bool值</param>
        /// <returns>影响的行数</returns>
        public int ReadMySQL(string strSQL,string FileName,bool isFile)
        {
            try
            {
                int ret = 0;

                MySqlConnection conn = new MySqlConnection()
                {
                    ConnectionString = "server=182.254.223.162;user id=root;password=113210xlm~!XJY;persistsecurityinfo=True;database=word",
                };

                conn.Open();

                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                cmd.Parameters.Add("@FileName", MySqlDbType.VarChar);
                cmd.Parameters[0].Value = FileName;

                ret = cmd.ExecuteNonQuery();

                conn.Close();

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show("4 ReadMySQL:" + e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// 添加用户数据, 包含头像, 和头像路径
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="byteAVatar">byte[]</param>
        /// <param name="FileName">文件目录</param>
        /// <returns>影响的行数</returns>
        public int ReadMySQL(string strSQL,byte[] byteAVatar,string FileName)
        {
            try
            {
                int ret = 0;

                MySqlConnection conn = new MySqlConnection()
                {
                    ConnectionString = "server=182.254.223.162;user id=root;password=113210xlm~!XJY;persistsecurityinfo=True;database=word",
                };

                conn.Open();

                MySqlCommand cmd = new MySqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                cmd.Parameters.Add("@byteAvatar", MySqlDbType.MediumBlob);
                cmd.Parameters.Add("@FileName", MySqlDbType.VarChar);
                cmd.Parameters[0].Value = byteAVatar;
                cmd.Parameters[1].Value = FileName;

                ret = cmd.ExecuteNonQuery();

                conn.Close();

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show("5 ReadMySQL:" + e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// 操作SQLserver数据库,获取DataSet
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="strDsName">DataSet的名字</param>
        /// <returns>DataSet</returns>
        public DataSet ReadSQLserver(string strSQL, string strDsName)
        {
            try
            {
                SqlConnection conn = new SqlConnection()
                {
                    ConnectionString = "Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!",
                };

                conn.Open();

                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                SqlDataAdapter da = new SqlDataAdapter()
                {
                    SelectCommand = cmd,
                };

                DataSet ds = new DataSet();

                da.Fill(ds, strDsName);

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show("1 ReadSQLserver:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataSet ds = new DataSet();
                return ds;
            }          
        }

        /// <summary>
        /// 操作MSQLserver数据库, 使用ExecuteNonQuery
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <returns>影响的行数</returns>
        public int ReadSQLserver(string strSQL)
        {
            try
            {
                int ret = 0;

                SqlConnection conn = new SqlConnection()
                {
                    ConnectionString = "Data Source=182.254.223.162;Persist Security Info=True;User ID=sa;Password=113210xlm~!",
                };

                conn.Open();

                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = strSQL,
                };

                ret = cmd.ExecuteNonQuery();

                conn.Close();

                return ret;
            }
            catch (Exception e)
            {
                MessageBox.Show("2 ReadSQLserver:" + e.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }  
    }
}
