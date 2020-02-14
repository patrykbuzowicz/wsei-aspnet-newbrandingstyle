using NewBrandingStyle.Web.Services;

namespace NewBrandingStyle.Web.Models
{
    public class AuthResult
    {
        private AuthResult()
        {
        }

        public AuthResult(UserData user)
        {
            Succeeded = true;
            Id = user.Id;
            Username = user.Username;
        }

        public bool Succeeded { get; private set; }
        
        public int Id { get; }
        
        public string Username { get; }

        public static AuthResult Failed() => new AuthResult { Succeeded = false };
    }
}