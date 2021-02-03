using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        void Discount(Gamer gamer);
    }
}
