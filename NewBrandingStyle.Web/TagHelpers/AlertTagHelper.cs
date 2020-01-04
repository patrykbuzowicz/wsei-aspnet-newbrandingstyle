using Microsoft.AspNetCore.Razor.TagHelpers;
using NewBrandingStyle.Web.Services;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.TagHelpers
{
    [HtmlTargetElement("alert")]
    public class AlertTagHelper : TagHelper
    {
        private readonly CompanyService service;

        public AlertTagHelper(CompanyService service)
        {
            this.service = service;
        }

        public string AlertColor { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            // TODO ...
            var companies = (await service.GetAll()).Select(x => x.Name);

            output.TagName = "div";
            output.Attributes.Add("class", "alert alert-" + AlertColor);
            output.Content.Append(string.Join(",", companies));
        }
    }
}
