using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.ViewModels
{
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        [DisplayName("Product Category Name")]
        [Required(ErrorMessage = "Provide Name for Category")]
        public string ProductCategoryName { get; set; }
    }
}
