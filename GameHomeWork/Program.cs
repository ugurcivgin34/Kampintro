using GameHomeWork.Adapters;
using GameHomeWork.Concrete;
using GameHomeWork.Entities;
using System;

namespace GameHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            GamePlayer player1 = new GamePlayer { NationalityId="2222222222",FirstName="Uğur",LastName="Çivgin",DateOfBirth=1994};
            GamePlayer player2 = new GamePlayer { NationalityId = "3333333333", FirstName = "sait", LastName = "Çivgin", DateOfBirth = 2010 };

            Game game1 = new Game { GameName="Hitman",GamePrice=1500};
            Game game2 = new Game { GameName = "Soldier", GamePrice = 200 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);

            GamePlayerManager gamePlayerManager = new GamePlayerManager();
            gamePlayerManager.Ekle(player1);
            gamePlayerManager.Delete(player1);
            gamePlayerManager.Update(player1);

            CampignManeger campignManeger = new CampignManeger();
            campignManeger.CalculateSale(game1);
            campignManeger.SaleInformation(game1);

            MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();
            mernisServiceAdapter.CheckIfRealPerson(player1);
        }
    }
}
