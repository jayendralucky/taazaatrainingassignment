using  AssignemntTest.Models;
using AssignemntTest.Repository;
using Microsoft.AspNetCore.Mvc;
namespace AssignemntTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        IEmployeeList iemp;
        public EmployeeController(IEmployeeList ilist)
        {
            iemp = ilist;
        }

        [HttpPost("add")]
        public Employee addEmployee(Employee emp)
        {
            Employee t = iemp.addEmployee(emp);
           
            return emp;
        }
         [HttpPost("update")]
        public Employee updateEmployee(Employee emp)
        {
            bool t = iemp.updateEmployee(emp);
            if(t==false)
            {
                
            }
            return emp;
        }
         [HttpPost("delete")]
        public Employee deleteEmployee(Employee emp)
        {
            bool t = iemp.deleteEmployee(emp);
            if(t==false)
            {
                
            }
            return emp;
        }
             [HttpPost("search")]
            public Employee searchEmployee(Employee emp)
            {    
             int id =101;
             Employee emp1 = iemp.searchEmployee(id);
             if(emp1!=emp)
             {
                  
             }
            
             return emp1;
        }
    }
}