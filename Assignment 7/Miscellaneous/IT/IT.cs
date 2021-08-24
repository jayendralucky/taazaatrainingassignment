namespace Miscellaneous.IT
{
    public class Taazaa
    {
        double Salary;
        readonly int Empid;
        static string Cafetaria;

        public Taazaa(int eid,double sal)
        { 
            Salary = sal;
            Empid =eid;
        }

        static Taazaa()
        {
            Cafetaria = "Hundred sqft";
        }
        
        public int Employeeid()//memeber function
        {
            return Empid;
        }
        public static string CoffeeHouse()// static function
        {
            return Cafetaria;
        }
        public double EmployeeSalary()// memeber function
        {
            return Salary;
        }
    }
}