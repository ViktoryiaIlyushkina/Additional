using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Extension_methods
{
    public static class StringHelper
    {
        // Метод расширения для удаления лишних пробелов из строки
        public static string RemoveExtraSpaces(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return string.Empty;
            }

            // Убираем пробелы в начале и конце, а также заменяем несколько пробелов подряд на один
            return string.Join(" ", input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
