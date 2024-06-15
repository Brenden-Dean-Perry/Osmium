using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassLibrary.Interfaces
{
    public interface INotification
    {
        public void Notify(string Message);
        public void NotifyWarning(string Message);
        public void NotifyError(string Message);
    }
}
