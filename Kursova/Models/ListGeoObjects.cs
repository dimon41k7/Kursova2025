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
