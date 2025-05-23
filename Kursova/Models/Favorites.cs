using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class Favorites : IEnumerable<GeoObject>
    {
        private List<GeoObject> favoritesList = new List<GeoObject>();
        public int Count => favoritesList.Count;

        public void AddFavorite(GeoObject geoObject)
        {
            if (!favoritesList.Contains(geoObject))
            {
                favoritesList.Add(geoObject);
            }
        }

        public void RemoveFavorite(int ind)
        {
            favoritesList.RemoveAt(ind);
        }

        public List<GeoObject> ShowFavorites()
        {
            return favoritesList;
        }

        public GeoObject this[int index]
        {
            get => favoritesList[index];
            set => favoritesList[index] = value;
        }



        public void RefreshList(ListBox list)
        {
            list.Items.Clear();
            foreach (var item in this)
            {
                list.Items.Add(item.ToString());
            }
        }

        public void RefreshListInMile(ListBox list)
        {
            list.Items.Clear();
            foreach (var item in this)
            {
                list.Items.Add(item.ToStringInMile());
            }
        }

        public void SaveData(string path)
        {
            using (StreamWriter writer = new(path))
            {
                foreach (var obj in this)
                {
                    writer.WriteLine(obj.ToString());
                }
            }
        }

        public void LoadData()
        {
            if (!File.Exists("favoritesobjects.txt"))
            {
                return;
            }

            using (StreamReader reader = new("favoritesobjects.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    {
                        if (line.StartsWith("Місто|"))
                            this.AddFavorite(City.FromString(line));
                        else if (line.StartsWith("Регіон|"))
                            this.AddFavorite(GeoRegion.FromString(line));
                        else if (line.StartsWith("Країна|"))
                            this.AddFavorite(Country.FromString(line));
                        else if (line.StartsWith("Континент|"))
                            this.AddFavorite(Continent.FromString(line));
                    }
                }
            }
        }
        public void AddToFavorites(string line, string selected = "Кілометри")
        {
            if (line.StartsWith("Місто|"))
                this.AddFavorite(City.FromString(line));
            else if (line.StartsWith("Регіон|"))
                this.AddFavorite(GeoRegion.FromString(line));
            else if (line.StartsWith("Країна|"))
            {
                var obj = Country.FromString(line);
                if (selected == "Милі")
                {
                    obj.Area = obj.Area * 1.60934;
                }
                this.AddFavorite(obj);
            }

            else if (line.StartsWith("Континент|"))
            {
                var obj = Continent.FromString(line);
                if (selected == "Милі")
                {
                    obj.Area = obj.Area * 1.60934;
                }
                this.AddFavorite(obj);
            }
        }

        public void Filter(Favorites list, string name, double minlatdouble, double maxlatdouble, double minlondouble, double maxlondouble)
        {
            foreach (var item in list)
            {
                string strname = item.Name;
                double latitude = item.Coordinates.Latitude;
                double longitude = item.Coordinates.Longitude;
                if (strname.IndexOf(name) > -1 && (latitude >= minlatdouble && latitude <= maxlatdouble) && (longitude >= minlondouble && longitude <= maxlondouble))
                {
                    this.AddFavorite(item);
                }
            }
        }





        public IEnumerator<GeoObject> GetEnumerator()
        {
            return favoritesList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
