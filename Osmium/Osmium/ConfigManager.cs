using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DesktopUI
{
    internal class ConfigManager
    {
        private string _AppName = String.Empty;
        private int _FontSize = 12;
        internal ConfigManager()
        {

        }

        internal string GetAppName()
        {
            string SettingName = "AppName";
            if(ConfigurationManager.AppSettings[SettingName] is not null)
            {
                _AppName = ConfigurationManager.AppSettings[SettingName].ToString();
            }
            return _AppName;
        }

        internal int GetFontSize()
        {
            string SettingName = "FontSize";
            if (ConfigurationManager.AppSettings[SettingName] is not null)
            {
                _FontSize = Int32.Parse(ConfigurationManager.AppSettings[SettingName].ToString());
            }
            return _FontSize;
        }

    }
}
