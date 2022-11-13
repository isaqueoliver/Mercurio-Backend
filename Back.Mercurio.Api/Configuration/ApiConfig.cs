using Back.Mercurio.Api.Configuration.Identidade;
using Back.Mercurio.Api.Usuario;
using Back.Mercurio.Infrastructure.IRepository;
using Back.Mercurio.Infrastructure.Repository;
using System.Text.Json.Serialization;

namespace Back.Mercurio.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services)
        {
            services.AddDependencyConfiguration();

            services.AddControllers()
                    .AddJsonOptions(options =>
                        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            services.AddEndpointsApiExplorer();

            services.AddCors(options =>
            {
                options.AddPolicy("Total",
                    builder =>
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
            });

            return services;
        }

        private static IServiceCollection AddDependencyConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IAspNetUser, AspNetUser>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IMercadoRepository, MercadoRepository>();
            services.AddScoped<ICarrinhoRepository, CarrinhoRepository>();
            services.AddScoped<IEstadoRepository, EstadoRepository>();
            services.AddScoped<ICidadeRepository, CidadeRepository>();
            services.AddScoped<IAssuntoRepository, AssuntoRepository>();
            services.AddScoped<IReporteRepository, ReporteRepository>();
            services.AddScoped<IProdutoUsuarioRepository, ProdutoUsuarioRepository>();
            services.AddScoped<IProdutoValorMedioRepository, ProdutoValorMedioRepository>();

            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(x =>
                {
                    x.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Total");

            app.UseAuthConfiguration();

            app.MapControllers();

            return app;
        }
    }
}
