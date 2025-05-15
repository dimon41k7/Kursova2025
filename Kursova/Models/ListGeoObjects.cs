using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class ListGeoObjects
    {
        private List<GeoObject> geoObjectList = new List<GeoObject>();

        public void AddGeoObject(GeoObject geoObject)
        {
            if (!geoObjectList.Contains(geoObject))
            {
                geoObjectList.Add(geoObject);
            }
        }

        public void RemoveGeoObject(GeoObject geoObject)
        {
            geoObjectList.Remove(geoObject);
        }

        public List<GeoObject> ShowGeoObjects()
        {
            return geoObjectList;
        }
    }
}
