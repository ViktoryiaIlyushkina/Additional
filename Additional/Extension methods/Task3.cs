using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Extension_methods
{
    public static class DateTimeHelper
    {
        public static string ChooseType()
        {
            bool setType = false;
            string type = string.Empty;

            while (!setType)
            {
                Console.WriteLine("Please, choose output type:\n1. dd.MM.yyyy HH:mm:ss\n2. d month year");
                type = Console.ReadLine();

                if(type != null)
                {
                    setType = true;
                }
            }

            return type;
        }

        public static string FormatDateTime(this DateTime input, string type) => type switch
        {
            "1" => input.ToString("dd.MM.yyyy HH:mm:ss"),
            "2" => input.ToString($"D: {input.ToString("D")}"),
            _ => string.Empty,
        };
    }
}
