using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserManagementRepo.Domain;
using System.Linq;

namespace UserManagementRepo.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        ApplicationContext context;
        DbSet<T> entities;
        public Repository(ApplicationContext _Context)
        {
            context=_Context;
            entities=context.Set<T>();

        }

        void IRepository<T>.Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
            context.SaveChanges();
           
        }

        T IRepository<T>.Get(long id)
        {
           return entities.SingleOrDefault(t=>t.Id==id);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return entities.AsEnumerable();
        }

        int IRepository<T>.Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            context.Add(entity);
            return context.SaveChanges();
           
        }

        void IRepository<T>.Remove(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
        }

        void IRepository<T>.SaveChanges()
        {
            context.SaveChanges();
            
        }

        void IRepository<T>.Update(T entity)
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

        