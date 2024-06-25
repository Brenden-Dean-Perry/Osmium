using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Interfaces
{
    public interface INotification
    {
        public Enums.NotificationResponse Notify(string Message);
        public Enums.NotificationResponse NotifyWarning(string Message);
        public Enums.NotificationResponse NotifyError(string Message);
        public Enums.NotificationResponse NotifyYesNo(string Message);
        public Enums.NotificationResponse NotifyWarningYesNo(string Message);
        public Enums.NotificationResponse NotifyErrorYesNo(string Message);
        public Enums.NotificationResponse Inputbox(string Message, int MaxAllowedCharaters = 100);
        public Enums.NotificationResponse InputboxDateTime(string Message, DateTime DefaultDateTime);
        public string GetInputBoxValue();
        public DateTime GetInputBoxDate();
    }
}
