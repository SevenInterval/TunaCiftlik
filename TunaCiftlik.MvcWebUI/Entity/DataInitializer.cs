using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TunaCiftlik.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name= "Et Ürünleri", Description = "Et Ürünleri" },
                new Category(){ Name= "Meyveler", Description = "Meyve Ürünleri" },
                new Category(){ Name= "Kuruyemiş", Description = "Kuruyemiş Ürünleri" },
                new Category(){ Name= "Yün Ürünleri", Description = "Yün Ürünleri" },
                new Category(){ Name= "Küçükbaş Hayvanlar", Description = "Küçükbaş Hayvanlar" },
                new Category(){ Name= "Boş Kategori", Description = "Deneme" },
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Haşlamalık Kuşbaşı", Description = "Gerdan yani boyun kısmının alt tarafında kalan kısım, iri parçalar halinde kesildikten sonra haşlamalık et olarak kullanıma uygundur.", Price = 79, Stock = 0, IsApproved = false, CategoryId = 1, IsHome = false, Image = "1.jpg"},
                new Product(){ Name = "Biftek", Description = "Kürek kısmında yer alan bölümün but kısmına doğru kalan kısmından biftek çıkartmak mümkündür.", Price = 64, Stock = 0, IsApproved = false, CategoryId = 1, IsHome = false, Image = "2.jpg"},
                new Product(){ Name = "Burger Kıyması", Description = " Hamburger köftesi hazırlamaya uygun yağlı durumda olan ve lezzetlenmesi için baharata bile ihtiyaç duymayan kıyma bu bölümden çıkartılıyor.", Price = 59, Stock = 0, IsApproved = false, CategoryId = 1, IsHome = false, Image = "3.jpg"},
                new Product(){ Name = "Sotelik Kuşbaşı", Description = "Dananın göğüs kısmından çıkartılan orta yağlı, yumuşak durumda olan et küçük parçalara bölündükten sonra saç tavasında sote yapılmaya oldukça uygun.", Price = 45, Stock = 0, IsApproved = false, CategoryId = 1, IsHome = false, Image = "4.jpg"},

                new Product(){ Name = "Black Splendor Erik", Description = "Ağaçları çok kuvvetli, yarı yayvandır. Çok verimli bir çeşittir. Meyveleri iri, yuvarlak ve dumanlıdır. Kabuk rengi morumsu siyahtır. Meyve eti koyu kırmızı sert, sulu ve lezzetlidir. Akdeniz Bölgesinde Haziran ayının ikinci haftasında hasat edilir.", Price = 15, Stock = 3000, IsApproved = true, CategoryId = 2, IsHome = true, Image = "5.jpg"},
                new Product(){ Name = "Santa Maria Armut", Description = "Meyve şekli hafif basık olup aroması mükemmel, boyun kısmı uzunca, alta doğru genişleyen bir yapıdadır. Yola dayanımı ve raf ömrü uzun olan bir çeşittir.", Price = 34, Stock = 2000, IsApproved = true, CategoryId = 2, IsHome = true, Image = "6.jpg"},

                new Product(){ Name = "Ceviz", Description = "Ceviz, cevizgiller (Juglandaceae) familyasından Juglans cinsinden tek tüysü yaprakları karşılıklı dizilmiş ve aromatik kokulu ağaç türlerinin ortak adı.", Price = 60, Stock = 2000, IsApproved = true, CategoryId = 3, IsHome = true, Image = "7.jpg"},

                new Product(){ Name = "Merinos Koyun Yünü", Description = "Dünyada giyim için üretilen yünün yüzde 90’ını sağlayarak en büyük üretici olan Avustralya’nın güneydoğusunda, Sidney’e yaklaşık 260 kilometre mesafedeki Mudgee kasabasındayız. ", Price = 100, Stock = 2000, IsApproved = true, CategoryId = 4, IsHome = true, Image = "8.jpg"},

                new Product(){ Name = "Merinos Koyunu", Description = "Dünyada giyim için üretilen yünün yüzde 90’ını sağlayarak en büyük üretici olan Avustralya’nın güneydoğusunda, Sidney’e yaklaşık 260 kilometre mesafedeki Mudgee kasabasındayız. ", Price = 1000, Stock = 2000, IsApproved = true, CategoryId = 5, IsHome = true, Image = "9.jpg"},

            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}