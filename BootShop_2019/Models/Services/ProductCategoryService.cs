using BootShop_2019.Models.Data.BootShopContext;
using BootShop_2019.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.Services
{
    public class ProductCategoryService
    {
        private BootShopContext _context;
        public ProductCategoryService(BootShopContext context)
        {
            _context = context;
        }

        public List<ProductCategoryViewModel> GetProductCategories()
        {
            try
            {
                List<ProductCategory> categories = _context.ProductCategory.ToList();

                List<ProductCategoryViewModel> viewModel = categories.Select(x => new ProductCategoryViewModel
                {
                    Id = x.ProductCategoryId,
                    ProductCategoryName = x.ProductCategoryName,
                }).ToList();

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProductCategoryViewModel GetProductCategoryDetails(int id)
        {
            try
            {
                ProductCategory category = _context.ProductCategory.Where(x => x.ProductCategoryId == id).FirstOrDefault();

                ProductCategoryViewModel viewModel = new ProductCategoryViewModel
                {
                    Id = category.ProductCategoryId,
                    ProductCategoryName = category.ProductCategoryName,
                };

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddProductCategory(ProductCategoryViewModel model)
        {
            try
            {
                ProductCategory category = new ProductCategory
                {                    
                    ProductCategoryName = model.ProductCategoryName,
                };

                _context.ProductCategory.Add(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateProductCategory(ProductCategoryViewModel model)
        {
            try
            {
                ProductCategory category = _context.ProductCategory.Where(x => x.ProductCategoryId == model.Id).FirstOrDefault();

                category.ProductCategoryName = model.ProductCategoryName;

                _context.ProductCategory.Update(category);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteProductCategory(int id)
        {
            try
            {
                ProductCategory category = _context.ProductCategory.Where(x => x.ProductCategoryId == id).FirstOrDefault();

                _context.ProductCategory.Remove(category);
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
