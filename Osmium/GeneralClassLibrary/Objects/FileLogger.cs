using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.Objects
{
    public class FileLogger
    {
        private static string _LogFilePath { get; }
        private static string _AppName { get; set; }
        private static string _UserName { get; set; }

        public FileLogger()
        {

        }

        public static void LogMessage(string Message)
        {
            File.WriteAllText(_LogFilePath + GetAvailablFileName(), Message);
        }

        public static void LogException(Exception exception)
        {
            File.WriteAllText(_LogFilePath + GetAvailablFileName(), exception.Message + "\n \n" + exception.StackTrace.ToString());
        }

        private static string GetAvailablFileName()
        {
            return Utilities.FileUtilites.GetAvilableFileName(_LogFilePath, _AppName + " - LogFile - " + _UserName, ".txt");
        }
    }
}
