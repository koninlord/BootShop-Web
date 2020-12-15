using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootShop_2019.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [NotMapped]
        public int? ProductImageId { get; set; }
        [DisplayName("Image")]
        [NotMapped]
        public IFormFile ProductImage { get; set; }
        [DisplayName("Image")]
        [NotMapped]
        public byte[] Picture { get; set; }
        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Provide product name")]
        public string ProductName { get; set; }
        [DisplayName("Price")]
        [Required(ErrorMessage = "Provide product price")]
        public decimal Price { get; set; }
        [DisplayName("Serial Number")]
        [Required(ErrorMessage = "Provide unique serial number")]
        public string SerialNumber { get; set; }        
        [DisplayName("Product Category")]
        [Required(ErrorMessage = "Select category")]
        [NotMapped]
        public int ProductCategoryID { get; set; }
        [DisplayName("Product Category")]
        public string ProductCategoryName { get; set; }
        [DisplayName("Product Location")]
        [Required(ErrorMessage = "Select shop")]
        [NotMapped]
        public int ShopID { get; set; }
        [DisplayName("Product Location")]
        public string ShopName { get; set; }
        [NotMapped]
        public SelectList ProductCategoryList { get; set; }
        [NotMapped]
        public SelectList ShopList { get; set; }
    }
}
