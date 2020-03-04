using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TunaCiftlik.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }

        [DisplayName("Ürün Stok Sayısı")]
        public int Stock { get; set; }

        [DisplayName("Ürün Fotoğrafı")]
        public string Image { get; set; }

        [DisplayName("Stok Bilgisi")]
        public bool IsApproved { get; set; }

        [DisplayName("Anasayfa Bilgisi")]
        public bool IsHome { get; set; }

        [DisplayName("Ürün Kategori Idsi")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }


    }
}