using UserManagementRepo.Domain;
using System.Collections.Generic;
namespace UserManagementRepo.Repository
{
    public interface IRepository<T>where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
         
    }
}