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
            //entities
            services.AddScoped<ICrudService<UserModel>, UserService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICrudService<AddressModel>, AddressService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICrudService<RoleModel>, RoleService>();
            services.AddScoped<IRoleService, RoleService>();
            return services;
        }
    }
}
