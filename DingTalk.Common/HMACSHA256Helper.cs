using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace DingTalk.Common
{
    /// <summary>
    /// HMACSHA256使用类
    /// </summary>
    public class HMACSHA256Helper
    {
        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="key">签名秘钥</param>
        /// <param name="data">需要算签名的字符串</param>
        /// <returns>加密数据</returns>
        public static string ComputeSignature(string key, string data)
        {
            byte[] signData = Sign(Encoding.UTF8.GetBytes(key), Encoding.UTF8.GetBytes(data));
            return Convert.ToBase64String(signData);
        }

        /// <summary>
        /// 计算签名 byte[]数据
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        private static byte[] Sign(byte[] key, byte[] data)
        {
            HMACSHA256 sha256 = new HMACSHA256(key);
            return sha256.ComputeHash(data);
        }
    }
}
