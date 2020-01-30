using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NewBrandingStyle.Web;
using NewBrandingStyle.Web.Services;

namespace NewBrandingStyle.Tests.Web.Setup
{
    public class NewBrandingStyleApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                // TODO replace real registrations
            });
        }
    }
}
