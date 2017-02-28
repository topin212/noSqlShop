using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;

namespace SherEShop.MiddleWare
{
    public class TestMiddleWare
    {
        private readonly RequestDelegate _next;

        public TestMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context).ConfigureAwait(false);
        }

    }

    public static class TestMiddleWareExtensions
    {
        public static IApplicationBuilder UseTestMiddleWare(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TestMiddleWare>();
        }
    }
}