using System;
using Miscellaneous.IT;

namespace Miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mohan = new Taazaa(101,1000);
            var Sachin = new Taazaa(102,2000);
            
            var Sal = Mohan.EmployeeSalary();
            Console.WriteLine(Sal);
            
            var Sall = Sachin.EmployeeSalary();
            Console.WriteLine(Sall);

            var Coffe = Taazaa.CoffeeHouse();
            Console.WriteLine(Coffe);

            Console.WriteLine(Taazaa.CoffeeHouse());


        }
    }
}
