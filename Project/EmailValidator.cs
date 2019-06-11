using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project
{
    public class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;

            string[] emailSplit = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            if (emailSplit.Length != 2) return false;

            string[] emailPart2Split = emailSplit[1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (emailPart2Split.Length != 2) return false;

            return true;
        }
    }
}