using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.Common
{
    /// <summary>
    /// Base64编码实用类
    /// </summary>
    public class Base64Helper
    {
        #region Base64加密

        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="_Source">待加密的字符串</param>
        /// <returns>已加密的字符串</returns>
        public static string EncodeBase64(string _Source)
        {
            return EncodeBase64(Encoding.UTF8, _Source);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="_Encoding">加密采用的编码方式</param>
        /// <param name="_Source">待加密的明文</param>
        /// <returns>待加密的字符串</returns>
        public static string EncodeBase64(Encoding _Encoding, string _Source)
        {
            string encoding = string.Empty;
            byte[] bytes = _Encoding.GetBytes(_Source);
            try
            {
                encoding = Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {
                encoding = _Source;
            }
            return encoding;
        }
        #endregion

        #region Base64解密
        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string result)
        {
            return Base64Decode(Encoding.UTF8, result);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="encodeType">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(Encoding encodeType, string result)
        {
            string decode = string.Empty;
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encodeType.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }
        #endregion
    }
}
