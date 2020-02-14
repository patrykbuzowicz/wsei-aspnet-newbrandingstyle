using NewBrandingStyle.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace NewBrandingStyle.Web.Services
{
    public class AuthService
    {
        private static readonly List<UserData> Users = new List<UserData>
        {
            new UserData {Id = 1, Username = "john.doe", Password = "happy123"},
            new UserData {Id = 2, Username = "robert.x", Password = "happier1"},
        };

        public AuthResult Authenticate(string username, string password)
        {
            var user = Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user == null)
                return AuthResult.Failed();

            return new AuthResult(user);
        }
    }
}
