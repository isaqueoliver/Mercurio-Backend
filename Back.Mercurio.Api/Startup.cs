using Back.Mercurio.Api.Configuration;
using Back.Mercurio.Api.Configuration.Identidade;

namespace Back.Mercurio.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentityConfiguration(Configuration);
            services.AddApiConfiguration();
            services.AddSwaggerConfiguration();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            app.UseApiConfiguration(environment);
        }
    }
}
