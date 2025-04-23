using Microsoft.EntityFrameworkCore;
using UBook.API.Domain.Models;

namespace UBook.API.Repository.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    //    public DbSet<Book> Books { get; set; } = null!;
    //    public DbSet<Author> Authors { get; set; } = null!;
    //    public DbSet<Publisher> Publishers { get; set; } = null!;
    //    public DbSet<Genre> Genres { get; set; } = null!;
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    //        base.OnModelCreating(modelBuilder);
    //    }
    //}
    //{
    }
}
