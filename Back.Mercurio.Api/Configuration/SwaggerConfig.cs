using Microsoft.OpenApi.Models;

namespace Back.Mercurio.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Backend do Mercurio",
                    Description = "Api responsável por todas as funcionalidades de Backend do projeto Mercurio. TCC do Centro Universitário Católica do Leste de Minas Gerais.",
                    Contact = new OpenApiContact() { Name = "Isaque de Oliveira, Cinthia Lima Carvalho, Tulio Augusto, Denilson Vieira, Pedro", Email = "isaque.barbosa@a.unileste.edu.br" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            //app.UseSwagger();
            //app.UseSwaggerUI(x =>
            //{
            //    x.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            //});

            return app;
        }
    }
}
