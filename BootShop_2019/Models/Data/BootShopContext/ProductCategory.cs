using System;
using System.Collections.Generic;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Product = new HashSet<Product>();
        }

        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
