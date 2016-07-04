using Altkom.Bicycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Altkom.Bicycle.WebApiService.Controllers
{
    public class StationsController : ApiController
    {
        private IList<Station> stations = new List<Station>
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

        public Station Get(int id)
        {
            var station = stations.SingleOrDefault(s => s.StationId == id);

            return station;
        }

        public IList<Station> Get()
        {
            return stations;
        }
      
    }
}
