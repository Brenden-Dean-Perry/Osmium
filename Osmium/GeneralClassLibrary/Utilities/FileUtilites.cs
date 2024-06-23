using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassLibrary.Utilities
{
    public static class FileUtilites
    {
        public static string GetAvilableFileName(string FolderPath, string FileNameStart, string DotFileExtention)
        {
            int i = 0;
            FileNameStart = FileNameStart + "(" + DateTime.Now.ToStringFileFormat() + ") (";
            string FileNameEnding = ")" + DotFileExtention;
            while(File.Exists(FolderPath + FileNameStart + i.ToString() + FileNameEnding) == true)
            {
                i++;
            }
            return FileNameStart + i.ToString() + FileNameEnding;
        }
    }
}
