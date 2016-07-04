using Altkom.Bicycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Altkom.Bicycle.UWPClient.Converters
{
    public class LocationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string result = string.Empty;

            var location = value as Location;

            if (location != null)
            {
                result = $"{location.Latitude} {location.Longitude}";
            }

            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            string text = value as string;

            var array = text.Split(' ');

            var lat = double.Parse(array[0]);
            var lng = double.Parse(array[1]);

            var location = new Location(lat, lng);

            return location;
        }
    }
}
