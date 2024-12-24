using Microsoft.EntityFrameworkCore;
using Shop2.Doming.Entities.Categories;
using Shop2.Doming.Entities.Products;
using Shop2.Doming.Entities.Users;

namespace Shop2.Appliction.Interfaces.Context
{
    public interface IShopContext
    {
         DbSet<Category> Categories { get; set; }
         DbSet<Product> Products { get; set; }
         DbSet<User> Users { get; set; }
         DbSet<Role> Roles { get; set; }
         DbSet<UserInRole> UserInRoles { get; set; }

        int SaveChange(bool accseptAllChangesOnSucsses);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool accseptAllChangesOnSucsses,CancellationToken cancellationToken=new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
