using Microsoft.AspNetCore.Mvc;

namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}