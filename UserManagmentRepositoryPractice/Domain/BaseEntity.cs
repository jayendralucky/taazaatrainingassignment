using System;
namespace UserManagmentRepositoryPractice.Domain
{
    public class BaseEntity
    {
        public int Id{get;set;}
        public DateTime AddedDate{get;set;}
        public DateTime ModifiedDate{get;set;}
        public string IPAddress{get;set;}
        
    }
}