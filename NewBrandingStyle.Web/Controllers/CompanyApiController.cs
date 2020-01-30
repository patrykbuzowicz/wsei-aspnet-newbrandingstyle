using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [Route("api/companies")]
    public class CompanyApiController : ControllerBase
    {
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
    }
}
