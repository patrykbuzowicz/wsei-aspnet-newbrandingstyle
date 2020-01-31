using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Middlewares
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {            
            await _next(context);
        }
    }
}
