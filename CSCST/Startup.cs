using CSCST.BussinessLogic;


namespace CSCST
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            IOCConfig.ConfigureServices(ref services);
        }
    }
}
