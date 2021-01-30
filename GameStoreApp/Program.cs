using GameStoreApp;
using GameStoreApp.Concrete;
using GameStoreApp.Entities;
using GameStoreApp.Abstract;
using System;
using GameStoreApp.Adapters;

namespace GameStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Seyit", LastName  = "Uçar", BirthYear  = 1987, IdentityNumber  = 12345 };
            Gamer gamer2 = new Gamer { Id = 2, FirstName = "Zeynep", LastName = "Uçar", BirthYear = 2017, IdentityNumber = 23456 };

            Game game1 = new Game { Id = 1, Name = "Witcher", Price = 100, Type = "RPG"};
            Game game2 = new Game { Id = 2, Name = "CyberPunk", Price = 200, Type = "Action" };

            Campaign campaign1 = new Campaign { Id = 1,  Name = "Welcome Campaign", DiscountRate = 5 };
            Campaign campaign2 = new Campaign { Id = 2, Name = "New Year Campaign", DiscountRate = 15 };

            Order order1 = new Order { Id = 1, OrderId = 101 };


            BaseGamerManager gamerManager = new SteamGamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);

            OrderManager orderManager = new OrderManager(new CampaingManager());
            orderManager.ApplyCampaign(order1, game2, campaign2);

        }
    }
}
