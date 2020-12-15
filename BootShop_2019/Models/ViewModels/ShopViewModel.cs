using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.ViewModels
{
    public class ShopViewModel
    {        
        public int Id { get; set; }
        [DisplayName("Name")]
        public string ShopName { get; set; }
        [DisplayName("Location")]
        public string ShopLocation { get; set; }
    }
}
