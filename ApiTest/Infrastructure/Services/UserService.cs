using ApiTest.App_Start;
using ApiTest.Core.Entities;
using ApiTest.Core.UseCases;
using ApiTest.IAdapters.ServiceContracts;
using ApiTest.Infrastructure.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiTest.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserInteractor userInteractor;
        private readonly ApplicationDbContext _context;
        public UserService()
        {
            _context = new ApplicationDbContext();
            userInteractor = new UserInteractor(new UserRepository(_context));

        }

        public void AddUser(User user)
        {
            userInteractor.AddUser(user);
        }
        public void DeleteUser(int id)
        {
            userInteractor.DeleteUser(id);
        }
        public void UpdateUser(User user)
        {
            userInteractor.UpdateUser(user);
        } 
        public User GetUser(int id)
        {
            return userInteractor.GetUser(id);

        }
        public IEnumerable<User> GetAllUsers()
        {
            return userInteractor.GetAllUsers();
        }

    }
}