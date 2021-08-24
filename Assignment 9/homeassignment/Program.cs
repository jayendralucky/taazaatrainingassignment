using System;
using System.Collections.Generic;

namespace homeassignment
{
    public class Program
    {
        public static void Main()
        {
           Employee emp1= new Employee()
           {
               ID = 101,
               Name ="lucky",
               Gender ="Male",
               Email = "Abc@gmail.com"

           };
           Employee emp2= new Employee()
           {
               ID = 102,
               Name ="Vicky",
               Gender ="Male",
               Email = "xyz@gmail.com"

           };
           Employee emp3= new Employee()
           {
               ID = 103,
               Name ="Kunal",
               Gender ="Male",
               Email = "poi@gmail.com"

           };
           Employee emp4= new Employee()
           {
               ID = 104,
               Name ="Kamal",
               Gender ="female",
               Email = "kamal@gmail.com"

           };
           List<Employee> list = new List<Employee>();
           list.Add(emp1);
           list.Add(emp2);
           list.Add(emp3);
           list.Add(emp4);
           for(int i=0;i<list.Count;i++)
           {
               Employee employee = list[i];
               Console.WriteLine("ID = {0},Name ={1},Gender ={2},Email={3}",employee.ID,employee.Name,employee.Gender,employee.Email);

           }
           //search the employee in the list
           if(list.Contains(emp2))
           {
               Console.WriteLine("Employee 2 exixts in the list");
           }
           else
           {
               Console.WriteLine("Employee 2 does not exist in the list");
           }
           // searching with letter 
           if(list.Exists(x => x.Name.StartsWith("K")))
           {
               Console.WriteLine("List contain the name starts with p");

           }
           else
           {
               Console.WriteLine("there is no name that starts with p");

           }
           Console.WriteLine("");

           // searching by id
           Employee emp = list.Find(emp =>emp.ID==104);
           Console.WriteLine("ID = {0},Name ={1},Gender ={2},Email={3}",emp.ID,emp.Name,emp.Gender,emp.Email);
           Console.WriteLine(" ");

           //removing from the list
           list.RemoveAt(3);
           for(int i=0;i<list.Count;i++)
           {
               Employee employee1 = list[i];
               Console.WriteLine("ID = {0},Name ={1},Gender ={2},Email={3}",employee1.ID,employee1.Name,employee1.Gender,employee1.Email);

           }
           Console.WriteLine(" ");
           // inserting the element 

           list.Insert(3,new Employee(){ID =105,Name="Ashish",Gender="Male",Email="qwe@gmail.com" });
           for(int i=0;i<list.Count;i++)
           {
               Employee employee2 = list[i];
               Console.WriteLine("ID = {0},Name ={1},Gender ={2},Email={3}",employee2.ID,employee2.Name,employee2.Gender,employee2.Email);

           }

        }
    }
    public class Employee
    {
        public int ID{ get; set;}
        public string Name{get;set;} 
        public string Gender{get;set;}
        public string Email{get;set;}

    }
}
