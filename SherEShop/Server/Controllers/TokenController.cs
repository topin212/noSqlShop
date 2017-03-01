using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SherEShop.Utilities;

namespace SherEShop.Server.Controllers
{
    public class TokenController : Controller
    {
        private readonly IOperableCollection _users;

        public TokenController(IOperableCollection users)
        {
            _users = users;
        }

        //controller to create tokens
        [HttpPost]
        public IActionResult Index([FromBody] JObject json)
        {
            var email = json["email"].Value<string>();
            Console.WriteLine("Token requested for " + email);

            var user = _users.GetUser(email);

            return new ObjectResult("kke");
        }
    }
}