using Microsoft.EntityFrameworkCore;
using WebBooks.API.Domain.Models;

namespace WebBooks.API.Repository.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
