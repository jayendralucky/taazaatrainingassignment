using System.Collections.Generic;
using System.Linq;
using curdAssesmentPractice.Models;
namespace curdAssesmentPractice.Repository
{
    public class ContactsRepository : IContacts
    {
        List<Contacts> listContact = new List<Contacts>();
        void IContacts.Add(Contacts contacts)
        {
            listContact.Add(contacts);
        }

        Contacts IContacts.Find(int Id)
        {
            var contacts = listContact.Where(c=>c.EmployeeId==Id).SingleOrDefault();
            return contacts;
        }

        List<Contacts> IContacts.GetAll()
        {
            return listContact;
        }

        void IContacts.Remove(int Id)
        {
            var contactToRemove = listContact.Where(c=>c.EmployeeId==Id).SingleOrDefault();
            if(contactToRemove!=null)
            {
                listContact.Remove(contactToRemove);
            }
        }

        void IContacts.update(Contacts contacts)
        {
            var ContactToUpdate = listContact.Where(c=>c.EmployeeId==contacts.EmployeeId).SingleOrDefault();
            if(ContactToUpdate!=null)
            {
                ContactToUpdate.EmployeeName =contacts.EmployeeName;
                ContactToUpdate.EmployeeAddress =contacts.EmployeeAddress;
            }
        }
    }
}