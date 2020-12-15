using System;
using System.Collections.Generic;

namespace BootShop_2019.Models.Data.BootShopContext
{
    public partial class Shop
    {
        public Shop()
        {
            Product = new HashSet<Product>();
            SalePerson = new HashSet<SalePerson>();
        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopLocation { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<SalePerson> SalePerson { get; set; }
    }
}
