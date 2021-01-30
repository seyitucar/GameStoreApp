using GameStoreApp.Abstract;
using GameStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Concrete
{
    public class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;

        }

        public void ApplyCampaign(Order order, Game game, Campaign campaign)
        {
            decimal campaingService = game.Price - ((game.Price * campaign.DiscountRate) / 100);

            Console.WriteLine("You bought : " + game.Name);
            Console.WriteLine("Total Game Price : " + campaingService);
            Console.WriteLine(campaign.Name + " Aplied");

        }
    }
}
