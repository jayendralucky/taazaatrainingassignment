using System;
using Genericsnew.Model;
using System.Collections.Generic;
namespace Genericsnew.Contactlist
{
    public class Contactlists
    {
        List<Contact> obj;
        public Contactlists()//if object of class is created then memory allocation will take place 
        {
            obj= new List<Contact>();

        }
        public List<Contact> createContact()
        {
            obj.Add(new Contact{
                ContactId=101,
                ContactName="lucky",
                Email="xyz@gmail.com",
                PhoneNo=997297440                

           });
           
            obj.Add(new Contact{
                ContactId=102,
                ContactName="Vicky",
                Email="hkki@gmail.com",
                PhoneNo=997456440                

           });
            obj.Add(new Contact{
                ContactId=103,
                ContactName="kartik",
                Email="jjj@gmail.com",
                PhoneNo=997297895                

           });
            obj.Add(new Contact{
                ContactId=104,
                ContactName="suman",
                Email="suman@gmail.com",
                PhoneNo=997662330                

           });
           return obj;

        }
        public void Modify()
        {
            obj.Insert(4,new Contact(){ContactId=105,ContactName="Ashish",Email="ash@gmail.com",PhoneNo=952662263});
            

        }
       
        public void Search()
        {
            Contact contact =obj.Find(contact=>contact.ContactId==104);
        }
        public void deleteContact()
        {
            int target =3;
            obj.RemoveAt(target);
            Console.WriteLine("Record deleted");
        }

        
    }
}