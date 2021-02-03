using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService  _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oluşturuldu.");
            }
            else
                Console.WriteLine("Kayıt başarısız.");

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
