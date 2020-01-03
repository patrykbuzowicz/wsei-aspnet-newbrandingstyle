using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Contexts;
using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Services
{
    public class CompanyService
    {
        private readonly ApplicationDbContext _context;

        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<CompanyEntity>> GetAll()
        {
            var companies = await _context.Companies.ToListAsync();
            return companies;
        }

        public async Task Add(CompanyModel model)
        {
            var entity = new CompanyEntity
            {
                Name = model.Name,
                Description = model.Description,
                IsVisible = model.IsVisible
            };

            _context.Companies.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
