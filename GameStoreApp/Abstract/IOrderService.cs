using GameStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Abstract
{
    public interface IOrderService
    {
        void ApplyCampaign(Order order,Game game, Campaign campaign);

    }
}
