using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    class CampignManeger : ICampignService
    {
        public void CalculateSale(Game game)
        {
            Console.WriteLine("Hesaplandı");
        }

        public void SaleInformation(Game game)
        {
            Console.WriteLine("Kampanya uygulandı");
        }
    }
}
