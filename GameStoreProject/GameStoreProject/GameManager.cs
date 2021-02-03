using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine("Oyun Başarıyla Eklendi.");
        }

        public void Delete(Games game)
        {
            Console.WriteLine("Oyun Başarıyla Silindi.");
        }

        public void Update(Games game)
        {
            Console.WriteLine("Oyun Başarıyla Güncellendi.");
        }
    }
}
