using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "İsim")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Soyisim")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "E-Posta")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        [EmailAddress(ErrorMessage = "E-Mail formatında giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Boş geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girilebilir")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "Şifreleri farklı girdiniz")]
        public string RePassword { get; set; }


        [StringLength(10, ErrorMessage = "En fazla 10 karakter girilebilir")]
        public string Role { get; set; }







    }
}
