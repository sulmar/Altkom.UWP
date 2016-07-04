using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class DbStationsService : IStationsService
    {
        public IList<Station> GetStations()
        {
            return new List<Station>()
            {
                new Station()
            };
        }

        public Task<IList<Station>> GetStationsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
