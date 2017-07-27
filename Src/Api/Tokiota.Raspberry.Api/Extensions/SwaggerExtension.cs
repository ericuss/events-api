namespace Tokiota.Raspberry.Api.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Swashbuckle.AspNetCore.Swagger;

    public static class SwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Tokiota raspberry API", Version = "v1" });
            });

        }

        public static void UseSwaggerAndUI(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tokiota raspberry API");
            });

        }
    }
}
