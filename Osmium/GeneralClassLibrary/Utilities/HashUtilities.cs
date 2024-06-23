using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GeneralClassLibrary.Utilities
{
    public static class HashUtilities
    {
        public static byte[] HashFile(string filePath, HashAlgorithmName hashAlgorithm)
        {
            using(var hash = HashAlgorithm.Create(hashAlgorithm.Name))
            {
                using(var stream = File.OpenRead(filePath))
                {
                    return hash.ComputeHash(stream);
                } 
            }
        }

        public static byte[] HashString(string inputString, HashAlgorithmName hashAlgorithm)
        {
            using(var hash = HashAlgorithm.Create(hashAlgorithm.Name))
            {
                return hash.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            }
        }

        public static string ByteArrayToStringUTF8(byte[] byteArray)
        {
            return Encoding.UTF8.GetString(byteArray,0, byteArray.Length);
        }

        public static byte[] ByteArrayToStringUTF8(string inputString)
        {
            return Encoding.UTF8.GetBytes(inputString);
        }

        public static string ByteArrayToHexidecimalString(byte[] byteArray)
        {
            StringBuilder hex = new StringBuilder(byteArray.Length * 2);
            foreach(byte b in byteArray)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        public static byte[] HexadecimalStringToByteArray(string hexidecimalString)
        {
            int NumberCharaters = hexidecimalString.Length;
            byte[] byteArray = new byte[NumberCharaters /2];
            for(int i = 0; i < NumberCharaters; i+= 2)
            {
                byteArray[i / 2] = Convert.ToByte(hexidecimalString.Substring(i, 2), 16);
            }
            return byteArray;
        }
    }
}
