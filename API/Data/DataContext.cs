using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
    {
        optionbuilder.UseSqlite(@"Data Source=datingapp.db");
    }

        public DbSet<AppUser> Users { get; set; }
    }
}