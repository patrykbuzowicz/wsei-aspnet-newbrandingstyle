using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Services;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyService _service;

        public CompanyController(CompanyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var companies = await _service.GetAll();
            return View(companies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CompanyModel model)
        {
            await _service.Add(model);

            return RedirectToAction(nameof(Index));
        }
    }
}