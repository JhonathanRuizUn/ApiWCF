using ApiTest.Core.Entities;
using ApiTest.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiTest.Core.UseCases
{
    public class UserInteractor
    {
        private readonly IRepository<User> _userRepository;

        public UserInteractor(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(int id)
        {
               return _userRepository.GetById(id);
        }

        public void UpdateUser(User user)
        {
               _userRepository.Update(user);
        }
        public void DeleteUser(int id)
        {
               _userRepository.Delete(id);
        }
        public IEnumerable<User> GetAllUsers()
        {
               return _userRepository.GetAll();
        }

        public void AddUser(User user)
        {
               _userRepository.Add(user);
        }


    }
}