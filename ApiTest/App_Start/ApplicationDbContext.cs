using ApiTest.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiTest.App_Start
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext() : base(System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}