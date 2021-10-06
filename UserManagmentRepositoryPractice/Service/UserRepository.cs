
using System.Collections.Generic;
using UserManagmentRepositoryPractice.Domain;
using UserManagmentRepositoryPractice.DataAcessLayer;

namespace UserManagmentRepositoryPractice.Service
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
            UserProfile userProfile = userprofileRepository.GetT(id);
            userprofileRepository.Remove(userProfile);
            // then we delete master table
            User user = userRepository.GetT(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        User IUserRepository.GetUser(long id)
        {
            return userRepository.GetT(id);
        }

        IEnumerable<User> IUserRepository.GetUsers()
        {
            return userRepository.GetAll();
        }

        int IUserRepository.InsertUser(User user)
        {
            return userRepository.insert(user);
        }

        void IUserRepository.UpdateUser(User user)
        {
            userRepository.update(user);
        }
    }
}