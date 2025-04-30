using Microsoft.EntityFrameworkCore;

namespace WebBooks.API.Repository.Context
{
    public static class DbRegister
    {
        public static void Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
