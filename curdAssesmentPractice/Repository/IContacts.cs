using System.Collections.Generic;
using curdAssesmentPractice.Models;
namespace curdAssesmentPractice.Repository
{
    public interface IContacts
    {
         void Add(Contacts contacts);
         List<Contacts>GetAll();
         Contacts Find(int Id);
         void update(Contacts contacts);
         void Remove(int Id);

    }
}