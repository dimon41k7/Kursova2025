using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    class Region:GeoObject
    {
        public string Type { get; set; }
        public string Country { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }

        public Region(string name, (double Latitude, double Longitude) coordinates, string type, string country, string capital, int population) : base(name, coordinates)
        {
            Type = type;
            Country = country;
            Capital = capital;
            Population = population;
        }
    }
}
