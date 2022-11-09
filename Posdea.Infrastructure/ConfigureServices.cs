using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Posdea.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                 builder => builder.MigrationsAssembly(typeof(ApplicationDBContext).Assembly.FullName));
            });

            services.AddScoped<ApplicationDBContext>(provider => provider.GetRequiredService<ApplicationDBContext>());

            return services;
        }
    }
}
