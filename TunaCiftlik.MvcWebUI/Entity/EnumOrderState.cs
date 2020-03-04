using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TunaCiftlik.MvcWebUI.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,
        [Display(Name = "Kargoya Verildi")]
        Cargo,
        [Display(Name = "Tamamlandı")]
        Completed,
        [Display(Name = "Sipariş İptal Edildi")]
        Cancel
    }
}