using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class Games
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string PublisherName { get; set; }
        public string GameCategory { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
    }
}
