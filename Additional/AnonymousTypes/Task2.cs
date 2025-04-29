using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.AnonymousTypes
{
    public class Car
    {
        public string Model { get; set; }
        public int ProductionYear { get; set; }
    }
    public class RequestResult
    {

        public List<dynamic> GetModels() 
        {

            var data = new List<dynamic>
            {
                new { Id = 1, Name = "Alice", Age = 25, Email = "alice@example.com" },
                new { Id = 2, Name = "Bob", Age = 30, Email = "bob@example.com" },
                new { Id = 3, Name = "Charlie", Age = 35, Email = "charlie@example.com" }
            };
            return data;
        }
    }
}
