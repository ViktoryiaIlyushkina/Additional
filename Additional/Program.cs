using Additional.AnonymousTypes;
using Additional.Extension_methods;
using Additional.Record;
using Additional.Tuple;

namespace Additional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.1
            string original = "   Это   пример   строки  с  лишними   пробелами.    ";
            Console.WriteLine("Оригинальная строка:");
            Console.WriteLine($"[{original}]");

            // Использование метода расширения
            string processed = original.RemoveExtraSpaces();
            Console.WriteLine("Обработанная строка:");
            Console.WriteLine($"[{processed}]");
            Console.WriteLine("\n", 3);


            //1.2
            List<int> source = new List<int>() { 1,2,3,4,5,6,7 };
            List<int> evenList = source.EvenNums();
            Console.Write("EvenList: ");
            foreach (var x in evenList)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine("\n", 3);


            //1.3
            DateTime someDate = DateTime.Now;
           var type = DateTimeHelper.ChooseType();
           Console.WriteLine(someDate.FormatDateTime(type));
           Console.WriteLine("\n", 3);


            // 1.4
            // Примеры email-адресов для проверки
            List<Account> accounts = new List<Account>()
            {
                new Account() { ID = 1, Email = "test@example.com" },
                new Account() { ID = 2, Email = "user@domain" },
                new Account() { ID = 3, Email = "name.lastname@sub.domain.com" },
                new Account() { ID = 4, Email = "@missingusername.com" },
                new Account() { ID = 5, Email = "invalid@@example.com" },
                new Account() { ID = 6, Email = string.Empty },
                new Account() { ID = 7, Email = "" }
            };
           
            foreach (var account in accounts)
            {
                Console.WriteLine(account.CheckEmail());
            }
            Console.WriteLine("\n", 3);


            //3.1
            var test = new Anonymous();
            test.UseAnonymousType();
            Console.WriteLine("\n", 3);


            //3.2
            var requestResult = new RequestResult();
            var res = requestResult.GetModels();
            foreach (var model in res)
            {
                Console.WriteLine(model.Email);
            }
            Console.WriteLine("\n", 3);

            //3.3
            var test1 = new { Person = new { Address = "www.leningrad.ru"}  };


            //4.1
            var resultTuple = ListFunction.GetMaxMinTuple(new List<int> { 1, 2, 3, 4, 5 });
            Console.WriteLine(resultTuple);
            Console.WriteLine("\n", 3);


            //4.2
            var point = new Point() { X = 13, Y = 31 };
            var coordinates = point.GetCoordinates();
            Console.WriteLine($"X: {coordinates.coordinateX}, Y: {coordinates.coordinateY}");
            Console.WriteLine("\n", 3);


            //5.1
            var book = new Book( "Amor Towels", "A Gentleman in Moscow", 2018 );
            Console.WriteLine( book.Author);
            Console.WriteLine("\n", 3);


            //5.3
            //book.Author = "John Green";

            //5.5.

            List<Book> books = new List<Book> { book, new Book("John Green", "Paper Towns", 2000) };

        }
    }
}
