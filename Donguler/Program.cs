using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Proglamlaya başlangıç için temel kurs";
            string kurs3 = "Java";


            string[] kurslar = new string[]
            {
                "Yazılım geliştirici yetiştirme kampı", "Proglamlaya başlangıç için temel kurs","java","python"
            };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For için bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    } 
}
