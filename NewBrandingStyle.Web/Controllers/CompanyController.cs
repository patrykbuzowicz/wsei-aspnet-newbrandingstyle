using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Contexts;
using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext context;

        public CompanyController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var companies = await context.Companies.ToListAsync();
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
            var entity = new CompanyEntity { 
                Name = model.Name,
                Description = model.Description,
                IsVisible = model.IsVisible
            };

            context.Companies.Add(entity);
            await context.SaveChangesAsync();

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