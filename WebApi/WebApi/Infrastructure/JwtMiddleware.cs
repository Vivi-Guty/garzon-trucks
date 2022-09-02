using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApi.Services;

namespace WebApi.Infrastructure
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string secret;

        public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            secret = configuration.GetSection("JWTSecret").Get<string>();
        }

        public async Task Invoke(HttpContext context, IUserService userService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                await AttachUserToContextAsync(context, userService, token);

            await _next(context);
        }

        private async Task AttachUserToContextAsync(HttpContext context, IUserService userService, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

                // attach user to context on successful jwt validation
                context.Items["CurrentUser"] = await userService.GetByIdAsync(userId);
                userService.SetCurrentUserId(userId);

                var identity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim("UserId", userId.ToString(), ClaimValueTypes.Integer32)
                }, "Custom");
                context.User = new ClaimsPrincipal(identity);


            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
                
            }
        }
    }
}
