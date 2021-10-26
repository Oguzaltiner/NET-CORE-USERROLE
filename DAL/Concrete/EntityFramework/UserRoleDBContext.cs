using CORE.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete.EntityFramework
{
    public class UserRoleDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCap;Trusted_Connection=true");
        }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
