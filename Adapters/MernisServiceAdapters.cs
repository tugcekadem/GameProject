using GameProject.Abstract;
using GameProject.Entity;
using MernisServiceReference;
using System;

namespace GameProject.Adapters
{
    public class MernisServiceAdapters : IUserValidationService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.NationaltyId),
                player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
