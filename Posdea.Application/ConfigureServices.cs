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
using Posdea.Application.Options;
using Microsoft.Extensions.Configuration;
using Posdea.Application.Services;

namespace Posdea.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //options
            services.Configure<TokenConfiguration>(configuration.GetSection("keys"));
            //autoMapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services
            services.AddServicesConfiguration();
            return services;
        }
    }
}