using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class ListGeoObjects : IEnumerable<GeoObject>
    {
        private List<GeoObject> geoObjectList = new List<GeoObject>();

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
