using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    // Клас, що представляє місто як географічний об'єкт з додатковими властивостями: населенням та регіоном.
    class City : GeoObject
    {
        // Населення міста.
        public int Population { get; set; }

        // Регіон, у якому розташоване місто.
        public string Region { get; set; }

        // Конструктор, який ініціалізує новий екземпляр міста з назвою, координатами, населенням і регіоном.
        public City(string name, (double Latitude, double Longitude) coordinates, int population, string region) : base(name, coordinates)
        {
            Population = population;
            Region = region;
        }

        // Перетворює об'єкт на рядок.
        public override string ToString()
        {
            return $"Місто|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Population}|{Region}";
        }

        //Перетворює об'єкт на рядок, враховуючи конвертацію площі в милі квадратні
        public override string ToStringInMile()
        {
            return $"Місто|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Population}|{Region}";
        }

        // Створює екземпляр міста з рядка
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
