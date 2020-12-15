using BootSalePerson_2019.Models.Services;
using BootShop_2019.Models.Data.BootShopContext;
using BootShop_2019.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.Services
{
    public class ProductSaleService
    {
        private BootShopContext _context;
        private SalePersonService _salePersonService;
        public ProductSaleService(BootShopContext context, SalePersonService salePersonService)
        {
            _context = context;
            _salePersonService = salePersonService;
        }

        public List<ProductSaleViewModel> GetProductSales()
        {
            try
            {
                List<ProductSale> productSale = _context.ProductSale
                                                .Include(x => x.Product)
                                                .ThenInclude(x => x.ProductImage)
                                                .Include(x => x.SalePerson)
                                                .ToList();

                List<ProductSaleViewModel> viewModel = productSale.Select(x => new ProductSaleViewModel
                {
                    Id = x.ProductId,
                    SalePersonId = x.SalePersonId,
                    Picture = x.Product?.ProductImage.Image,
                    ProductName = x.Product.ProductName,
                    SalePersonName = $"{x.SalePerson.Surname} {x.SalePerson.OtherName}",
                    TimeSold = x.DateTimeSold
                }).ToList();

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductSaleViewModel Create(int productId)
        {
            ProductSaleViewModel model = new ProductSaleViewModel();
            model.Picture = _context.Product.Where(x => x.ProductId == productId).Include(x => x.ProductImage)?.FirstOrDefault()?.ProductImage?.Image;
            model.Id = productId;
            model.SalePersonList = new SelectList(_salePersonService.GetTeam(), "Id", "FullName");
            return model;
        }

        public bool AddProductSale(ProductSaleViewModel model)
        {
            try
            {               
                ProductSale productSale = new ProductSale
                {
                    ProductId = model.Id,
                    SalePersonId = model.SalePersonId
                };

                _context.ProductSale.Add(productSale);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        

        public bool DeleteProductSale(int id)
        {
            try
            {
                ProductSale productSale = _context.ProductSale.Where(x => x.ProductId == id).FirstOrDefault();

                _context.ProductSale.Remove(productSale);
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
