using System.Collections.Generic;
using System;
using UserManagementRepo.Repository;
using UserManagementRepo.Domain;

namespace UserManagementRepo.Service
{


    public class UserRepository : IUserRepository
    {
        IRepository<User> userRepository;
        IRepository<UserProfile> userprofileRepository;
        public UserRepository(IRepository<User> _userRepository,IRepository<UserProfile> _userprofileRepository)
        {
            userRepository =_userRepository;
            userprofileRepository = _userprofileRepository;
            
        }
        void IUserRepository.DeleteUser(long id)
        {
            // first we need to delete from the dependent table
            UserProfile userProfile = userprofileRepository.Get(id);
            userprofileRepository.Remove(userProfile);
            // then we delete master table
            User user = userRepository.Get(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        User IUserRepository.GetUser(long id)
        {
            return userRepository.Get(id);
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            return userRepository.GetAll();
        }

        int IUserRepository.InsertUser(User user)
        {
             return userRepository.Insert(user);
        }

        void IUserRepository.UpdateUser(User user)
        {
           userRepository.Update(user);
        }
    }
}