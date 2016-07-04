using Altkom.Bicycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.UWPClient.Services
{
    public interface IStationsService
    {
        IList<Station> GetStations();

        Task<IList<Station>> GetStationsAsync();
    }
}
