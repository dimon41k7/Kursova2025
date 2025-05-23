using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    class GeoRegion:GeoObject
    {
        public string Type { get; set; }
        public string Country { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }

        public GeoRegion(string name, (double Latitude, double Longitude) coordinates, string type, string country, string capital, int population) : base(name, coordinates)
        {
            Type = type;
            Country = country;
            Capital = capital;
            Population = population;
        }

        public override string ToString()
        {
            return $"Регіон|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Type}|{Capital}|{Population}|{Country}";
        }

        public override string ToStringInMile()
        {
            return $"Регіон|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Type}|{Capital}|{Population}|{Country}";
        }

        public static new GeoRegion FromString(string line)
        {
            string[] arr = line.Split('|');
            return new GeoRegion(
                Convert.ToString(arr[1]),
                (double.Parse(arr[2]),
                double.Parse(arr[3])),
                Convert.ToString(arr[4]),
                Convert.ToString(arr[7]),
                Convert.ToString(arr[5]),
                Convert.ToInt32(arr[6])
            );
        }
    }
}
