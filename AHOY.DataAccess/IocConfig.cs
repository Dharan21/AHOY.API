using AHOY.DataAccess.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AHOY.DataAccess
{
    public class IocConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            Infrastructure.IocConfig.ConfigureServices(ref services);
            services.AddTransient<IHotelRepositoty, HotelRepositoty>();
            services.AddTransient<IFacilityRepository, FacilityRepository>();
        }
    }
}