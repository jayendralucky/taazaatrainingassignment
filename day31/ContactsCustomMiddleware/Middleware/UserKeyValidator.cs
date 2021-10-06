using System.Threading.Tasks;
using ContactsCustomMiddleware.Repository;
using Microsoft.AspNetCore.Http;

namespace ContactsCustomMiddleware.Middleware
{
    public class UserKeyValidator
    {
        private readonly RequestDelegate _next;
        private IContactRepository ContactsRepo { get; set; }
        public UserKeyValidator(RequestDelegate next)
        {
            _next = next;
            ContactsRepo = new ContactRepository();
        }
        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.Keys.Contains("user-key"))
            {
                context.Response.StatusCode = 400; //Bad Request                
                await context.Response.WriteAsync("User Key is missing");
                return;
            }
            else
            {
                if (!ContactsRepo.CheckValidUserKey(context.Request.Headers["user-key"]))
                {
                    context.Response.StatusCode = 401; //UnAuthorized
                    await context.Response.WriteAsync("Invalid User Key");
                    return;
                }
            }

            await _next.Invoke(context);
        }
    }
}