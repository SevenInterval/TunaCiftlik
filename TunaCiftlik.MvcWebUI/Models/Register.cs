using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunaCiftlik.MvcWebUI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Eposta")]
        [EmailAddress(ErrorMessage = "Eposta adresiniz belirtilen formatla uyumlu değil")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Telefon")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Şifre")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Şifre 6 ve 16 karakter arasında olmalıdır")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreleriniz uyuşmuyor.")]
        public string RePassword { get; set; }
    }
}