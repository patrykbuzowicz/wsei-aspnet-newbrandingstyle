using System.ComponentModel.DataAnnotations;

namespace NewBrandingStyle.Web.Models
{
    public class LoginRequest
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
