using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Common.Interfaces.Services;
using Posdea.Application.Models.UserSegment;
using Posdea.Application.Options;
using Posdea.Application.Services.Auth;
using Posdea.Application.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Services
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServicesConfiguration(this IServiceCollection services)
        {
            //auth
            services.AddScoped<IAuthService, AuthService>();
            //parameters
            services.AddScoped<IParameterService<RoleModel>, RoleService>();
            //entities
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IMenuOptionService, MenuOptionService>();
            return services;
        }
    }
}
