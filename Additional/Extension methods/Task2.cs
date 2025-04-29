using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Extension_methods
{
    public static class ListExtension
    {
        public static List<int> EvenNums (this List<int> source)
        {
            return source.Where(x => x%2 == 0).ToList();
        }
    }
}
