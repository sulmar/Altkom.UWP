using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class MockStationsService : IStationsService
    {
        private List<Station> _stations;

        public MockStationsService()
        {
            this._stations = new List<Station>
            {
                new Station
                {
                    StationId = 1,
                    StationName = "Station 1",
                    Address = "Metro Slodowiec",
                    Location = new Location(52.05, 20.95),
                },

                new Station
                {
                    StationId = 2,
                    StationName = "Station 2",
                    Address = "PKP Dworzec Centralny",
                    Location = new Location(52.25, 20.45, 10),
                },

                new Station
                {
                    StationId = 3,
                    StationName = "Station 3",
                    Address = "Wroclaw",
                    Location = new Location(51.65, 20.75),
                },

            };
        }

        public IList<Station> GetStations()
        {
            return _stations;
        }

        public Station GetStation(int stationId)
        {
            return _stations.SingleOrDefault(s => s.StationId == stationId);
        }

        public Task<IList<Station>> GetStationsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
