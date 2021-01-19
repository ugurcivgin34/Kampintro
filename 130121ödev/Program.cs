using System;

namespace _130121ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product ürün = new Product();
            ürün.fiyati = 1200;
            ürün.ürünAdi = "Laptop";

            Product ürün2 = new Product();
            ürün2.fiyati = 4000;
            ürün2.ürünAdi = "Telefon";

            Product ürün3 = new Product();
            ürün3.fiyati = 1260;
            ürün3.ürünAdi = "Masa";

            Product[] product = new Product[] { ürün,ürün2,ürün3};


            foreach (var urun in product)
            {
                Console.WriteLine(urun.ürünAdi + " " + urun.fiyati +" TL");
            }

            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].ürünAdi + " " + product[i].fiyati+ " TL" );
            }

            int x = 0;
            while (x < product.Length)
            {
                Console.WriteLine(product[x].ürünAdi + " " + product[x].fiyati + " TL");
                x++;
            }

        }
        class Product
        {
            public string ürünAdi { get; set; }
            public int fiyati { get; set; }
            

        }
    }
}
