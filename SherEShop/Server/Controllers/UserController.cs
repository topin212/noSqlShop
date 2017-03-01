using Microsoft.AspNetCore.Mvc;
using SherEShop.Utilities;

namespace SherEShop.Server.Controllers
{
    public class UserController
    {
        private readonly IOperableCollection _users;

        public UserController(IOperableCollection users)
        {
            _users = users;
        }

        public IActionResult Index()
        {
            return new JsonResult(_users.GetAllUsers());
        }
    }
}