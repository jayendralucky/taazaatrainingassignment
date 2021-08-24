using System.Collections.Generic;
using System;
using switchassignment.Contactlist;
using switchassignment.Models;

namespace switchassignment.Contactlist
{
    public interface Icontact
    {
         void createList(ContactsList objc);
         void updatelist();
         void deletelist();
         List<Contact> DisplayList();

    }
}