using Microsoft.AspNetCore.Mvc.Testing;
using NewBrandingStyle.Web;
using NUnit.Framework;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewBrandingStyle.Tests.Web
{
    public class CompaniesTests
    {
        private HttpClient _client;

        [SetUp]
        public void CreateServer()
        {
            var factory = new WebApplicationFactory<Startup>();
            _client = factory.CreateClient();
        }

        [Test]
        public async Task Given_RequestForAllCompanies_Expect_OkResponse()
        {
            // TODO implement...
        }

        [Test]
        public async Task Given_RequestForAllCompanies_Expect_TwoCompaniesAreReturned()
        {
            // TODO implement...
        }
    }
}
