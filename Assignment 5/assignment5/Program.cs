using System;

namespace assignment5
{
    class Employee
    {
        private Employee()
        {
            Console.WriteLine("This is a Private Constructor");
        }
        public static int Eid;
        public static string Ename;
        //Default Constructor
        public Employee(int i, string s)
        {
            Eid = i;
            Ename = s;
 }
 }
 class Program
 {

        public static void Main(string[] args)
        {
           var emp = new Employee(5, "Prashant");
 Console.WriteLine(Employee.Eid +"\n"+ Employee.Ename);
        }
    }
}
