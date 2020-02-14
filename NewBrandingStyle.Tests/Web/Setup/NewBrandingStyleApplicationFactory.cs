using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using NewBrandingStyle.Web;

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
