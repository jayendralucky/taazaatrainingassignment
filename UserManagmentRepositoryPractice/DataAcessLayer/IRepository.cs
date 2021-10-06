using UserManagmentRepositoryPractice.Domain;
using System.Collections.Generic;
namespace UserManagmentRepositoryPractice.DataAcessLayer
{
    public interface IRepository<T>where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetT(long id);
        int insert (T entity);
        void update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();

         
    }
}