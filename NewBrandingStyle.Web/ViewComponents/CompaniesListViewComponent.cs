using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.ViewComponents
{
    public class CompaniesList : ViewComponent
    {
        private readonly CompanyService _service;

        public CompaniesList(CompanyService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(int max = 10)
        {
            // TODO ...
            return View("Empty");
        }
    }
}
