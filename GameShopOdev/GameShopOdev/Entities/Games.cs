using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopOdev.Entities
{
    public class Games
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }

    }
}
