﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    class City: GeoObject
    {
        public int Population { get; set; }

        public string Region { get; set; }

        public City(string name, (double Latitude, double Longitude) coordinates, int population, string region) : base(name, coordinates)
        {
            Population = population;
            Region = region;
        }

        public override string ToString()
        {
            return $"Місто|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Population}|{Region}";
        }

        public override string ToStringInMile()
        {
            return $"Місто|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Population}|{Region}";
        }
        public static new City FromString(string line)
        {
            string[] arr = line.Split('|');
            return new City(
                Convert.ToString(arr[1]),
                (double.Parse(arr[2]),
                double.Parse(arr[3])),
                Convert.ToInt32(arr[4]),
                Convert.ToString(arr[5])
            );
        }
    }
}
