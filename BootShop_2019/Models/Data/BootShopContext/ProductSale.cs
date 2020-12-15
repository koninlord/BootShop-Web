using System;
using System.Collections.Generic;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class ProductSale
    {
        public int ProductId { get; set; }
        public int SalePersonId { get; set; }
        public DateTime DateTimeSold { get; set; }

        public virtual Product Product { get; set; }
        public virtual SalePerson SalePerson { get; set; }
    }
}
