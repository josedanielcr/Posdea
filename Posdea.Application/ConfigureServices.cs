using Microsoft.Extensions.DependencyInjection;
using Posdea.Application.Common.Interfaces;
using Posdea.Application.Services;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICrudService<User>, UserService>();
            services.AddScoped<ICrudService<Address>, AddressService>();
            services.AddScoped<ICrudService<Role>, RoleService>();
            return services;
        }
    }
}
