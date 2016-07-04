using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Altkom.Bicycle.Services
{
    public class XmlStationsService
    {
        private const string uri = "https://nextbike.net/maps/nextbike-official.xml";

        public void GetStations()
        {
            var doc = XDocument.Load(uri)
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
            ;


            throw new NotImplementedException();
        }
    }
}
