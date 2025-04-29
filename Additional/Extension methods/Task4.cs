using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Additional.Extension_methods
{
    public class Account
    {
        public int ID { get; set; }
        public string Email { get; set; }
    }

    public static class StringExtension
    {
        public static string CheckEmail(this Account source)
        {
            if (string.IsNullOrEmpty(source.Email))
            {
                return $"Email \"{source.Email}\" является недействительным.";
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(source.Email, emailPattern))
            {
                return $"Email \"{source.Email}\" является недействительным.";
            }

            return $"Email \"{source.Email}\" является валидным.";
        }
    }
}
