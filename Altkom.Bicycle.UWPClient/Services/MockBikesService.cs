using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class MockBikesService : IBikesService
    {
        private IList<Bike> _bikes = new List<Bike>
        {
            new Bike { BikeId = 1, Model = "Bebiko" },
            new Bike { BikeId = 2, Model = "Romet" },
            new Bike { BikeId = 3, Model = "ABC" },            
        };

        public IList<Bike> GetBikes()
        {
            return _bikes;
        }

        public Task<IList<Bike>> GetBikesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
