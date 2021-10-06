using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login.Repository;
using login.Models;
namespace login.Controllers
{
     [ApiController]
     [Route("[controller]")]
    public class MembershipController:ControllerBase
    {
        IMembership _imembership;
        public MembershipController(IMembership imembership)
        {
            _imembership=imembership;
            
        }
        [HttpPost]
        public IActionResult Postuser(MemberDTO membership)
        {
            int res =_imembership.AddUser(membership);
            if(res!=0)
            {
                return Ok("saved");

            }
            return Forbid();
        }
         [HttpGet]
       [Route("searchUser/{userName}/{pass}")]
       public IActionResult SearchUser(string userName)
       {
           var userObj = _imembership.SearchUser(userName);
           if(userObj!= null)
           {
               return Ok("not good");
           }
           else
           {
               return Ok("good");
           }
       }
        
    }
}