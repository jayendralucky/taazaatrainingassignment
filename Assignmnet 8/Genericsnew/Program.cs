using System;
using Genericsnew.Model;
using Genericsnew.Contactlist;
using System.Collections.Generic;

namespace Genericsnew
{
    class Program
    {
        static void Main(string[] args)
        {
            Contactlists obj= new Contactlists();
            //var temp  = obj.createContact();
            List<Contact> obj1= obj.createContact();
            foreach(var i in obj1)
            {
                Console.WriteLine(i.ContactId+" "+i.ContactName+" " +i.Email+" "+i.PhoneNo);
            }
            
        }
    }
}
