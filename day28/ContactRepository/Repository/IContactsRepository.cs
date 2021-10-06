using System.Threading.Tasks;
using ContactRepository.Models;
using System.Collections.Generic;
namespace ContactRepository.Repository
{
    public interface IContactsRepository
    {
         Task Add(Contact item);
         Task<IEnumerable<Contact>> GetAll();

        Task<Contact> Find(int key);
    }
}