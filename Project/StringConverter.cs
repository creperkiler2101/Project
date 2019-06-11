using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Project
{
    public static class StringConverter
    {
        public static string GetBase64String(string original)
        { return Convert.ToBase64String(Encoding.GetEncoding(1252).GetBytes(original)); }

        public static string GetString(string base64String)
        { return Encoding.GetEncoding(1252).GetString(Convert.FromBase64String(base64String)); }


        private static char[] Symbols = new char[]
        {
            'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F',
            'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L',
            'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R',
            's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X',
            'y', 'Y', 'z', 'Z', '0', '1', '2', '3', '4', '5', '6', '7',
            '8', '9'
        };

        public static string GenerateRandomString()
        {
            string result = "";

            Random random = new Random();
            for (int i = 0; i < 32; i++)
            {
                int value_ = random.Next(0, Symbols.Length - 1);
                result += Symbols[value_];
            }

            return result;
        }
    }
}