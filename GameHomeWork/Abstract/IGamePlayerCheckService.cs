using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    interface IGamePlayerCheckService
    {
        void CheckIfRealPerson(GamePlayer gamePlayer);
    }
}
