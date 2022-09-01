using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Entities
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEntityServices(this IServiceCollection services)
        {
            return services.AddSingleton(provider =>
            {
                var configuration = provider.GetRequiredService<IConfiguration>();
                var connectionString = configuration.GetConnectionString("Insurances");
                return new DataServiceFactory(connectionString);
            })
            .AddScoped(provider =>
            {
                var factory = provider.GetRequiredService<DataServiceFactory>();
                return factory.CreateDataService();
            })
            .AddScoped<UserPasswordService>();
        }
    }
}
