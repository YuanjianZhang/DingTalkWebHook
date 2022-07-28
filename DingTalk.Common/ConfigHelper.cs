using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DingTalk.Common
{
    public class ConfigHelper
    {
        public static string GetAppSettings(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? string.Empty;
                return result;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static T GetConfigSection<T>(string section) where T : class
        {
            try
            {
                return ConfigurationManager.GetSection(section) as T;
            }
            catch
            {
                return default;
            }
        }
    }
}
