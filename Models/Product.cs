using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.WebUI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength =10,ErrorMessage ="Ürün İsmi 10-60 Karakter Arasında Olamalıdır.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Fiyat Alanıza Zorunludur")]
        [Range(1,10000)]
        public double? Price { get; set; }
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }
    }
}
