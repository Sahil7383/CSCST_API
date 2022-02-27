using DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class IOCConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();

        }
    }
}
