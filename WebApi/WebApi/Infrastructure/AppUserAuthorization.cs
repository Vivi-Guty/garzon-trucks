namespace WebApi.Infrastructure
{
    /// <summary>
    /// Se encarga de denegar todas las peticiones no autenticadas
    /// y las autenticadas cuyo usuario no esté registrado en la base de datos
    /// y las de usuarios registrados que no hayan acceptado el disclaimer.
    /// excepto las que correspondan a paths públicos establecidos en la configuración.
    /// </summary>
    public class AppUserAuthorization
    {

        private readonly RequestDelegate next;
        private readonly HashSet<string> publicPaths;

        public AppUserAuthorization(RequestDelegate next, IConfiguration configuration)
        {
            this.next = next;
            this.publicPaths = new HashSet<string>(configuration.GetSection("PublicPaths").Get<string[]>());
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var user = context.Items["CurrentUser"] as Entities.User;
            if (publicPaths.Contains(context.Request.Path))
            {
                await next(context);
                return;
            }
            if (context.User?.Identity?.IsAuthenticated == false)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.WriteAsync(UnauthorizedModel.Unauthenticated);
                return;
            }
            if (user == null)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.WriteAsync(UnauthorizedModel.NoAppUser);
                return;
            }
            await next(context);
        }
    }
}
