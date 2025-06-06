using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    // Клас, що представляє континент як географічний об'єкт з додатковими властивостями: площею та населенням.
    class Continent :GeoObject
    {
        //Площа
        public double Area { get; set; }

        //Населення
        public int Population { get; set; }

        // Конструктор, який ініціалізує новий екземпляр континента з назвою, координатами, площею і населенням.
        public Continent(string name, (double Latitude, double Longitude) coordinates, double area, int population)
            : base(name, coordinates)
        {
            Area = area;
            Population = population;
        }

        // Перетворює об'єкт на рядок.
        public override string ToString()
        {
            return $"Континент|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area}|{Population}";  
        }

        //Перетворює об'єкт на рядок, враховуючи конвертацію площі в милі квадратні
        public override string ToStringInMile()
        {
            return $"Континент|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area* 0.621371}|{Population}";
        }

        // Створює екземпляр континенту з рядка
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
