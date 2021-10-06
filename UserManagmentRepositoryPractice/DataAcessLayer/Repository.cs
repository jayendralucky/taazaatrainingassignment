using UserManagmentRepositoryPractice.Domain;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
namespace UserManagmentRepositoryPractice.DataAcessLayer
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        UserContext context;
        DbSet<T> entities;
        public Repository(UserContext _context)
        {
            context =_context;
            entities=context.Set<T>();
            
        }
        void IRepository<T>.Delete(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
            context.SaveChanges();
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return entities.AsEnumerable();
        }

        T IRepository<T>.GetT(long id)
        {
            return entities.SingleOrDefault(t=>t.Id==id);
        }

        int IRepository<T>.insert(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
            return context.SaveChanges();
        }

        void IRepository<T>.Remove(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
            
        }

        void IRepository<T>.SaveChanges()
        {
            context.SaveChanges();
        }

        void IRepository<T>.update(T entity)
        {
             if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Update(entity);
            context.SaveChanges();
            
        }
    }
}