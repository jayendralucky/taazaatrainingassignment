using ContactsCustomMiddleware.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactsCustomMiddleware.Repository
{
    public interface IContactRepository
    {
        Task Add(Contacts item);
        Task<IEnumerable<Contacts>> GetAll();
        Task<Contacts> Find(string key);
        Task Remove(string Id);
        Task Update(Contacts item);

        bool CheckValidUserKey(string reqkey);
    }
}