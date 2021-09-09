using AssignemntTest.Models;
using System.Collections.Generic;
namespace AssignemntTest.Repository
{
    public class EmployeeList:IEmployeeList
    {
        List<Employee> lists;
        public EmployeeList()
        {
            lists = new List<Employee>();
        }
        
       public Employee addEmployee(Employee emp)
       {
           lists.Add(emp);
           return emp;
       }
       public bool updateEmployee(Employee emp)
       {
           string nme = "Mike";
           int slry = 253667;
           emp.EmployeeName=nme;
           emp.EmployeeSalary=slry;
           return true;
       }
       public bool deleteEmployee(Employee emp)
       {
           lists.Remove(emp);
           return true;
       }
       public Employee searchEmployee(int id)
       {

            return lists.Find(e=>e.EmployeeID==id);       
           
       }
    }
}