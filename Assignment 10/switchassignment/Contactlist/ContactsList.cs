using switchassignment.Models;
using System;
using System.Collections.Generic;
namespace switchassignment.Contactlist
{
    public class ContactsList
    {
        List<Contact> obj;
        public ContactsList()
        {
            obj= new List<Contact>();

        }
        public void createList( Contact objc)
        {
            obj.Add(objc);
        }
        public void updatelist()
        {

        }
        public void deletelist()
        {

        }
        public List<Contact> DisplayList()
        {
            return obj;
        }
        
    }
}