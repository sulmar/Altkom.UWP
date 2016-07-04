using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;
using System.Xml.Linq;
using System.Globalization;
using System.Net.Http;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class XmlStationsService : IStationsService
    {
        private const string uri = "https://nextbike.net/maps/nextbike-official.xml";

        public IList<Station> GetStations()
        {
            return GetStationsAsync().Result;
        }

        //public IList<Station> GetStations()
        //{
        //    var doc = XDocument.Load(uri)
        //    .Root
        //    .Descendants("country")
        //    .Where(item => item.Attribute("country_name").Value == "Poland")
        //    .Descendants("city")
        //    .Where(item => item.Attribute("name").Value == "Warszawa")
        //    .Descendants("place")
        //    .Select(item => new
        //    {
        //        Latitude = item.Attribute("lat").Value,
        //        Longitude = item.Attribute("lng").Value,
        //        Number = item.Attribute("number").Value,
        //        StationName = item.Attribute("name").Value,

        //    })
        //    ;

        //    var stations = doc.Select(s => new Station
        //    {
        //        StationId = int.Parse(s.Number),
        //        StationName = s.StationName,
        //        Location = new Location
        //        (
        //                double.Parse(s.Latitude, CultureInfo.InvariantCulture), 
        //                double.Parse(s.Longitude, CultureInfo.InvariantCulture)
        //        )
        //    });

        //    return stations.ToList();
        //}



        public async Task<IList<Station>> GetStationsAsync()
        {

                var http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(uri);

#if DEBUG
                await Task.Delay(5000);
#endif

                var content = await response.Content.ReadAsStringAsync();

                var doc = XDocument.Parse(content)
               .Root
               .Descendants("country")
               .Where(item => item.Attribute("country_name").Value == "Poland")
               .Descendants("city")
               .Where(item => item.Attribute("name").Value == "Warszawa")
               .Descendants("place")
               .Select(item => new
               {
                   Latitude = item.Attribute("lat").Value,
                   Longitude = item.Attribute("lng").Value,
                   Number = item.Attribute("number").Value,
                   StationName = item.Attribute("name").Value,

               })
               ;

                var stations = doc.Select(s => new Station
                {
                    StationId = int.Parse(s.Number),
                    StationName = s.StationName,
                    Location = new Location
                    (
                            double.Parse(s.Latitude, CultureInfo.InvariantCulture),
                            double.Parse(s.Longitude, CultureInfo.InvariantCulture)
                    )
                });

                return stations.ToList();

    
        }


        //private void DoWork(EventArgs e)
        //{

        //}
    }
}
