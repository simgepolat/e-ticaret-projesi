using System.Linq;
using Microsoft.EntityFrameworkCore;
using eTicaret.entity;

namespace eTicaret.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Defter", Url="Defter"},
            new Category(){Name="Kalem", Url="Kalem"},
            new Category(){Name="Çanta", Url="Çanta"},
            new Category(){Name="Silgi", Url="Silgi"},
            new Category(){Name="Okul",Url="Okul"},
        };

        private static Product[] Products = {
            new Product(){Name="Dörtlü Defter",Url="defter1", Price=40,ImageUrl="1.jpg",Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", IsApproved=true},
            new Product(){Name="Çiçek desenli Defterler", Url="defter2",Price=120,ImageUrl="2.jpg",Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=false},
            new Product(){Name="Tweety desenli defter", Url="defter3",Price=37,ImageUrl="3.jpg",Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", IsApproved=true},
            new Product(){Name="24'lü renkli boya kalemi", Url="kalem1",Price=30,ImageUrl="7.jpg",Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", IsApproved=true},
            new Product(){Name="12'li renkli oya kalemleri", Url="kalem2",Price=15,ImageUrl="8.jpg",Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=false},
            new Product(){Name="3 adet kurşun kalem", Url="kalem3",Price=5,ImageUrl="9.jpg",Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", IsApproved=true},
            new Product(){Name="beyaz-mavi silgi", Url="silgi1",Price=3,ImageUrl="13.jpg",Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", IsApproved=true},
            new Product(){Name="4'lü renkli silgi", Url="silgi2",Price=12,ImageUrl="14.jpg",Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=false},
            new Product(){Name="neon pembe silgi",Url="silgi2",Price=4,ImageUrl="15.jpg",Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", IsApproved=true},
            
        };

        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0], Category=Categories[0]},
            new ProductCategory(){Product=Products[0], Category=Categories[4]},
            new ProductCategory(){Product=Products[1], Category=Categories[0]},
            new ProductCategory(){Product=Products[1], Category=Categories[4]},
            new ProductCategory(){Product=Products[2], Category=Categories[0]},
            new ProductCategory(){Product=Products[2], Category=Categories[4]},
            new ProductCategory(){Product=Products[3], Category=Categories[1]},
            new ProductCategory(){Product=Products[3], Category=Categories[4]},
            new ProductCategory(){Product=Products[4], Category=Categories[1]},
            new ProductCategory(){Product=Products[4], Category=Categories[4]},
            new ProductCategory(){Product=Products[5], Category=Categories[1]},
            new ProductCategory(){Product=Products[5], Category=Categories[4]},
            new ProductCategory(){Product=Products[6], Category=Categories[3]},
            new ProductCategory(){Product=Products[6], Category=Categories[4]},
            new ProductCategory(){Product=Products[7], Category=Categories[3]},
            new ProductCategory(){Product=Products[7], Category=Categories[4]},
            new ProductCategory(){Product=Products[8], Category=Categories[3]},
            new ProductCategory(){Product=Products[8], Category=Categories[4]},
        };
    }
}