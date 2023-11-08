using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApi.Entities;

namespace WebApi.Infrastructure
{
    public class ExceptionHandlerMiddleware
    {
        ILogger logger;
        RequestDelegate next;
        IHostEnvironment env;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IHostEnvironment env)
        {
            this.logger = loggerFactory.CreateLogger<ExceptionHandlerMiddleware>();
            this.next = next;
            this.env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            var errorFeature = context.Features.Get<IExceptionHandlerFeature>();
            var error = errorFeature?.Error;

            var authorizationException = error as AuthorizationException;
            var jwtException = error as SecurityTokenException;
            //var errorDetail = error.Demystify();

            ProblemDetails problemDetails;

            if (jwtException != null)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                problemDetails = UnauthorizedModel.Unauthenticated;
                logger.LogWarning(error, "Unauthenticated request, {TraceIdentifier}", context.TraceIdentifier);
            }

            else if (authorizationException == null)
            {
                logger.LogError(error, "Unhandled Exception, {TraceIdentifier}", context.TraceIdentifier);
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                if (this.env.IsDevelopment() || this.env.IsEnvironment("WithAuthentication"))
                {
                    problemDetails = new ProblemDetails
                    {
                        Status = StatusCodes.Status500InternalServerError,
                        Title = error?.Message + $". Error identifier {context.TraceIdentifier}",
                        Detail = error?.ToString()
                    };
                }
                else
                {
                    problemDetails = new ProblemDetails
                    {
                        Status = StatusCodes.Status500InternalServerError,
                        Title = "Internal server error",
                        Detail = $"Identificador del error {context.TraceIdentifier}."
                    };
                }
            }
            else
            {
                if (authorizationException.Reason == UnauthorizedReason.Unautenticated)
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    problemDetails = UnauthorizedModel.Unauthenticated;
                    logger.LogWarning(error, "Unauthenticated request, {TraceIdentifier}", context.TraceIdentifier);
                }
                else if (authorizationException.Reason == UnauthorizedReason.NoAppUser)
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    logger.LogWarning(error, "No App User request, {TraceIdentifier}", context.TraceIdentifier);
                    problemDetails = UnauthorizedModel.NoAppUser;
                }
                else
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    logger.LogWarning(error, "Access Denied request, {TraceIdentifier}", context.TraceIdentifier);
                    problemDetails = UnauthorizedModel.AccessDenied;
                }
            }
            await context.WriteAsync(problemDetails);
        }
    }
}
