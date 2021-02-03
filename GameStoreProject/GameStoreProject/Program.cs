using System;

namespace GameStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Games _game = new Games();
            Gamer _gamer = new Gamer();
            OrderManager orderManager = new OrderManager(new CampaignManager());
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 1, 
                BirthYear=1985, 
                FirstName="Harun",
                LastName="Altun",
                NationalIdentity=123456789 }) ;

            
            
        }
        
        
    }
}
