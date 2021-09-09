using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ContactRepo.Models;

namespace ContactRepo.Repository
{
    public interface IContactsRepository
    {
        void Add(Contacts contacts);
        List<Contacts> GetAll();// Not Recommneded
        Contacts Find(int Id);// Searching a record by id returning record as a Contact
        void update(Contacts contacts);// we can update arecord by id or mail or returning as a void depend on the requirment
        void Remove(int Id);// we arae removing the record by id or returning as a void depends on the requirment


        
         
    }
}