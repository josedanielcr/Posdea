using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Posdea.Application.Common.Interfaces.Helpers;
using Posdea.Application.Helpers.Auth;
using Posdea.Application.Helpers.Common;
using Posdea.Application.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Application.Helpers
{
    public static class HelperConfiguration
    {
        public static IServiceCollection AddHelpersConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IErrorHelper, ErrorHelper>();
            services.AddScoped<IPasswordHelper, PasswordHelper>();
            services.AddScoped<ITokenHelper, TokenHelper>();
            return services;
        }
    }
}