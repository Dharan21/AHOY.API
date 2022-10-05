using Microsoft.Extensions.DependencyInjection;

namespace AHOY.BusinessLogic
{
    public class IocConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            DataAccess.IocConfig.ConfigureServices(ref services);
        }
    }
}