
using Microsoft.EntityFrameworkCore;
using MvcTutorial.Models;

namespace MvcTutorial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}