using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Manages Users
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//DB
using Microsoft.EntityFrameworkCore;

namespace BasicAuthentication.Models
{
    //Identity comes with a class to represent a user 'IdentityDbContext<ApplicationUser'
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        //ToDo Models DbSet
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Item> Items { get; set; }
    }
}
