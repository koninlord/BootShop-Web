using System;
using System.Collections.Generic;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class ProductImage
    {
        public ProductImage()
        {
            Product = new HashSet<Product>();
        }

        public int ProductImageId { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
