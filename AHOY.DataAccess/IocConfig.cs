using Microsoft.Extensions.DependencyInjection;

namespace AHOY.DataAccess
{
    public class IocConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            Infrastructure.IocConfig.ConfigureServices(ref services);
        }
    }
}