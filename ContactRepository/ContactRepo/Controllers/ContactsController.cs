using ContactRepo.Repository;
using Microsoft.AspNetCore.Mvc;
using ContactRepo.Models;

namespace ContactRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController:ControllerBase
    {
        IContactsRepository contactsRepository;
        public ContactsController(IContactsRepository _contactsRepository)
        {
            contactsRepository = _contactsRepository; 
        }
        [HttpPost]
        public IActionResult CreateContact(Contacts contacts)
        {
            contactsRepository.Add(contacts);
            return Ok("Record is Added");
        } 
        [HttpPut]
        public IActionResult updateContact(Contacts contacts)
        {
            contactsRepository.update(contacts);
            return Ok("Reord has been Updated");
        }
        [HttpDelete("{Id}")]
        public IActionResult RemoveContact(int Id)
        {
            contactsRepository.Remove(Id);
            return Ok("Reord has been deleted");
        }
        [HttpGet("{Id:int}")]
        public IActionResult SearchContact(int Id)
        {
            var t = contactsRepository.Find(Id);
            return Ok(t);
        }
        [HttpGet("ContactList")]
        public IActionResult GetAllContact()
        {
            var t = contactsRepository.GetAll();
            return Ok(t);

        }


        
    }
}