using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralClassLibrary.Utilities
{
    public static class DataTypeUtilities
    {
        public static bool IsTypeNumeric(Type type)
        {
            HashSet<Type> NumericTypes = new HashSet<Type>{
                typeof(decimal),
                typeof(byte),
                typeof(sbyte),
                typeof(short),typeof(ushort),
                typeof(double),
                typeof(long), typeof(ulong),
                typeof(float),
                typeof(DateTime),
                typeof(DateOnly),
                typeof(int), typeof(uint)
            };

            return NumericTypes.Contains(type);
        }
    }
}
