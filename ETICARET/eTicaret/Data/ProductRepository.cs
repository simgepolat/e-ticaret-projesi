using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicaret.Models;

namespace eTicaret.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products=null;
        static ProductRepository()
        {
            _products=new List<Product>
            {
                new Product {ProductId=1,ImageUrl="1.jpg", Name="Dörtlü Defter",Price=40,Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", CategoryId=1},
                new Product{ProductId=2, ImageUrl="2.jpg", Name="Çiçek desenli Defterler",Price=120,Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", CategoryId=1, IsApproved=true},
                new Product {ProductId=3, ImageUrl="3.jpg", Name="Tweety desenli defter",Price=37,Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", CategoryId=1 },
                new Product{ProductId=4, ImageUrl="4.jpg", Name="Mor Not Defteri",Price=45 ,Description="Sert deri kapak, Notebook, çizgili, 50 yaprak", CategoryId=1},
                new Product {ProductId=5, ImageUrl="5.jpg", Name="Kiraz desenli Defter",Price=30,Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, kareli ", CategoryId=1, IsApproved=true },
                new Product{ProductId=6, ImageUrl="6.jpg", Name="Kaktüs desenli defter",Price=30,Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, çizgili ", CategoryId=1, IsApproved=true},
                new Product {ProductId=7,ImageUrl="7.jpg", Name="24'lü renkli boya kalemi",Price=30,Description="24 farklı renk seçeneği, ince uç, anında kuruma etkisi", CategoryId=2 },
                new Product{ProductId=8, ImageUrl="8.jpg", Name="12'li renkli oya kalemleri",Price=15,Description="12 farklı renk seçeneği, ince uç, anında kuruma etkisi", CategoryId=2, IsApproved=true},
                new Product {ProductId=9, ImageUrl="9.jpg", Name="3 adet kurşun kalem",Price=5,Description="Faber Castell marka, 3 adet, dayanıklı ve kırılmaz uç", CategoryId=2 },
                new Product{ProductId=10, ImageUrl="10.jpg", Name="Dolma kalem",Price=7 ,Description="Siyah renk, Doldurulabilir dolma kalem, akma yapmaz", CategoryId=2},
                new Product {ProductId=11, ImageUrl="11.jpg", Name="3 renk pilot kalem",Price=8,Description="kırmızı mavi siyah renkli pilot kalemler", CategoryId=2, IsApproved=true },
                new Product{ProductId=12, ImageUrl="12.jpg", Name="Uçlu kalem",Price=5,Description="Rotring Marka, 0.7 uçlu, kahverengi uçlu kalem", CategoryId=2, IsApproved=true},
                new Product {ProductId=13,ImageUrl="13.jpg", Name="beyaz-mavi silgi",Price=3,Description="Faber-Castell marka, iki taraflı silgi", CategoryId=4 },
                new Product{ProductId=14, ImageUrl="14.jpg", Name="4'lü renkli silgi",Price=12,Description="Pembe, yeşil, mavi, turuncu, 4 adet silgi", CategoryId=4, IsApproved=true},
                new Product {ProductId=15, ImageUrl="15.jpg", Name="neon pembe silgi",Price=4,Description="Faber Castell neon pembe silgi", CategoryId=4 },
                new Product{ProductId=16, ImageUrl="16.jpg", Name="siyah silgi",Price=3 ,Description="Faber Castell siyah sert silgi", CategoryId=4},
                new Product {ProductId=17, ImageUrl="17.jpg", Name="beyaz silgi",Price=3,Description="Faber Castell beyaz yumuşak silgi", CategoryId=4, IsApproved=true },
                new Product{ProductId=18, ImageUrl="18.jpg", Name="mavi silgi",Price=3,Description="Faber Castell mavi sınav silgisi", CategoryId=4, IsApproved=true},
                new Product {ProductId=19,ImageUrl="19.jpg", Name="Pembe çanta",Price=75,Description="pembe, gökkuşak ve köpek desenli, kız çocuk okul çantası", CategoryId=3},
                new Product{ProductId=20, ImageUrl="20.jpg", Name="Puma pembe-Gri çanta",Price=230,Description="Puma marka, pembe- gri renk, unisex okul çantası", CategoryId=3, IsApproved=true},
                new Product {ProductId=21, ImageUrl="21.jpg", Name="Araba baskılı çanta",Price=185,Description="Araba figürlü, siyah-turuncu renk, erkek çocuk çantası", CategoryId=3},
                new Product{ProductId=22, ImageUrl="22.jpg", Name="Barbie baskılı çanta",Price=385 ,Description="Barbie lisanslı çanta, beslenme çantası 'hediye'", CategoryId=3},
                new Product {ProductId=23, ImageUrl="23.jpg", Name="Yıldız baskılı çanta",Price=130,Description="Siyah-beyaz renk, yıldız baskılı kız çantası", CategoryId=3, IsApproved=true },
                new Product{ProductId=24, ImageUrl="24.jpg", Name="adidas unisex çanta",Price=499,Description="Adidas marka, unisex, su geçirmez çanta", CategoryId=3, IsApproved=true}
            };
        }
        public static List<Product> Products{
            get {
                return _products;
            }
        }

        //liste üzerinden bir eleman eklenmek istenildiğinde
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }


        //kullanıcı id gönderir, id geri döndürme
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p=>p.ProductId==id);
        }
        public static void EditProduct(Product product)
        {
            foreach(var p in _products)
            {
                if(p.ProductId==product.ProductId)
                {
                    p.Name=product.Name;
                    p.Price=product.Price;
                    p.ImageUrl=product.ImageUrl;
                    p.Description=product.Description;
                    p.IsApproved=product.IsApproved;
                    p.CategoryId=product.CategoryId;
                }
            }
        }
          public static void DeleteProduct(int id)
         {
             var product = GetProductById(id);

             if (product != null)
             {
                 _products.Remove(product);
             }
         }
    }
}