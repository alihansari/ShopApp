using shopapp.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shopapp.webui.Models
{
    public class CategoryModel
    {
    
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Kategori Adı Zorunludur")]
        [StringLength(100,MinimumLength =5,ErrorMessage ="Kategori İçin 5-100 arasında bir değer giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Url  Zorunludur")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Url İçin 5-100 arasında bir değer giriniz")]
        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}
