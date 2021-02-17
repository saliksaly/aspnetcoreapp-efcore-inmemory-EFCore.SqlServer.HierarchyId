using ConsoleApp1.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(
                "inmemdb", 
                x => x.UseHierarchyId());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
