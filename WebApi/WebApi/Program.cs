using inercya.EntityLite.SqliteProfiler;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NLog;
using NLog.Web;
using System.Configuration;
using System.Text.Json.Serialization;
using WebApi.Entities;
using WebApi.Infrastructure;
using WebApi.Services;


var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{
    JsonConvert.DefaultSettings = () => new JsonSerializerSettings
    {
        Formatting = Formatting.Indented,
        DateTimeZoneHandling = DateTimeZoneHandling.Utc,
        NullValueHandling = NullValueHandling.Ignore,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy()
        }
    };


    var builder = WebApplication.CreateBuilder(args);

    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();

    // Add services to the container.
    builder.Services.AddEntityServices();
    builder.Services.AddControllers();

    // configure DI for application services
    builder.Services.AddScoped<IUserService, UserService>();

    var corsOptions = builder.Configuration.GetSection(nameof(CorsOptions)).Get<CorsOptions>();
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy",
        builder =>
        {
            builder.AllowAnyMethod().AllowAnyHeader().SetPreflightMaxAge(TimeSpan.FromDays(1));
            if (corsOptions.AllowedOrigins != null && corsOptions.AllowedOrigins.Length > 0)
            {
                builder.WithOrigins(corsOptions.AllowedOrigins).AllowCredentials();
            }
            else
            {
                builder.AllowAnyOrigin();
            }
        });
    });
    builder.Services.AddMvc().AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.Formatting = Formatting.Indented;
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
    });

    var app = builder.Build();

    //app.MapGet("/", () => "Hello World!");

    // custom jwt auth middleware
    app.UseMiddleware<JwtMiddleware>();

    

    app.UseCustomExceptionHandling();

    
    app.UseAuthentication();
    //app.Map("/api", x => x.UseMiddleware<AppUserAuthorization>());
    app.UseMiddleware<AppUserAuthorization>();
    app.UseRouting();
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

    // Configure the HTTP request pipeline.
    app.UseHttpsRedirection();
    //app.MapControllers();
    app.Run();

}
catch (Exception exception)
{
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}