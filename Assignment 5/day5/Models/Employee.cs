namespace day5.Models
{
    public class Employee
    {
        private int Eid;
        private double Salary;
        public int Employeeid//properties
        {
            get//access
            {

                return Eid;

            }
            set//assign
            {
                Eid =value;//value is a reserve keyword to assign the data to variable

            }

        }
        public double EmployeeSalary
        {
            get 
            {
                return Salary;
            }
            set
            {
                Salary=value;

            }
        }
    }
}