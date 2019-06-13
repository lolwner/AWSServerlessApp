using AWSAPP.DataAccess;
using AWSAPP.DataAccess.Repositories;
using AWSAPP.DataAccess.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AWSAPP.Configuration
{
    public static class RepositoryConfigurationExtensions
    {
        public static IServiceCollection RepositoryRegistration(this IServiceCollection services)
        {
            services.AddTransient<IAcquaintanceRepository, AcquaintanceRepository>();
            return services;
        }
    }
}
