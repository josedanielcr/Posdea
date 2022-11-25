using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Posdea.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posdea.Infrastructure.Configurations
{
    public static class ProjectsConfig
    {
        public static IServiceCollection AddProjectsConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationServices(configuration);
            services.AddInfrastructureServices(configuration);
            return services;
        }
    }
}
