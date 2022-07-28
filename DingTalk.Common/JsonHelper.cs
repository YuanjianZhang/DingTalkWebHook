using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DingTalk.Common
{
    public class JsonHelper
    {
        public static string SerializeObject(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static T DeserializeObject<T>(string value)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch (Exception)
            {
                return default;
            }
        }

    }
}
