using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.Record
{
    public record Book(string Author, string Name, int Year);

    public record EBook(string Author, string Name, int Year, string Format) : Book (Author, Name, Year);
}
