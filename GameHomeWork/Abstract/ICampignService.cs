using GameHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomeWork.Abstract
{
    interface ICampignService
    {
        void CalculateSale(Game game);
        void SaleInformation(Game game);
    }
}
