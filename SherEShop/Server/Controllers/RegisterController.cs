using System;
using Microsoft.AspNetCore.Mvc;
using SherEShop.Server.Common;
using SherEShop.Utilities;

namespace SherEShop.Server.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IOperableCollection _storage;

        public RegisterController(IOperableCollection storage)
        {
            _storage = storage;
        }

        [HttpPost]
        public IActionResult Index([FromBody] User user)
        {
            //TODO: validate user
            if(user.Email == null)
                throw new Exception("User email cannot be empty");
            user.Password = user.Password.ToMD5();
            _storage.AddUser(user);

            return new ObjectResult("Done");
        }
    }
}