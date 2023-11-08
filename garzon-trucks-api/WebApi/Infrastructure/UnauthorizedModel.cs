using Microsoft.AspNetCore.Mvc;

namespace WebApi.Infrastructure
{
    public class UnauthorizedModel
    {
        public static readonly ProblemDetails Unauthenticated = new ProblemDetails
        {
            Status = StatusCodes.Status401Unauthorized,
            Title = "Unauthorized",
            Detail = "You need to log on to access this page"
        };

        public static readonly ProblemDetails NoAppUser = new ProblemDetails
        {
            Status = StatusCodes.Status403Forbidden,
            Title = "NoAppUser",
            Detail = "You don't have access to the application. Please, request access to administrator"
        };

        public static readonly ProblemDetails AccessDenied = new ProblemDetails
        {
            Status = StatusCodes.Status403Forbidden,
            Title = "AccessDenied",
            Detail = "You don't have permission to execute the requested action. Please, request permission to administrator"
        };
    }
}
