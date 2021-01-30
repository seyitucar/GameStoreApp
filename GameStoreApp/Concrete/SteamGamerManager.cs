using GameStoreApp;
using GameStoreApp.Abstract;
using GameStoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Concrete
{
    //MicroService
    public class SteamGamerManager : BaseGamerManager
    {
        IUserValidatonService _userValidatonService;

        public SteamGamerManager(IUserValidatonService userValidatonService)
        {
            _userValidatonService = userValidatonService;
        }

        public override void Add(Gamer gamer)
        {
            if (_userValidatonService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception ("Not a valid user");
            }

        }

    }
}
