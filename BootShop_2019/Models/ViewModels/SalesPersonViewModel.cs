using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.ViewModels
{
    public class SalePersonViewModel
    {
        public int Id { get; set; }
        [DisplayName("Surname")]
        public string Surname { get; set; }
        [DisplayName("Othernames")]
        public string Othername { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        [DisplayName("Gender")]
        public char Gender { get; set; }
        [NotMapped]
        [DisplayName("Stationed Shop")]
        public int ShopId { get; set; }
        [DisplayName("Stationed Shop")]
        public string ShopName { get; set; }
        [DisplayName("Select Shop")]
        [NotMapped]
        public SelectList ShopList { get; set; }
    }
}
