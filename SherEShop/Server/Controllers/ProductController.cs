using System;
using Microsoft.AspNetCore.Mvc;
using SherEShop.Utilities;

namespace SherEShop.Server.Controllers
{
    public class ProductController:Controller
    {
        private readonly IOperableCollection _storage;

        public ProductController(IOperableCollection storage)
        {
            _storage = storage;
        }

        public IActionResult Index()
        {
            return new JsonResult(_storage.GetAllProducts());
        }
    }
}