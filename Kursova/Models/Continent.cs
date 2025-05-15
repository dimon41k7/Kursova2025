using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    class Continent:GeoObject
    {
        public double Area { get; set; }
        public int Population { get; set; }

        public Continent(string name, (double Latitude, double Longitude) coordinates, double area, int population)
            : base(name, coordinates)
        {
            Area = area;
            Population = population;
        }

        public override string ToString()
        {
            return $"Континент|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area}|{Population}";
        }

        public static new Continent FromString(string line)
        {
            string[] arr = line.Split('|');
            return new Continent(
                Convert.ToString(arr[1]),
                (double.Parse(arr[2]),
                double.Parse(arr[3])),
                double.Parse(arr[4]),
                Convert.ToInt32(arr[5])
            );
        }
    }
}
