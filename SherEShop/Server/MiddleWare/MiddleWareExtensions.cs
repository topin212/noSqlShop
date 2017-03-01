using Microsoft.AspNetCore.Builder;

namespace SherEShop.Server.MiddleWare
{
    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder UseAuthorization(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizationMiddleWare>();
        }
    }
}