
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Models;

namespace ShoppingCart.Service.Data
{
  public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<Category> Categories{get; set;}
        public DbSet<Product> Products{get; set;}
        
    }
}