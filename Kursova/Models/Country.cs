﻿using System;
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
        public string Continent { get; set; }

        public Country(string name, (double Latitude, double Longitude) coordinates, double area, int population, string governmentType, string capital, string continent)
            : base(name, coordinates)
        {
            Area = area;
            Population = population;
            GovernmentType = governmentType;
            Capital = capital;
            Continent = continent;
        }

        public override string ToString()
        {
            return $"Країна|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area}|{Population}|{GovernmentType}|{Capital}|{Continent}";   
        }

        public override string ToStringInMile()
        {
            return $"Країна|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area* 0.621371}|{Population}|{GovernmentType}|{Capital}|{Continent}";
        }
        public static new Country FromString(string line)
        {
            string[] arr = line.Split('|');
            return new Country(
                Convert.ToString(arr[1]),
                (double.Parse(arr[2]),
                double.Parse(arr[3])),
                double.Parse(arr[4]),
                Convert.ToInt32(arr[5]),
                Convert.ToString(arr[6]),
                Convert.ToString(arr[7]),
                Convert.ToString(arr[8])
            );
        }
    }
}
