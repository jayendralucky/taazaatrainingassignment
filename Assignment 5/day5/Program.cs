using System;
using day5.Models;

namespace day5
{
    class Program
    {
        static void Main()
        {
           var obj =new Employee();
          obj.Employeeid=101;//set is assigned here 
          Console.WriteLine(obj.Employeeid);//get is been called
          obj.EmployeeSalary = 500.89;
          Console.WriteLine(obj.EmployeeSalary); 
          var obj1 =new supplier();
          
        }
    }
}
