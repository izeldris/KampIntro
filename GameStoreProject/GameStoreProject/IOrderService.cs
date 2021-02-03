using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    interface IOrderService
    {
        void Sell(Games game, Gamer gamer);
        void Buy(Games game,Gamer gamer);
    }
}
