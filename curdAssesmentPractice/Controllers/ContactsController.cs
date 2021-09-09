using System;
using curdAssesmentPractice.Models;
using curdAssesmentPractice.Repository;
using Microsoft.AspNetCore.Mvc;

namespace curdAssesmentPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController:ControllerBase
    {
        IContacts contactRepository;
        public ContactsController(IContacts _contactRepository)
        {
            contactRepository = _contactRepository;
        }
        [HttpPost]
        public IActionResult CreateContact(Contacts contacts)
        {
            contactRepository.Add(contacts);
            return Ok("Record Added");
        }
        [HttpPut]
        public IActionResult UpdateContact(Contacts contacts)
        {
            contactRepository.update(contacts);
            return Ok("Record is added");
        }
        [HttpDelete("{ID}")]
        public IActionResult RemoveContact(int Id)
        {
             contactRepository.Remove(Id);
            return Ok("Record  is Removed ");
        }
        [HttpGet("{Id:int}")]
        public IActionResult SearchContact(int Id)
        {
            var t= contactRepository.Find(Id);
            return Ok(t);
        }
        [HttpGet("CONTACT")]
        public IActionResult GetAllContact()
        {
            var t= contactRepository.GetAll();
            return Ok(t);
        }



        
    }
}