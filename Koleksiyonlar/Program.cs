using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Uğur", "Murat", "Sait", "Hakan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);

            //Koleksiyonların normal dizilerden kullanılmasının sebebi normal arraylarde new lediğimiz zaman bellekte 
            //yeni açılıp eski olan veriler varsa silinir.Yeni eklediğimizde eski olanlar sileneceği için sıkıntı yaratır.Koleksiyonlarda bunlar olmaz
            List<string> isimler2 = new List<string> { "Uğur","Murat","Sait","Hakan"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Şahin");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
