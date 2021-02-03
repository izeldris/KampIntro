using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Harun" && gamer.LastName == "Altun" && gamer.NationalIdentity == 123456789)
            {
                return true;
            }
            else
                return false;
        }
    }
}
