using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.Models
{

    public class Location : Base
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Altitude { get; set; }

        public Location()
        {

        }

        public Location(double latitude, double longitude, double altitude)
            : this(latitude, longitude)
        {
            this.Altitude = altitude;
        }

        public Location(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        //public Location(double latitude, double longitude, double altitude = 0)
        //{
        //    this.Latitude = latitude;
        //    this.Longitude = longitude;
        //    this.Altitude = altitude;
        //}
    }
}
