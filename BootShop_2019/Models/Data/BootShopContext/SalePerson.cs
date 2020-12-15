using System;
using System.Collections.Generic;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class SalePerson
    {
        public SalePerson()
        {
            ProductSale = new HashSet<ProductSale>();
        }

        public int SalePersonId { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string Gender { get; set; }
        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
