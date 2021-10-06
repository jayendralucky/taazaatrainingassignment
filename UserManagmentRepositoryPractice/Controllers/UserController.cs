using System;
using UserManagmentRepositoryPractice.DataAcessLayer;
using UserManagmentRepositoryPractice.Domain;
using UserManagmentRepositoryPractice.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UserManagmentRepositoryPractice.Controllers
{
    [ApiController]
    [Route("taazaa/[controller]")]
    public class UserController:ControllerBase
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
        public IActionResult CreateAccount(UserDTO model)
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
           return Ok( userRepository.InsertUser(userEntity)); 
               
           
        } 
        
    }
}