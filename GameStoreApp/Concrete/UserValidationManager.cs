using GameStoreApp.Abstract;
using GameStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Concrete
{
    public class UserValidationManager : IUserValidatonService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }

    }
}
