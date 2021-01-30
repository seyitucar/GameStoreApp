using GameStoreApp.Abstract;
using GameStoreApp.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreApp.Adapters
{
    public class MernisServiceAdapter : IUserValidatonService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody
                (gamer.IdentityNumber, gamer.FirstName, gamer.LastName, gamer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
     
        }
    }
}
