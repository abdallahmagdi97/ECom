using ECom.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Product> Product { get; set; }
<<<<<<< HEAD
        public DbSet<Category> Category { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Product_category> product_Categories { get; set; }
=======
<<<<<<< HEAD

        public DbSet<Category> Category { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Product_category> product_Categories { get; set; }
=======
>>>>>>> f80889a6a8e2ce6c6bde131f80699e0b84ff4a3f
        public DbSet<User> User { get; set; }
        public DbSet<Costumer> Costumer { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Operator> Operator { get; set; }
<<<<<<< HEAD
=======
>>>>>>> 821c587... adding user and its sub classes
>>>>>>> f80889a6a8e2ce6c6bde131f80699e0b84ff4a3f
    }
}
