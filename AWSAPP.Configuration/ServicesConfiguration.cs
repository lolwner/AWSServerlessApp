using AWSAPP.Services.Services;
using AWSAPP.Services.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AWSAPP.Configuration
{
    public static class ServicesConfigurationExtensions
    {
        public static IServiceCollection ServiceRegistration(this IServiceCollection services)
        {
            services.AddTransient<IAcquaintanceService, AcquaintanceService>();
            return services;
        }
    }
}
