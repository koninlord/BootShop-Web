using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootShop_2019.Models.Services;
using BootShop_2019.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootShop_2019.Controllers
{
    public class ProductSaleController : Controller
    {
        private ProductSaleService _productSaleService;
        public ProductSaleController(ProductSaleService productSaleService)
        {
            _productSaleService = productSaleService;
        }
        // GET: ProductSale
        public ActionResult Index()
        {
            var model = _productSaleService.GetProductSales();
            return View(model);
        }

        // GET: ProductSale/Create
        public ActionResult Create(int id)
        {
            var model = _productSaleService.Create(id);
            return View(model);
        }

        // POST: ProductSale/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductSaleViewModel model)
        {
            try
            {

                bool result = _productSaleService.AddProductSale(model);

                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                throw new Exception();

            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Ooops! Something went wrong!");
                return View();
            }
        }

        // GET: ProductSale/Delete/5
        public ActionResult Delete(int id)
        {            
            return View(new ProductSaleViewModel { Id = id});
        }

        // POST: ProductSale/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductSaleViewModel model)
        {
            try
            {
                bool result = _productSaleService.DeleteProductSale(id);

                if (result)
                {
                    return RedirectToAction(nameof(Index));
                }
                throw new Exception();
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "Ooops! Something went wrong!");
                return View();
            }
        }
    }
}