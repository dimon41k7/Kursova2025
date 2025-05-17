using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class GeoObject
    {
        public string Name { get; set; }
        public (double Latitude, double Longitude) Coordinates { get; set; }

        public GeoObject(string name, (double Latitude, double Longitude) coordinates)
        {
            Name = name;
            Coordinates = coordinates;
        }

        public virtual string ToStringInMile()
        {
            return ToString();
        }

        public static void ShowInMap(string[] arrword)
        {
            string latitude = arrword[2];
            int ind = latitude.IndexOf(".");
            if (ind != -1)
            {
                latitude = latitude.Substring(0, ind) + "," + latitude.Substring(ind + 1);
            }
            int firstind = latitude.IndexOf(",");
            string longitude = arrword[3];
            ind = longitude.IndexOf(".");
            if (ind != -1)
            {
                longitude = longitude.Substring(0, ind) + "," + longitude.Substring(ind + 1);
            }
            int secondind = longitude.IndexOf(",");
            if (firstind != -1 && secondind != -1)
            {
                string firstpartlatitude = latitude.Substring(0, firstind);
                string secondpartlatitude = latitude.Substring(firstind + 1);
                string firstpartlongitude = longitude.Substring(0, secondind);
                string secondpartlongitude = longitude.Substring(secondind + 1);


                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"https://www.google.com/maps?q={Convert.ToInt32(firstpartlatitude)}.{Convert.ToInt32(secondpartlatitude)},{Convert.ToInt32(firstpartlongitude)}.{Convert.ToInt32(secondpartlongitude)}",
                    UseShellExecute = true
                });
            }
            else if (firstind != -1 && secondind == -1)
            {
                string firstpartlatitude = latitude.Substring(0, firstind);
                string secondpartlatitude = latitude.Substring(firstind + 1);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"https://www.google.com/maps?q={Convert.ToInt32(firstpartlatitude)}.{Convert.ToInt32(secondpartlatitude)},{Convert.ToInt32(longitude)}.0",
                    UseShellExecute = true
                });
            }
            else if (firstind == -1 && secondind != -1)
            {
                string firstpartlongitude = longitude.Substring(0, secondind);
                string secondpartlongitude = longitude.Substring(secondind + 1);


                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"https://www.google.com/maps?q={Convert.ToInt32(latitude)}.0,{Convert.ToInt32(firstpartlongitude)}.{Convert.ToInt32(secondpartlongitude)}",
                    UseShellExecute = true
                });
            }
            else
            {

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"https://www.google.com/maps?q={Convert.ToInt32(latitude)}.0,{Convert.ToInt32(longitude)}.0",
                    UseShellExecute = true
                });
            }
        }
    }
}
