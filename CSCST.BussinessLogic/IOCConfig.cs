using CSCST.BussinessLogic.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CSCST.BussinessLogic
{
    public static class IOCConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            services.AddTransient<ICustomerManager, CustomerManager>();
            DataAccess.IOCConfig.ConfigureServices(ref services);
        }
    }
}
