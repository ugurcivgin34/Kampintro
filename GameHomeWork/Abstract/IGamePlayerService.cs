using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    public interface IGamePlayerService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}
