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
    }
}
