using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{

    public static class ApplicationServiceExtencisons
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlite(config.GetConnectionString("DefaulConnetion"));
        });
            services.AddCors();
            services.AddScoped<ItokenService, TokenServices>();
            return services;
        }


    }
}