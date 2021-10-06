using Microsoft.AspNetCore.Mvc;
using Test.Repository;
using Test.Model;
using AutoMapper;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        IAccountRepository accountRepository;
        IMapper imapper;

        public AccountController(IAccountRepository _accountRepository, IMapper _imapper)
        {
            accountRepository = _accountRepository;
            imapper = _imapper;
        }

        [HttpPost]
        [Route("AddUser")]

        public IActionResult AddUser(AccountDTO accountDTO)
        {
            var accountmap = imapper.Map<Account>(accountDTO);
            // Account account1 = new Account();
            // account1.Username = account.Username;
            // account1.Password = account.Password;
            // account1.Age = account.Age;

            accountRepository.createUser(accountmap);
            if(accountmap==null)
            return Ok("Invalid User!");
            else
            return Ok("Account Created!");
        }

        [HttpGet]
        [Route("SearchUser")]

        public IActionResult SearchUser(string usern, string pass)
        {
            var temp = accountRepository.SearchUser(usern,pass);
            if(temp!=null)
            return Ok("Logged In");
            else
            return Ok("User Not Found!");
        }
    }
}