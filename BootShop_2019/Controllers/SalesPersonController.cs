using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootSalePerson_2019.Models.Services;
using BootShop_2019.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BootShop_2019.Controllers
{
    public class SalePersonController : Controller
    {
        private SalePersonService _salesPersonService;
        public SalePersonController(SalePersonService salesPersonService)
        {
            _salesPersonService = salesPersonService;
        }

        // GET: SalePerson
        public ActionResult Index()
        {
            var model = _salesPersonService.GetTeam();
            return View(model);
        }

        // GET: SalePerson/Details/5
        public ActionResult Details(int id)
        {
            var model = _salesPersonService.GetSalePersonDetails(id);
            return View(model);
        }

        // GET: SalePerson/Create
        public ActionResult Create()
        {
            var model = _salesPersonService.Create();
            return View(model);
        }

        // POST: SalePerson/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SalePersonViewModel model)
        {
            try
            {

                bool result = _salesPersonService.AddSalePerson(model);

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

        // GET: SalePerson/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                var model = _salesPersonService.GetSalePersonDetails(id);
                return View(model);
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // POST: SalePerson/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SalePersonViewModel model)
        {
            try
            {
                bool result = _salesPersonService.UpdateSalePerson(model);

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

        // GET: SalePerson/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var model = _salesPersonService.GetSalePersonDetails(id);
                return View(model);
            }
            catch
            {

                return RedirectToAction(nameof(Index));
            }
        }

        // POST: SalePerson/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SalePersonViewModel model)
        {
            try
            {
                bool result = _salesPersonService.DeleteSalePerson(id);

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