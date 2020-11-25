using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace KIS.System.Advanced.Support
{
    public static class CalculateMD5Hash
    {
        public static string Generate(string input)
        {
            // Calcular o Hash
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Converter byte array para string hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
