using GameHomeWork.Abstract;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameHomeWork.Adapters
{
    class MernisServiceAdapter : IGamePlayerCheckService
    {
        public void CheckIfRealPerson(GamePlayer gamePlayer)
        {
            Console.WriteLine("Kontrol edildi");
        }
        
    }
}
