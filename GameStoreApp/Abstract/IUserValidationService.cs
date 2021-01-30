using GameStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Abstract
{
    public interface IUserValidatonService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
