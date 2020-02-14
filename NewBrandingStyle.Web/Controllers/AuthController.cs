using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Services;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authentication;

        public AuthController(AuthService authentication)
        {
            _authentication = authentication;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginRequest request, [FromQuery] string returnUrl)
        {
            var authResult = _authentication.Authenticate(request.Username, request.Password);

            if (!authResult.Succeeded)
            {
                ViewBag.Failed = true;
                return View();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, authResult.Username),
                new Claim("id", authResult.Id.ToString()),
            };

            var claimsIdentity = new ClaimsIdentity(claims, "custom");

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            
            return Redirect(returnUrl);
        }
    }
}
