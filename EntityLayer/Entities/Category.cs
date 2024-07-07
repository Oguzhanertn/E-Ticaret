using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Boş geçilemez" )]
        [Display (Name = "İsim")]
        [StringLength (50,ErrorMessage = "En fazla 50 karakter girilebilir")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        public string Description { get; set; }



        public virtual List <Product> Products { get; set; } // Bir kategoride birden fazla ürün olması için







    }
}
