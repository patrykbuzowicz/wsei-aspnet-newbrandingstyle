using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.ViewComponents
{
    public class CompaniesList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int max)
        {
            // TODO ...
            var companies = Enumerable.Range(1, 20)
                .Take(max)
                .Select(x => $"company-{x}");
            return View("Default", companies);
        }
    }
}
