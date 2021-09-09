using  AssignemntTest.Models;
namespace AssignemntTest.Repository
{
    public interface IEmployeeList
    {
         Employee addEmployee(Employee emp);
         bool updateEmployee(Employee emp);
         bool deleteEmployee(Employee emp);
         Employee searchEmployee(int id);
    }
}