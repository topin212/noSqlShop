using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SherEShop.Utilities;

namespace SherEShop.Server.MiddleWare
{
    public class AuthorizationMiddleWare
    {
        private readonly RequestDelegate _next;

        public AuthorizationMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        //TODO: come up with a better solution here
        public Task Invoke(HttpContext context)
        {
            if (context.Request.Path.ToString() == "/api/Register" ||
                context.Request.Path.ToString() == "/api/Token" ||
                context.Request.Path.ToString() == "/api/User")
                return _next(context);

            //Then we are not registering.. And we need to grab the header
            var requestHeader = context.Request.Headers["Authorization"].ToString();

            //check if auth is not empty
            if (requestHeader == string.Empty)
                return context.Response.WriteAsync("You are not authorized. Go to /api/Token to get token");

            //get the user
            var userid = requestHeader.base64Decode();
            context.Items.Add("user", userid);

            return _next(context);
        }
    }
}