using Microsoft.AspNetCore.Mvc;

namespace SherEShop.Server.Controllers
{
    public class EntryController:Controller
    {
        //get request here will return all possible options
        //Get request toggles reflection mechanism to get all classes in SherEShop.Server.Controllers namespace
        //and gets all signatures. Combines all this to a json and sends back to user
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult("List of all functions");
        }


        [HttpPost]
        public IActionResult Test()
        {
            return new ObjectResult("Test");
        }
    }
}