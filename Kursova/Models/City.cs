using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    class City: GeoObject
    {
        public int Population { get; set; }

        public City(string name, (double Latitude, double Longitude) coordinates, int population) : base(name, coordinates)
        {
            Population = population;
        }

        public override string ToString()
        {
            return $"Місто|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Population}";
        }

        public override string ToStringInMile()
        {
            return $"Місто|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Population}";
        }
        public static new City FromString(string line)
        {
            string[] arr = line.Split('|');
            return new City(
                Convert.ToString(arr[1]),
                (double.Parse(arr[2]),
                double.Parse(arr[3])),
                Convert.ToInt32(arr[4])
            );
        }
    }
}
