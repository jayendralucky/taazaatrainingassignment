using System.Threading.Tasks;
using ContactRepository.Models;
using ContactRepository.Context;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContactRepository.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        ContactsDbContext contactsDbContext;
        public ContactsRepository(ContactsDbContext _contactsDbContext)
        {
            contactsDbContext = _contactsDbContext;
            
        }

        async public Task<Contact> Find(int key)
        {
             return await contactsDbContext.contacts.SingleOrDefaultAsync(t=>t.Id==key);
        }

        async public Task<IEnumerable<Contact>> GetAll()
        {
            return await contactsDbContext.contacts.ToListAsync();
        }

        async Task IContactsRepository.Add(Contact item)
        {
             await contactsDbContext.AddAsync(item);
            await contactsDbContext.SaveChangesAsync();

        }

       
    }
}