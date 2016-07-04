using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;
using System.Net.Http;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class RestApiStationsService : IStationsService
    {
        private string baseUri = "http://localhost:61001/api/";

        public IList<Station> GetStations()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Station>> GetStationsAsync()
        {
            var uri = $"{baseUri}Stations";

            return await GenericHttpClient.GetAsync<IList<Station>>(uri);            
        }

       

        
    }
}
