using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.ViewModels
{
    public class ProductSaleViewModel
    {
        public int Id { get; set; }
        [DisplayName("Picture")]
        public byte[] Picture { get; set; }
        [NotMapped]
        public int SalePersonId { get; set; }
        [DisplayName("Product")]
        public string ProductName { get; set; }
        [DisplayName("Sale Person")]
        public string SalePersonName { get; set; }
        [DisplayName("Sold At")]
        public DateTime TimeSold { get; set; }
        [NotMapped]
        public SelectList SalePersonList { get; set; }
    }
}