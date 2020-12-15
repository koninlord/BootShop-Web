using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BootShop_2019.Models;
using BootShop_2019.Models.Services;

namespace BootShop_2019.Controllers
{
    public class HomeController : Controller
    {
        private ProductService _productService;
        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var model = _productService.GetProducts();
            return View(model);
        }
        
    }
}
