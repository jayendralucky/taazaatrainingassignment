using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UserManagementRepo.Repository;
using UserManagementRepo.Domain;
using UserManagementRepo.Service;
namespace UserManagementRepo.Controllers
{
    [ApiController]
    [Route("taazaa/[controller]")]
    public class UserController : ControllerBase
    {
        IUserProfileRepository userProfileRepository;
        IUserRepository userRepository;

        public UserController(IUserRepository _userRepository, IUserProfileRepository _userProfileRepository)
        {
            userProfileRepository = _userProfileRepository;
            userRepository = _userRepository;
        }
         [HttpPost]
        [Route("CreateUser")]
        public IActionResult createAccount(UserDTO model)
        {
            User userEntity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    AddedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
            return Ok(userRepository.InsertUser(userEntity));
        }
        [HttpPut("Edit/{id}")]
        
        public IActionResult UpdateAccount(UserDTO model)
        {
             User userEntity = userRepository.GetUser(model.Id);
            userEntity.Email = model.Email;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            UserProfile userProfileEntity = userProfileRepository.GetUserProfile(model.Id);
            userProfileEntity.FirstName = model.FirstName;
            userProfileEntity.LastName = model.LastName;
            userProfileEntity.Address = model.Address;
            userProfileEntity.ModifiedDate = DateTime.UtcNow;
            userProfileEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            
            userRepository.UpdateUser(userEntity);
            return Ok(model);
            if(model.Id==0)
            {
                return BadRequest();
            }
        }
        [HttpDelete("Delete/{id}")]
        public void DeleteUser(long id)
        {
            UserProfile userProfile = userProfileRepository.GetUserProfile(id);
            userRepository.DeleteUser(id);         
        }
        
    }
}