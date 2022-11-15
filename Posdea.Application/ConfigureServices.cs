using Microsoft.Extensions.DependencyInjection;
using Posdea.Domain.Entities.UserSegment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Posdea.Application.Services.Entities;
using Posdea.Application.Services.Auth;
using System.Reflection;
using Posdea.Application.Models.UserSegment;
using Posdea.Application.Common.Interfaces.Services.Entities;
using Posdea.Application.Common.Interfaces.Services;

namespace Posdea.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //autoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //auth
            services.AddScoped<IAuthService,AuthService>();
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