using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional.PartialClass
{
    public partial class User
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {ID}\nName: {Name}\nSurname: {Surname}\nEmail: {Email}");
        }

        public void UpdateEmail()
        {
            Console.WriteLine("Enter new Email:");
            Email = Console.ReadLine();
        }

    }
}
