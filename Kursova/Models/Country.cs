using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    // Клас, що представляє країну як географічний об'єкт з додатковими властивостями: площею, населенням, формою правління, столицею та континентом.
    class Country :GeoObject
    {
        //Площа
        public double Area { get; set; }
        
        //Населення
        public int Population { get; set; }

        //Форма правління
        public string GovernmentType { get; set; }

        //Столиця
        public string Capital { get; set; }

        // Континент, у якому розташована країна.
        public string Continent { get; set; }

        // Конструктор, який ініціалізує новий екземпляр країни з назвою, координатами, площею, населенням, формою правління, столицею і континентом.
        public Country(string name, (double Latitude, double Longitude) coordinates, double area, int population, string governmentType, string capital, string continent)
            : base(name, coordinates)
        {
            Area = area;
            Population = population;
            GovernmentType = governmentType;
            Capital = capital;
            Continent = continent;
        }

        // Перетворює об'єкт на рядок.
        public override string ToString()
        {
            return $"Країна|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area}|{Population}|{GovernmentType}|{Capital}|{Continent}";   
        }

        //Перетворює об'єкт на рядок, враховуючи конвертацію площі в милі квадратні
        public override string ToStringInMile()
        {
            return $"Країна|{Name}|{Coordinates.Latitude}|{Coordinates.Longitude}|{Area* 0.621371}|{Population}|{GovernmentType}|{Capital}|{Continent}";
        }

        // Створює екземпляр країни з рядка
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
