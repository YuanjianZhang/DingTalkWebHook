using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DingTalk.Common
{
    public class HttpHelper
    {
        const int defaultTimeout = 180000;//默认超时3分钟
        const string defaultEncoding = "utf-8";//默认UTF8
        const int defaultEncodingCode = 65001;//默认UTF8
        const string defaultJsonMediaType = "application/json";
        const string defaultFormMediaType = "application/x-www-form-urlencoded";

        public static string Post(string url, string body, string MediaType = defaultJsonMediaType, string encoding = defaultEncoding, int timeout = defaultTimeout)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = timeout;
                request.ReadWriteTimeout = timeout;
                request.Method = "POST";
                request.ContentType = MediaType;
                request.Proxy = null;
                //request.Credentials = null; CredentialCache.DefaultCredentials;
                if (url.StartsWith("http", true, null))
                {
                    request.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
                }
                using (var requestStream = request.GetRequestStream())
                {
                    var bytes = Encoding.GetEncoding(encoding).GetBytes(body);
                    requestStream.Write(bytes, 0, bytes.Length);
                }

                var strRespone = string.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // 获取与响应关联的流。
                    using (var receiveStream = response.GetResponseStream())
                    {
                        // 将流传输到具有所需编码格式的更高级别的流读取器。
                        using (var readStream = new StreamReader(receiveStream, Encoding.UTF8))
                        {
                            strRespone = readStream.ReadToEnd();
                        }
                    }
                }
                return strRespone;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 以下方法由 RemoteCertificateValidationDelegate 调用
        /// 默认不校验服务器证书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="sslPolicyErrors"></param>
        /// <returns></returns>
        private static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            return true;
        }
    }
}
