using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Müsteri müsteri = new Müsteri();
            müsteri.Id = 1;
            müsteri.Ad = "Uğur";
            müsteri.Soyad = "Çivgin";
            müsteri.Cinsiyet = 'E';
            müsteri.KimlikNo = "1234123323191";

            Müsteri müsteri2 = new Müsteri();
            müsteri2.Id = 2;
            müsteri2.Ad = "Sait";
            müsteri2.Soyad = "Çivgin";
            müsteri2.Cinsiyet = 'E';
            müsteri2.KimlikNo = "23123322123";

            Müsteri müsteri3 = new Müsteri();
            müsteri3.Id = 1;
            müsteri3.Ad = "Suat";
            müsteri3.Soyad = "Şahin";
            müsteri3.Cinsiyet = 'K';
            müsteri3.KimlikNo = "424124231242";

            MüsteriManager müsteriManager = new MüsteriManager();
            müsteriManager.Ekle(müsteri);
            müsteriManager.Ekle(müsteri2);
            müsteriManager.Ekle(müsteri3);
            müsteriManager.Sil(müsteri);


            Müsteri[] müsteris = new Müsteri[]
            {
                müsteri,müsteri2,müsteri3
            };

            foreach (Müsteri customer in müsteris)
            {
                Console.WriteLine(customer.Ad + " " + customer.Soyad);
            }






            }
    }
}
