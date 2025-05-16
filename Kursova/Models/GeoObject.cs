using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class GeoObject
    {
        public string Name { get; set; }
        public (double Latitude, double Longitude) Coordinates { get; set; }

        public GeoObject(string name, (double Latitude, double Longitude) coordinates)
        {
            Name = name;
            Coordinates = coordinates;
        }

        public virtual string ToStringInMile()
        {
            return ToString();
        }
    }
}
