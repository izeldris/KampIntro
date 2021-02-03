using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Buy(Games game, Gamer gamer)
        {
            game.DiscountedPrice = game.Price % 2;
            if (gamer.IsStudent==true)
            {
                Console.WriteLine("İndirim Uygulandı. Önceki Fiyat : " + game.Price + " İndirim Sonrası Fiyat" + game.DiscountedPrice);
            }
            else
            {
                Console.WriteLine("Fiyat : " + game.Price);
            }
        }
           public void Sell(Games game,Gamer gamer)
        {
         
        }
     
    }
}
