using WebApi.Entities;

namespace WebApi.Models
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
        public OkResultModel Result { get; set; }

        public AuthenticateResponse(User? user, string token, OkResultModel result)
        {
            Id = user != null ? user.UserId : 0;
            UserName = user != null ? user.UserName : string.Empty;            
            Token = token;
            Result = result;
        }
    }
}
