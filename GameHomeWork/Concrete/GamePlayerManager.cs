using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Concrete
{
    public class GamePlayerManager : IPlayerService
    {
        public void Delete(GamePlayer gamePlayer)
        {
            Console.WriteLine("Kullanıcı silindi");
        }

        public void Ekle(GamePlayer gamePlayer)
        {
            Console.WriteLine("Kullanıcı eklendi");
        }

        public void Update(GamePlayer gamePlayer)
        {
            Console.WriteLine("Kullanıcı güncellendi");
        }
    }
}
