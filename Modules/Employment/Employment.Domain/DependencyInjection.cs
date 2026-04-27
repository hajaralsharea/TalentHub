using Employment.Domain.IServices;
using Employment.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Employment.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddScoped<ICompanyService, CompanyService>();
        }
    }
}
