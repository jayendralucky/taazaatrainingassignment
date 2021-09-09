using System.Collections.Generic;
using System.Linq;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public class ContactsRepository : IContactsRepository
    {
       List<Contacts> listContact = new List<Contacts>();//list contact is an object to perform the manipulation 
        void IContactsRepository.Add(Contacts contacts)
        {
            listContact.Add(contacts);
        }

        Contacts IContactsRepository.Find(int Id)
        {
            var contacs = listContact.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
            return contacs;
        }

        List<Contacts> IContactsRepository.GetAll()
        {
            /* listContact.Add(new Contacts{
                EmployeeId = 101,
                EmployeeName ="Lucky",
                EmployeeMail ="abc@gmail.com"
            });
             listContact.Add(new Contacts{
                EmployeeId = 102,
                EmployeeName ="Shivam",
                EmployeeMail ="xyz@gmail.com"
            }); */
            return listContact;
        }

        void IContactsRepository.Remove(int Id)
        {
            var contacsToRemove = listContact.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
            if(contacsToRemove!=null)
            {
                listContact.Remove(contacsToRemove);

            }
            
        }

        void IContactsRepository.update(Contacts contacts)
        {
            var contacToUpdate = listContact.Where(ctr=>ctr.EmployeeId==contacts.EmployeeId).SingleOrDefault(); 
            if(contacToUpdate !=null)
            {
                contacToUpdate.EmployeeName=contacts.EmployeeName;
                contacToUpdate.EmployeeMail=contacts.EmployeeMail;

            }   
            
        }
    }
}