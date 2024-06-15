using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osmium
{
    internal class Notification : GeneralClassLibrary.Interfaces.INotification
    {
        private ConfigManager _configManager { get;}
        internal Notification(ConfigManager configManager)
        {
            _configManager = configManager;
        }
        public void NotifyError(string Message)
        {
            MessageBox.Show(null, Message, _configManager.GetAppName(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Notify(string Message)
        {
            MessageBox.Show(null, Message, _configManager.GetAppName(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void NotifyWarning(string Message)
        {
            MessageBox.Show(null, Message, _configManager.GetAppName(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
