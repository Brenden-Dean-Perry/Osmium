using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessLogicLibrary.Utilities
{
    public static class ColorUtilities
    {
        public static Color FromRGBIntArray(int[] RGBColorArray)
        {
            return Color.FromArgb(RGBColorArray[0], RGBColorArray[1], RGBColorArray[2]);
        }
    }
}
