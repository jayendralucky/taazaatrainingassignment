using ContactRepository.Context;
using System;
using ContactRepository.Models;
using ContactRepository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ContactRepository.Controllers
{
    public class ContactController:ControllerBase
    {
        IContactsRepository icontactRepository;
        public ContactController(IContactsRepository _icontactRepository)
        {
            icontactRepository =_icontactRepository;
            
        }
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            if(contact ==null)
            {
                return BadRequest();
            }
            await icontactRepository.Add(contact);
            return Ok(contact);

        }
    }
}