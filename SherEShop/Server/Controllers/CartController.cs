using Microsoft.AspNetCore.Mvc;
using SherEShop.Utilities;

namespace SherEShop.Server.Controllers
{
    public class CartController : Controller
    {
        private IOperableCollection _storage;

        public CartController(IOperableCollection storage)
        {
            _storage = storage;
        }

        //TODO: import data
        public IActionResult Index()
        {
            return new ObjectResult("CartController");
        }
    }
}