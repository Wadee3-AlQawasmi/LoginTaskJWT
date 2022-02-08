using JWTAUTH.IdentityAuth;
using JWTAUTH.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAUTH.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
  
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Course> course { set; get; }  

        public DbSet<Classes> classes { set; get; }
        
        public DbSet<ClassUsers> classUsers { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ClassUsers>().HasKey(cu => new {cu.Class_ID , cu.User_ID });
            base.OnModelCreating(builder);
        }
    }
}
