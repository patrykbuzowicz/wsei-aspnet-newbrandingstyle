using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(CompanyModel model)
        {
            var result = new CompanyAddedViewModel
            {
                NumberOfCharsInName = model.Name.Length,
                NumberOfCharsInDescription = model.Description.Length,
                IsHidden = !model.IsVisible
            };

            return View("CompanyAddedConfirmation", result);
        }
    }
}