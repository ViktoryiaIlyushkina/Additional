using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Tuple
{
    public static class ListFunction
    {
        public static (int, int) GetMaxMinTuple(List<int> source)
        {
            return (source.Max(), source.Min());
        }
    }
}
