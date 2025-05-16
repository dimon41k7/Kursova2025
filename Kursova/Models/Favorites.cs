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
