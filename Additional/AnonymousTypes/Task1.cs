using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Additional.AnonymousTypes
{
    public class Person
    {
        public string Name { get; set; }
        public int Age{ get; set; }
    }

    public class Anonymous
    {
        public void UseAnonymousType()
        {
            var anon = new { Name = "Lola", Age = 18 };

            var persons = new List<Person>() 
            {
                new Person() { Name = "Lola", Age = 18 },
                new Person() { Name = "Tom", Age = 19 },
                new Person() { Name = "Sam", Age = 20 }, 
            }.Select(x => new { Name = x.Name, Age = x.Age }).ToList();

            Console.WriteLine(persons);

        }
    }
}
