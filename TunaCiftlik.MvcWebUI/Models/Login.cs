using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunaCiftlik.MvcWebUI.Models
{
    public class Login
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Kullanıcı Adı Boş Olamaz")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        public string Email { get; set; }
        [DisplayName("Beni Hatırla")]
        public string PhoneNumber { get; set; }
        public bool RememberMe { get; set; }
    }
}