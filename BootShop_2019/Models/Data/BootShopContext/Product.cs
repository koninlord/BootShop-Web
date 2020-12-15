using System;
using System.Collections.Generic;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string SerialNumber { get; set; }
        public int ProductCategoryId { get; set; }
        public int ShopId { get; set; }
        public int? ProductImageId { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductImage ProductImage { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual ProductSale ProductSale { get; set; }
    }
}
