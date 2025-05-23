using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class ListGeoObjects : IEnumerable<GeoObject>
    {
        private List<GeoObject> geoObjectList = new List<GeoObject>();
        public int Count => geoObjectList.Count;

        public void AddGeoObject(GeoObject geoObject)
        {
            if (!geoObjectList.Contains(geoObject))
            {
                geoObjectList.Add(geoObject);
            }
        }

        public void RemoveGeoObject(int ind)
        {
            geoObjectList.RemoveAt(ind);
        }

        public List<GeoObject> ShowGeoObjects()
        {
            return geoObjectList;
        }

        public GeoObject this[int index]
        {
            get => geoObjectList[index];
            set => geoObjectList[index] = value;
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
            if (!File.Exists("objects.txt"))
            {
                return;
            }

            using (StreamReader reader = new("objects.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    {
                        if (line.StartsWith("Місто|"))
                            this.AddGeoObject(City.FromString(line));
                        else if (line.StartsWith("Регіон|"))
                            this.AddGeoObject(GeoRegion.FromString(line));
                        else if (line.StartsWith("Країна|"))
                            this.AddGeoObject(Country.FromString(line));
                        else if (line.StartsWith("Континент|"))
                            this.AddGeoObject(Continent.FromString(line));
                    }
                }
            }
        }

        public void Filter(ListGeoObjects list, string name, double minlatdouble, double maxlatdouble, double minlondouble, double maxlondouble)
        {
            foreach (var item in list)
            {
                string strname = item.Name;
                double latitude = item.Coordinates.Latitude;
                double longitude = item.Coordinates.Longitude;
                if (strname.IndexOf(name) > -1&&(latitude>=minlatdouble&&latitude<=maxlatdouble) && (longitude >= minlondouble && longitude <= maxlondouble))
                {
                    this.AddGeoObject(item);
                }
            }
        }

        public void SearchObj(int ind, ListGeoObjects list, bool first = true)
        {
            string line;
            if (first == true)
            {
                line = Convert.ToString(list[ind]);
            }
            else
            {
                line = Convert.ToString(this[ind]);
            }

            if (line.StartsWith("Місто|"))
                return;
            else if (line.StartsWith("Регіон|"))
            {
                GeoRegion obj = GeoRegion.FromString(line);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is City city &&
                        city.Region == obj.Name)
                    {
                        City c = City.FromString(Convert.ToString(list[i]));
                        if (!this.Contains(c))
                        {
                            this.AddGeoObject(c);
                        } 
                    }
                }
            }
            else if (line.StartsWith("Країна|"))
            {
                Country obj = Country.FromString(line);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is GeoRegion region &&
                        region.Country == obj.Name)
                    {
                        GeoRegion r = GeoRegion.FromString(Convert.ToString(list[i]));
                        if (!this.Contains(r))
                        {
                            this.AddGeoObject(r);
                        }
                    }
                }
                for (int j = 0; j < this.Count; j += 1)
                {
                    string l = Convert.ToString(this[j]);
                    if (l.StartsWith("Регіон|"))
                    {
                        this.SearchObj(j, list, false);
                    }
                }
            }
            else if (line.StartsWith("Континент|"))
            {
                Continent obj = Continent.FromString(line);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Country country &&
                        country.Continent == obj.Name)
                    {
                        Country c = Country.FromString(Convert.ToString(list[i]));
                        if (!this.Contains(c))
                        {
                            this.AddGeoObject(c);
                        }
                    }
                }
                for (int j = 0; j < this.Count; j += 1)
                {
                    string l = Convert.ToString(this[j]);
                    if (l.StartsWith("Країна|"))
                    {
                        this.SearchObj(j, list, false);
                    }
                }
            }
        }

        public bool Contains(GeoObject obj)
        {
            return geoObjectList.Any(item =>
            {
                if (obj is City cityObj && item is City city)
                {
                    return city.Name == cityObj.Name &&
                           city.Coordinates.Latitude == cityObj.Coordinates.Latitude &&
                           city.Coordinates.Longitude == cityObj.Coordinates.Longitude &&
                           city.Population == cityObj.Population&&
                           city.Region==cityObj.Region;
                }
                else if (obj is GeoRegion regionObj && item is GeoRegion region)
                {
                    return region.Name == regionObj.Name &&
                           region.Coordinates.Latitude == regionObj.Coordinates.Latitude &&
                           region.Coordinates.Longitude == regionObj.Coordinates.Longitude &&
                           region.Country == regionObj.Country&&
                           region.Type==regionObj.Type&&
                           region.Capital==regionObj.Capital&&
                           region.Population==regionObj.Population;
                }
                else if (obj is Country countryObj && item is Country country)
                {
                    return country.Name == countryObj.Name &&
                           country.Coordinates.Latitude == countryObj.Coordinates.Latitude &&
                           country.Coordinates.Longitude == countryObj.Coordinates.Longitude &&
                           country.Continent == countryObj.Continent&&
                           country.Area==countryObj.Area&&
                           country.Population==countryObj.Population&&
                           country.GovernmentType==countryObj.GovernmentType&&
                           country.Capital==countryObj.Capital;
                }
                //else if (obj is Continent continentObj && item is Continent continent)
                //{
                //    return continent.Name == continentObj.Name;
                //}
                else
                {
                    return false;
                }
            });
        }




        public IEnumerator<GeoObject> GetEnumerator()
        {
            return geoObjectList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
