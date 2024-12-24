using Microsoft.EntityFrameworkCore;
using Shop2.Appliction.Interfaces.Context;
using Shop2.Doming.Entities.Categories;
using Shop2.Doming.Entities.Products;
using Shop2.Doming.Entities.Users;

namespace Shop2.Persistence.Context
{
    public class ShopContext : DbContext 
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}

