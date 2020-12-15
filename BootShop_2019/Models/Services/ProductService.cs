using BootShop_2019.Models.Data.BootShopContext;
using BootShop_2019.Models.Services;
using BootShop_2019.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.Services
{
    public class ProductService
    {
        private BootShopContext _context;
        private ShopService _shopService;
        private ProductCategoryService _productCategoryService;
        public ProductService(BootShopContext context, ShopService shopService, ProductCategoryService productCategoryService)
        {
            _context = context;
            _shopService = shopService;
            _productCategoryService = productCategoryService;
        }

        public List<ProductViewModel> GetProducts()
        {
            try
            {
                List<Product> product = _context.Product
                                                .Include(x => x.Shop)
                                                .Include(x=>x.ProductCategory)
                                                .Include(x=>x.ProductImage)
                                                .ToList();

                List<ProductViewModel> viewModel = product.Select(x => new ProductViewModel
                {
                    Id = x.ProductId,
                    ProductName = x.ProductName,
                    Price = x.Price,
                    SerialNumber = x.SerialNumber,
                    ProductCategoryID = x.ProductCategoryId,
                    ShopID = x.ShopId,
                    ProductCategoryName = x.ProductCategory.ProductCategoryName,
                    ShopName = x.Shop.ShopName,
                    ProductImageId = x.ProductImageId,
                    Picture = x.ProductImage?.Image
                }).ToList();

                return viewModel;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ProductViewModel GetProductDetails(int id)
        {
            try
            {
                Product product = _context.Product.Where(x => x.ProductId == id)
                                                    .Include(x=>x.ProductCategory)
                                                    .Include(x => x.Shop)
                                                    .Include(x=>x.ProductImage)
                                                    .FirstOrDefault();

                ProductViewModel viewModel = new ProductViewModel
                {
                    Id = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    SerialNumber = product.SerialNumber,
                    ProductCategoryID = product.ProductCategoryId,
                    ShopID = product.ShopId,
                    ProductCategoryName = product.ProductCategory.ProductCategoryName,
                    ShopName = product.Shop.ShopName,
                    ProductImageId = product.ProductImageId,
                    Picture = product.ProductImage?.Image,
                    ShopList = new SelectList(_shopService.GetShops(), "Id", "ShopName"),
                    ProductCategoryList = new SelectList(_productCategoryService.GetProductCategories(), "Id", "ProductCategoryName")
                };

                return viewModel;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ProductViewModel Create()
        {
            ProductViewModel model = new ProductViewModel();            
            model.ShopList = new SelectList(_shopService.GetShops(), "Id", "ShopName");
            model.ProductCategoryList = new SelectList(_productCategoryService.GetProductCategories(), "Id", "ProductCategoryName");
            return model;
        }

        public bool AddProduct(ProductViewModel model)
        {
            try
            {
                ProductImage image = new ProductImage();
                Product product = new Product();
                if (model.ProductImage != null)
                {
                    byte[] imageByte;

                    using (var memoryStream = new MemoryStream())
                    {
                        model.ProductImage.CopyTo(memoryStream);
                        imageByte = memoryStream.ToArray();
                    }

                    image = new ProductImage
                    {
                        Image = imageByte
                    };

                    _context.ProductImage.Add(image);
                    _context.SaveChanges();
                    product.ProductImageId = image.ProductImageId;
                }

                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.SerialNumber = model.SerialNumber;
                product.ProductCategoryId = model.ProductCategoryID;
                product.ShopId = model.ShopID;
                

                _context.Product.Add(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateProduct(ProductViewModel model)
        {
            try
            {
                ProductImage image = new ProductImage();
                Product product = new Product();
                if (model.ProductImageId != null && model.ProductImage != null)
                {
                    image = _context.ProductImage.Where(x => x.ProductImageId == model.ProductImageId).FirstOrDefault();

                    byte[] imageByte = new byte[model.ProductImage.Length];

                    using (var memoryStream = new MemoryStream())
                    {
                        model.ProductImage.CopyTo(memoryStream);
                        imageByte = memoryStream.ToArray();
                    }

                    image.Image = imageByte;
                    _context.ProductImage.Update(image);
                    _context.SaveChanges();
                    product.ProductImageId = image?.ProductImageId;
                }

                if (model.ProductImageId == null && model.ProductImage != null)
                {
                    byte[] imageByte;

                    using (var memoryStream = new MemoryStream())
                    {
                        model.ProductImage.CopyTo(memoryStream);
                        imageByte = memoryStream.ToArray();
                    }

                    image = new ProductImage
                    {
                        Image = imageByte
                    };

                    _context.ProductImage.Add(image);
                    _context.SaveChanges();
                    product.ProductImageId = image?.ProductImageId;
                }

                product = _context.Product.Where(x => x.ProductId == model.Id).FirstOrDefault();

                product.ProductName = model.ProductName;
                product.Price = model.Price;
                product.SerialNumber = model.SerialNumber;
                product.ProductCategoryId = model.ProductCategoryID;
                product.ShopId = model.ShopID;                

                _context.Product.Update(product);                
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteProduct(int id)
        {
            try
            {
                Product product = _context.Product.Where(x => x.ProductId == id).FirstOrDefault();

                _context.Product.Remove(product);

                if (product.ProductImageId != null)
                {
                    ProductImage image = _context.ProductImage.Where(x => x.ProductImageId == product.ProductImageId).FirstOrDefault();
                    _context.ProductImage.Remove(image);
                }

                
                _context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
