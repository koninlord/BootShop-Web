using BootShop_2019.Models.Data.BootShopContext;
using BootShop_2019.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.Services
{
    public class ShopService
    {
        private BootShopContext _context;
        public ShopService(BootShopContext context)
        {
            _context = context;
        }

        public List<ShopViewModel> GetShops()
        {
            try
            {
                List<Shop> shops = _context.Shop.ToList();

                List<ShopViewModel> viewModel = shops.Select(x => new ShopViewModel
                {
                    Id = x.ShopId,
                    ShopName = x.ShopName,
                    ShopLocation = x.ShopLocation
                }).ToList();

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ShopViewModel GetShopDetails(int id)
        {
            try
            {
                Shop shop = _context.Shop.Where(x=>x.ShopId == id).FirstOrDefault();

                ShopViewModel viewModel = new ShopViewModel
                {
                    Id = shop.ShopId,
                    ShopName = shop.ShopName,
                    ShopLocation = shop.ShopLocation
                };

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddShop(ShopViewModel model)
        {
            try
            {
                Shop shop = new Shop
                {
                    ShopName = model.ShopName,
                    ShopLocation = model.ShopLocation
                };

                _context.Shop.Add(shop);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateShop(ShopViewModel model)
        {
            try
            {
                Shop shop = _context.Shop.Where(x => x.ShopId == model.Id).FirstOrDefault();

                shop.ShopName = model.ShopName;
                shop.ShopLocation = model.ShopLocation;

                _context.Shop.Update(shop);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteShop(int id)
        {
            try
            {
                Shop shop = _context.Shop.Where(x => x.ShopId == id).FirstOrDefault();
                
                _context.Shop.Remove(shop);
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
