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
    }
}
