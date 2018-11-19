using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.Interfaces;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.Configuration
{
    class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser= ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType),browser);
        }

        public int GetElementloadTime()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeOut);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public int GetPageloadTime()
        {
            string timeout=ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeOut);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
        public DeviceType GetDevice()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.DeviceType);
            return (DeviceType)Enum.Parse(typeof(DeviceType), browser);
         }

        public string GetDeviceName()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.DeviceName);
         }
    }
}
