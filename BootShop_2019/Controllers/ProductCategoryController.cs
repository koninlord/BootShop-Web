using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootShop_2019.Models.Services;
using BootShop_2019.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootProductCategory_2019.Controllers
{
    public class ProductCategoryController : Controller
    {
        private ProductCategoryService _productCategoryService;

        public ProductCategoryController(ProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        // GET: ProductCategory
        public ActionResult Index()
        {
            var model = _productCategoryService.GetProductCategories();
            return View(model);
        }

        // GET: ProductCategory/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var model = _productCategoryService.GetProductCategoryDetails(id);
                return View(model);
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // GET: ProductCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCategory/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategoryViewModel model)
        {
            try
            {

                bool result = _productCategoryService.AddProductCategory(model);

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

        // GET: ProductCategory/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var model = _productCategoryService.GetProductCategoryDetails(id);
                return View(model);
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ProductCategory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductCategoryViewModel model)
        {
            try
            {
                bool result = _productCategoryService.UpdateProductCategory(model);

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

        // GET: ProductCategory/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var model = _productCategoryService.GetProductCategoryDetails(id);
                return View(model);
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // POST: ProductCategory/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ProductCategoryViewModel model)
        {
            try
            {
                bool result = _productCategoryService.DeleteProductCategory(id);

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