using Microsoft.AspNetCore.Mvc;
using SherEShop.Utilities;

namespace SherEShop.Server.Controllers
{
    public class OrderController : Controller
    {
        private IOperableCollection _storage;

        public OrderController(IOperableCollection storage)
        {
            _storage = storage;
        }

        public IActionResult Index()
        {
            return new ObjectResult("not yet implemented");
        }
    }
}