using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Contexts;
using NewBrandingStyle.Web.Entities;
using NewBrandingStyle.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Services
{
    public interface ICompanyService
    {
        Task<IReadOnlyList<CompanyEntity>> GetAll();
        
        Task<IReadOnlyList<CompanyEntity>> Search(string query);

        Task Add(CompanyModel model);
    }

    public class CompanyService : ICompanyService
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public CompanyService(ApplicationDbContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        public async Task<IReadOnlyList<CompanyEntity>> GetAll()
        {
            var companies = await _context.Companies
                .Where(x => x.UserId == GetUserId() || x.IsPublic)
                .ToListAsync();
            return companies;
        }

        public async Task<IReadOnlyList<CompanyEntity>> Search(string query)
        {
            var sql = $"SELECT * FROM dbo.Companies WHERE Name LIKE '%{query}%' AND (UserId = {GetUserId()} OR IsPublic = 1)";

            return await _context.Companies
                .FromSql(sql)
                .ToListAsync();
        }

        public async Task Add(CompanyModel model)
        {
            var entity = new CompanyEntity
            {
                Name = model.Name,
                Description = model.Description,
                IsVisible = model.IsVisible,
                IsPublic = model.IsPublic,
                UserId = GetUserId()
            };

            _context.Companies.Add(entity);
            await _context.SaveChangesAsync();
        }

        private int GetUserId()
        {
            var userIdClaim = _httpContext.HttpContext.User.FindFirst("id");
            return int.Parse(userIdClaim.Value);
        }
    }
}
