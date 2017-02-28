using Microsoft.AspNetCore.Mvc;

namespace SherEShop.Server.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return new ObjectResult("Categories will be displayed here");
        }
    }
}