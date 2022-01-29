using shopapp.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        //[Display(Name="Name",Prompt ="Enter Product Name")]
        //[Required(ErrorMessage ="Ürün İsmi Zorunlu Bir Alan")]
        //[StringLength(60,MinimumLength =5,ErrorMessage ="Ürün İsmi 5-10 karakter aralığında olmalıdır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ürün URL'i Zorunlu Bir Alan")]
        public string Url { get; set; }

        [Required(ErrorMessage = "Ürün Fiyatı Zorunlu Bir Alan")]
        [Range(1,10000,ErrorMessage ="Ürün Fiyatı 1-10000 arasında olmalıdır")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Ürün Açıklaması Zorunlu Bir Alan")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Ürün Açıklaması 5-100 karakter aralığında olmalıdır")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün Resim URL'i Zorunlu Bir Alan")]
        public string ImageUrl { get; set; }

        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
