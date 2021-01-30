using GameStoreApp.Abstract;
using GameStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Concrete
{
    public class CampaingManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated");
        }
    }
}
