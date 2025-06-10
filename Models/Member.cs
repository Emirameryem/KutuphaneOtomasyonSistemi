using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KütüphaneOtomasyon.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad zorunludur.")]
        [Display(Name = "Ad Soyad")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rol bilgisi zorunludur.")]
        [Display(Name = "Rol")]
        public string Role { get; set; } // Student veya Teacher

        public List<Loan>? Loans { get; set; }
    }
}

