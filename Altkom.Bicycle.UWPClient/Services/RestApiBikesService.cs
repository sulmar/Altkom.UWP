using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class RestApiBikesService : IBikesService
    {
        private string baseUri = "http://localhost:61001/api/";

        public IList<Bike> GetBikes()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Bike>> GetBikesAsync()
        {
            var uri = $"{baseUri}Bikes";
            return await GenericHttpClient.GetAsync<IList<Bike>>(uri);
        }
    }
}
