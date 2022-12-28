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
                }
            }
            context.SaveChanges();
        }

        private static Category[] Categories = {
            new Category(){Name="Defter"},
            new Category(){Name="Kalem"},
            new Category(){Name="Çanta"},
            new Category(){Name="Silgi"}
        };

        private static Product[] Products = {
            new Product(){Name="Dörtlü Defter",Price=40,ImageUrl="1.jpg",Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", IsApproved=true},
            new Product(){Name="Çiçek desenli Defterler",Price=120,ImageUrl="2.jpg",Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=false},
            new Product(){Name="Tweety desenli defter",Price=37,ImageUrl="3.jpg",Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", IsApproved=true},
            new Product(){Name="Mor Not Defteri",Price=45,ImageUrl="4.jpg",Description="Sert deri kapak, Notebook, çizgili, 50 yaprak", IsApproved=false},
            new Product(){Name="Kiraz desenli Defter",Price=30,ImageUrl="5.jpg",Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, kareli ", IsApproved=true},
            new Product(){Name="Kaktüs desenli defter",Price=30,ImageUrl="6.jpg",Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, çizgili ", IsApproved=true},
            new Product(){Name="24'lü renkli boya kalemi",Price=30,ImageUrl="7.jpg",Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", IsApproved=true},
            new Product(){Name="12'li renkli oya kalemleri",Price=15,ImageUrl="8.jpg",Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=false},
            new Product(){Name="3 adet kurşun kalem",Price=5,ImageUrl="9.jpg",Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", IsApproved=true},
            new Product(){Name="Dolma kalem",Price=7,ImageUrl="10.jpg",Description="Sert deri kapak, Notebook, çizgili, 50 yaprak", IsApproved=false},
            new Product(){Name="3 renk pilot kalem",Price=8,ImageUrl="11.jpg",Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, kareli ", IsApproved=true},
            new Product(){Name="Uçlu kalem",Price=5,ImageUrl="12.jpg",Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, çizgili ", IsApproved=true},
            new Product(){Name="beyaz-mavi silgi",Price=3,ImageUrl="13.jpg",Description="plastik kapak, A4 boyut, 70 yaprak, 2 kareli 2 çizgili", IsApproved=true},
            new Product(){Name="4'lü renkli silgi",Price=12,ImageUrl="14.jpg",Description="Sert kapak, 100 yaprak, A5 boyut, çizgisiz", IsApproved=false},
            new Product(){Name="neon pembe silgi",Price=4,ImageUrl="15.jpg",Description="Sarı sert kapak, A5 boyut, 60 yaprak, çizgili", IsApproved=true},
            new Product(){Name="siyah silgi",Price=3,ImageUrl="16.jpg",Description="Sert deri kapak, Notebook, çizgili, 50 yaprak", IsApproved=false},
            new Product(){Name="beyaz silgi",Price=3,ImageUrl="17.jpg",Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, kareli ", IsApproved=true},
            new Product(){Name="mavi silgi",Price=3,ImageUrl="18.jpg",Description="Spiralli, sert kapak, A5 boyut, 100 yaprak, çizgili ", IsApproved=true},
        };
    }
}