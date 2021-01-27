using GameHomeWork.Concrete;
using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    interface IPlayerService
    {
        void Ekle(GamePlayer gamePlayer);
        void Delete(GamePlayer gamePlayer);
        void Update(GamePlayer gamePlayer);
    }
}
