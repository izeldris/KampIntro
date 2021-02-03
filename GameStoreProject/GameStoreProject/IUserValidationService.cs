using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
