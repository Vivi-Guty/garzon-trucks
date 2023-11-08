using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Options;
using System.Text;

namespace WebApi.Infrastructure
{
    public static class Extensions
    {

        public static void MapTest(this IApplicationBuilder app, IConfiguration configuration)
        {

            string testPath = configuration["TestPath"] ?? "/test";
            app.Map(testPath, b =>
            {
                b.Run(async context =>
                {
                    if (context.Request.Query.ContainsKey("error"))
                    {
                        throw new Exception("Ha ocurrido un error muy chungo y esto va a explotar");
                    }
                    string? ip = null;
                    var remoteIpAddress = context.Connection.RemoteIpAddress;
                    if (remoteIpAddress.IsIPv4MappedToIPv6)
                    {
                        ip = remoteIpAddress.MapToIPv4().MapToIPv4().ToString();
                    }
                    else
                    {
                        ip = remoteIpAddress.ToString();
                    }
                    context.Response.ContentType = "text/plain";
                    await context.Response.WriteAsync($"User: {context.User.Identity.Name}\n");
                    await context.Response.WriteAsync($"IP: {ip}\n");
                    foreach (var header in context.Request.Headers)
                    {
                        await context.Response.WriteAsync($"{header.Key}:{string.Join(';', header.Value)}\n");
                    }

                });
            });
        }

        public static void UseCustomExceptionHandling(this IApplicationBuilder app)
        {
            app.UseExceptionHandler((appBuilder) => appBuilder.UseMiddleware<ExceptionHandlerMiddleware>());
        }

        public static async Task WriteAsync(this HttpContext context, ProblemDetails p)
        {
            context.Response.StatusCode = p.Status.Value;
            context.Response.ContentType = "application/json";
            await context.WriteModelAsync(p);
        }


        private static readonly RouteData EmptyRouteData = new RouteData();

        private static readonly ActionDescriptor EmptyActionDescriptor = new ActionDescriptor();

        public static Task WriteModelAsync<TModel>(this HttpContext context, TModel model)
        {
            var result = new ObjectResult(model)
            {
                DeclaredType = typeof(TModel)
            };

            return context.ExecuteResultAsync(result);
        }

        public static Task ExecuteResultAsync<TResult>(this HttpContext context, TResult result)
            where TResult : IActionResult
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            if (result == null) throw new ArgumentNullException(nameof(result));

            var executor = context.RequestServices.GetRequiredService<IActionResultExecutor<TResult>>();

            var routeData = context.GetRouteData() ?? EmptyRouteData;
            var actionContext = new ActionContext(context, routeData, EmptyActionDescriptor);

            return executor.ExecuteAsync(actionContext, result);
        }

        public static AuthenticationTicket DecryptAuthTicket(this HttpContext httpContext)
        {
            // ONE - grab the CookieAuthenticationOptions instance
            var opt = httpContext.RequestServices
                .GetRequiredService<IOptionsMonitor<CookieAuthenticationOptions>>()
                .Get(CookieAuthenticationDefaults.AuthenticationScheme); //or use .Get("Cookies")

            // TWO - Get the encrypted cookie value
            var cookie = opt.CookieManager.GetRequestCookie(httpContext, opt.Cookie.Name);

            // THREE - decrypt it
            return opt.TicketDataFormat.Unprotect(cookie);
        }

        public static string DecruptAuthCookie(this HttpContext httpContext)
        {
            // ONE - grab the CookieAuthenticationOptions instance
            var opt = httpContext.RequestServices
                .GetRequiredService<IOptionsMonitor<CookieAuthenticationOptions>>()
                .Get(CookieAuthenticationDefaults.AuthenticationScheme); //or use .Get("Cookies")

            // TWO - Get the encrypted cookie value
            var cookie = opt.CookieManager.GetRequestCookie(httpContext, opt.Cookie.Name);

            var protectorProvider = httpContext.RequestServices.GetService<IDataProtectionProvider>();
            var protector = protectorProvider.CreateProtector(new string[] { "Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationMiddleware", "Cookies", "v2" });
            // THREE - decrypt it

            UTF8Encoding specialUtf8Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: true, throwOnInvalidBytes: true);
            byte[] protectedBytes = Base64UrlTextEncoder.Decode(cookie);
            byte[] plainBytes = protector.Unprotect(protectedBytes);
            string plainText = specialUtf8Encoding.GetString(plainBytes);
            return plainText;

        }
    }
}
