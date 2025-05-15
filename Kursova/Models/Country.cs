using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    class Country:GeoObject
    {
        public double Area { get; set; }
        public int Population { get; set; }
        public string GovernmentType { get; set; }
        public string Capital { get; set; }

        public Country(string name, (double Latitude, double Longitude) coordinates, double area, int population, string governmentType, string capital)
            : base(name, coordinates)
        {
            Area = area;
            Population = population;
            GovernmentType = governmentType;
            Capital = capital;
        }
    }
}
