using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary.Enums;
using BusinessLogicLibrary.Interfaces;

namespace DesktopUI
{
    internal class DesktopNotification : INotification
    {
        private string _AppName { get;}
        private string _InputBoxValueString { get; set; }
        private DateTime _InputBoxValueDate { set; get; }
        internal DesktopNotification(ConfigManager configManager)
        {
            _AppName = configManager.GetAppName();
        }
        public NotificationResponse NotifyError(string Message)
        {
            DialogResult result = MessageBox.Show(null, Message, _AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return GetNotificationResponse(result);
        }

        public NotificationResponse Notify(string Message)
        {
            DialogResult result = MessageBox.Show(null, Message, _AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return GetNotificationResponse(result);
        }

        public NotificationResponse NotifyWarning(string Message)
        {
            DialogResult result = MessageBox.Show(null, Message, _AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return GetNotificationResponse(result);
        }

        public NotificationResponse NotifyErrorYesNo(string Message)
        {
            DialogResult result = MessageBox.Show(null, Message, _AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            return GetNotificationResponse(result);
        }

        public NotificationResponse NotifyYesNo(string Message)
        {
            DialogResult result = MessageBox.Show(null, Message, _AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return GetNotificationResponse(result);
        }

        public NotificationResponse NotifyWarningYesNo(string Message)
        {
            DialogResult result = MessageBox.Show(null, Message, _AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return GetNotificationResponse(result);
        }

        public NotificationResponse Inputbox(string Message, int MaxAllowedCharaters = 100)
        {
            ClearInputValueStores();
            throw new NotImplementedException();
            DialogResult result = DialogResult.Yes;
            return GetNotificationResponse(result);
        }

        public NotificationResponse InputboxDateTime(string Message, DateTime DefaultDate)
        {
            ClearInputValueStores();
            throw new NotImplementedException();
            DialogResult result = DialogResult.Yes;
            return GetNotificationResponse(result);
        }

        public string GetInputBoxValue()
        {
            return _InputBoxValueString;
        }


        public DateTime GetInputBoxDate()
        {
            return _InputBoxValueDate;
        }

        private void ClearInputValueStores()
        {
            _InputBoxValueString = String.Empty;
            _InputBoxValueDate = DateTime.MinValue;
        }

        private NotificationResponse GetNotificationResponse(DialogResult dialogResult)
        {
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    return NotificationResponse.Yes;
                case DialogResult.No:
                    return NotificationResponse.No;
                default:
                    return NotificationResponse.Cancel;
            }
        }

    }
}
