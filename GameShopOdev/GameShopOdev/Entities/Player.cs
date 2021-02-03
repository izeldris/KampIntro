using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopOdev.Entities
{
    public class Player:Person
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password{ get; set; }
        public double AccountBalance { get; set; }
    }
}
