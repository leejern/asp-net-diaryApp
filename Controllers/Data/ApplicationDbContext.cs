using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers.Data
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet for DiaryEntry table
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        // override onmodelcreating method  to create seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "First Entry", Content = "This is my first diary entry.", DateCreated = DateTime.Now },
                new DiaryEntry { Id = 2, Title = "Second Entry", Content = "This is my second diary entry.", DateCreated = DateTime.Now }, 
                new DiaryEntry { Id = 3, Title = "Third Entry", Content ="This is my third unhappy entry.", DateCreated = DateTime.Now }
            );
        }
    }
}
