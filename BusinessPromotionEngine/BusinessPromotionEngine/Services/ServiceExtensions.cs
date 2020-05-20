using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swashbuckle.AspNetCore.Swagger;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessPromotionEngine.Services
{
    [ExcludeFromCodeCoverage]
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                                    builder => builder.AllowAnyOrigin()
                                                          .AllowAnyMethod()
                                                          .AllowAnyHeader()
                                                          .AllowCredentials());
            });
        }

        // Register the Swagger generator, defining one or more Swagger documents
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new Info { Title = "Business Promotion Engine Service", Version = "v1" }); });
        }
    }
}
