using ApiTest.App_Start;
using ApiTest.Core.Entities;
using ApiTest.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiTest.Infrastructure.Repositorios
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.Id == user.Id);

            if (userToUpdate != null)
            {
                userToUpdate.Name = user.Name;
                userToUpdate.Birthdate = user.Birthdate;
                userToUpdate.Gender = user.Gender;
            }
            
            _context.Entry(userToUpdate).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var userToDelete = _context.Users.FirstOrDefault(u => u.Id == id);
            if (userToDelete != null)
            {
                _context.Users.Remove(userToDelete);
            }

            _context.SaveChanges();
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }
        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

    }
}