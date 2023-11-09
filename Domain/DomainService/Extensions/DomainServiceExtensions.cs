using DomainService.Abstrack;
using DomainService.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DomainService.Extensions
{
    public static class DomainServiceExtensions
    {
        public static IServiceCollection LoadDomainServiceExtension(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}
