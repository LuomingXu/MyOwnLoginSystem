using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;
using System.Reflection;

namespace Model
{
    /// <summary>
    /// 用户的类
    /// </summary>
    public class User
    {
        private string _ID = string.Empty;
        private string _nickname = string.Empty;
        private string _password = string.Empty;
        private string _mailaddress = string.Empty;
        private string _pwdquestion = string.Empty;
        private string _pwdanswer = string.Empty;
        private byte[] _avatar = null;
        private string _filenameOFavatar = string.Empty;

        /// <summary>
        /// ID主键
        /// </summary>
        public string ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname
        {
            set { _nickname = value; }
            get { return _nickname; }
        }

        /// <summary>
        /// 密码,unNull
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Mailaddress
        {
            set { _mailaddress = value; }
            get { return _mailaddress; }
        }

        /// <summary>
        /// 密码提示问题
        /// </summary>
        public string PwdQuestion
        {
            set { _pwdquestion = value; }
            get { return _pwdquestion; }
        }

        /// <summary>
        /// 提示问答案
        /// </summary>
        public string PwdAnswer
        {
            set { _pwdanswer = value; }
            get { return _pwdanswer; }
        }

        /// <summary>
        /// 头像
        /// </summary>
        public byte[] Avatar
        {
            set { _avatar = value; }
            get { return _avatar; }
        }

        /// <summary>
        /// 头像的路径
        /// </summary>
        public string FileNameOfAvatar
        {
            set { _filenameOFavatar = value; }
            get { return _filenameOFavatar; }
        }
    }

    /// <summary>
    /// 获取图片扩展名的类
    /// </summary>
    public class Pic
    {
        /// <summary>
        /// 获得图片信息的Guid
        /// </summary>
        /// <returns></returns>
        private static Dictionary<String, ImageFormat> GetImageFormats()
        {
            var dic = new Dictionary<String, ImageFormat>();
            var properties = typeof(ImageFormat).GetProperties(BindingFlags.Static | BindingFlags.Public);
            foreach (var property in properties)
            {
                var format = property.GetValue(null, null) as ImageFormat;
                if (format == null) continue;
                dic.Add(("." + property.Name).ToLower(), format);
            }
            return dic;
        }

        private static Dictionary<String, ImageFormat> _imageFormats;

        /// <summary>
        /// 保存获取的图片Guid
        /// </summary>
        private static Dictionary<String, ImageFormat> ImageFormats
        {
            get
            {
                return _imageFormats ?? (_imageFormats = GetImageFormats());
            }
        }

        /// <summary>
        /// 根据图像获取图像的扩展名
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static String GetExtension(Image image)
        {
            foreach (var pair in ImageFormats)
            {
                if (pair.Value.Guid == image.RawFormat.Guid)
                {
                    return pair.Key;
                }
            }
            throw new BadImageFormatException();
        }
    }
}
