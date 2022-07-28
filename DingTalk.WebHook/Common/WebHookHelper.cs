using DingTalk.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalk.WebHook.Common
{
    public class WebHookHelper
    {
        private static readonly string Config_Uri = "webhookuri";
        private static readonly string Config_Key = "securitykey";
        public static string CombineRequestUrl()
        {
            var webhookuri = ConfigHelper.GetAppSettings(Config_Uri);
            var key = ConfigHelper.GetAppSettings(Config_Key);
            var timestamp =new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
            var signstr = $"{timestamp}\n{key}";
            var sign = HMACSHA256Helper.ComputeSignature(key, signstr);
            var signUrlEncode = System.Net.WebUtility.UrlEncode(sign);//default Encoding is UTF8

            var ub = new UriBuilder(webhookuri);
            
            if (ub.Query != null && ub.Query.Length > 1)
                ub.Query = ub.Query.Substring(1) + "&" + $@"timestamp={timestamp}&sign={signUrlEncode}";
            else
                ub.Query = $@"timestamp={timestamp}&sign={signUrlEncode}";
            return ub.Uri.AbsoluteUri.ToString();
        }
    }
}
