using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/companies")]
    public class CompanyApiController : ControllerBase
    {
        private readonly ICompanyService _service;

        public CompanyApiController(ICompanyService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            var companies = new CompanyModel[]
            {
                new CompanyModel {Name = "Company 1", Description = "Company 1 description"},
                new CompanyModel {Name = "Company 2", Description = "Company 2 description", IsVisible = true},
            };

            return Ok(companies);
        }

        [HttpGet("from-database")]
        public async Task<IActionResult> GetCompaniesFromDatabase()
        {
            var entities = await _service.GetAll();
            var companies = entities.Select(x => new CompanyModel
            {
                Name = x.Name,
                Description = x.Description,
                IsVisible = x.IsVisible
            });

            return Ok(companies);
        }
    }
}
