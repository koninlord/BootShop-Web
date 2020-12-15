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
    public class ShopController : Controller
    {
        private ShopService _shopService;

        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }

        // GET: Shop
        public ActionResult Index()
        {
            var model = _shopService.GetShops();
            return View(model);
        }

        // GET: Shop/Details/5
        public ActionResult Details(int id)
        {                       
            try
            {
                var model = _shopService.GetShopDetails(id);
                return View(model);
            }
            catch
            {
                
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Shop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Shop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopViewModel model)
        {
            try
            {
                
                bool result = _shopService.AddShop(model);

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

        // GET: Shop/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var model = _shopService.GetShopDetails(id);
                return View(model);
            }
            catch
            {
                
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Shop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ShopViewModel model)
        {
            try
            {
                bool result = _shopService.UpdateShop(model);

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

        // GET: Shop/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var model = _shopService.GetShopDetails(id);
                return View(model);
            }
            catch
            {
                
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Shop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ShopViewModel model)
        {
            try
            {
                bool result = _shopService.DeleteShop(id);

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