using BootShop_2019.Models.Data.BootShopContext;
using BootShop_2019.Models.Services;
using BootShop_2019.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootSalePerson_2019.Models.Services
{
    public class SalePersonService
    {
        private BootShopContext _context;
        private ShopService _shopService;
        public SalePersonService(BootShopContext context, ShopService shopService)
        {
            _context = context;
            _shopService = shopService;
        }

        public List<SalePersonViewModel> GetTeam()
        {
            try
            {
                List<SalePerson> team = _context.SalePerson.Include(x=>x.Shop).ToList();

                List<SalePersonViewModel> viewModel = team.Select(x => new SalePersonViewModel
                {
                    Id = x.SalePersonId,
                    Surname = x.Surname,
                    Othername = x.OtherName,
                    FullName = $"{x.Surname} {x.OtherName}",
                    Gender = Convert.ToChar(x.Gender),
                    ShopId = x.ShopId,
                    ShopName = x.Shop.ShopName
                }).ToList();

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        public SalePersonViewModel GetSalePersonDetails(int id)
        {
            try
            {
                SalePerson salesPerson = _context.SalePerson.Where(x => x.SalePersonId == id).Include(x=>x.Shop).FirstOrDefault();

                SalePersonViewModel viewModel = new SalePersonViewModel
                {
                    Id = salesPerson.SalePersonId,
                    Surname = salesPerson.Surname,
                    Othername = salesPerson.OtherName,
                    Gender = Convert.ToChar(salesPerson.Gender),
                    ShopId = salesPerson.ShopId,
                    ShopName = salesPerson.Shop.ShopName,
                    ShopList = new SelectList(_shopService.GetShops(), "Id", "ShopName", salesPerson.ShopId)
                };

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SalePersonViewModel Create()
        {
            SalePersonViewModel model = new SalePersonViewModel();
            model.ShopList = new SelectList(_shopService.GetShops(), "Id", "ShopName");
            return model;
        }

        public bool AddSalePerson(SalePersonViewModel model)
        {
            try
            {
                SalePerson salesPerson = new SalePerson
                {
                    Surname = model.Surname,
                    OtherName = model.Othername,
                    Gender = model.Gender.ToString(),
                    ShopId = model.ShopId
                };

                _context.SalePerson.Add(salesPerson);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSalePerson(SalePersonViewModel model)
        {
            try
            {
                SalePerson salesPerson = _context.SalePerson.Where(x => x.SalePersonId == model.Id).FirstOrDefault();

                salesPerson.Surname = model.Surname;
                salesPerson.OtherName = model.Othername;
                salesPerson.Gender = model.Gender.ToString();
                salesPerson.ShopId = model.ShopId;

                _context.SalePerson.Update(salesPerson);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSalePerson(int id)
        {
            try
            {
                SalePerson salesPerson = _context.SalePerson.Where(x => x.SalePersonId == id).FirstOrDefault();

                _context.SalePerson.Remove(salesPerson);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
