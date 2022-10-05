using AHOY.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AHOY.Infrastructure
{
    public class IocConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            services.AddScoped<IUow, Uow>();
        }
    }
}