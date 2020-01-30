using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewBrandingStyle.Tests.Web.Setup
{
    public class MockCompanyService : ICompanyService
    {
        public Task Add(CompanyModel model)
        {
            return Task.CompletedTask;
        }

        public Task<IReadOnlyList<CompanyEntity>> GetAll()
        {
            var companies = new List<CompanyEntity>
            {
                new CompanyEntity
                {
                    Id = 1,
                    Name = "company 1",
                    Description = "company 1 desciption",
                    IsVisible = true
                },
                new CompanyEntity
                {
                    Id = 2,
                    Name = "company 2",
                    Description = "company 2 desciption",
                    IsVisible = true
                },
            };

            return Task.FromResult((IReadOnlyList<CompanyEntity>)companies);
        }
    }
}