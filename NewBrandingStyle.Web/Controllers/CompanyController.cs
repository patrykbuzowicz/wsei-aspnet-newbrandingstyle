using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Services;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    [Authorize(Policy = "authenticated")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _service;

        public CompanyController(ICompanyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] string q)
        {
            var companies = string.IsNullOrEmpty(q)
                ? await _service.GetAll()
                : await _service.Search(q);

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