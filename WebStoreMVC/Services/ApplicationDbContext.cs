using Microsoft.EntityFrameworkCore;
using WebStoreMVC.Models;
namespace WebStoreMVC.Services
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
