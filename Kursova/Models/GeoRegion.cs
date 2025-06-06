using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    // Клас, що представляє регіон як географічний об'єкт з додатковими властивостями: типом регіону, країною, столицею, населенням.
    class GeoRegion :GeoObject
    {
        //Тип регіону
        public string Type { get; set; }

        //Країна
        public string Country { get; set; }

        //Столиця
        public string Capital { get; set; }

        //Населення
        public int Population { get; set; }

        // Конструктор, який ініціалізує новий екземпляр регіону з назвою, координатами, типом, країною, столицею і населенням.
        public GeoRegion(string name, (double Latitude, double Longitude) coordinates, string type, string country, string capital, int population) : base(name, coordinates)
        {
            Type = type;
            Country = country;
            Capital = capital;
            Population = population;
        }

        // Перетворює об'єкт на рядок.
        public override string ToString()
        {
            return $"Регіон|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Type}|{Capital}|{Population}|{Country}";
        }

        //Перетворює об'єкт на рядок, враховуючи конвертацію площі в милі квадратні
        public override string ToStringInMile()
        {
            return $"Регіон|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Type}|{Capital}|{Population}|{Country}";
        }

        // Створює екземпляр регіону з рядка
        public static new GeoRegion FromString(string line)
        {
            string[] arr = line.Split('|');
            return new GeoRegion(
                Convert.ToString(arr[1]),
                (double.Parse(arr[2]),
                double.Parse(arr[3])),
                Convert.ToString(arr[4]),
                Convert.ToString(arr[7]),
                Convert.ToString(arr[5]),
                Convert.ToInt32(arr[6])
            );
        }
    }
}
