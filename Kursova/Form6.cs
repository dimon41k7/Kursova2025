using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursova.Models;

namespace Kursova
{
    public partial class FormFilter : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private ListBox listBoxGeoObjectsAll;
        private ListBox listBoxFavorites;
        private ListGeoObjects filterlistGeoObjects = new ListGeoObjects();
        private Favorites filterlistFavoritesObjects = new Favorites();
        private Form mainForm;
        public FormFilter(ListGeoObjects list, Favorites listf, ListBox listBox, ListBox listBox1, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            listBoxGeoObjectsAll = listBox;
            listBoxFavorites = listBox1;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (mainForm is MainForm main)
            {
                string selected = main.SelectedMorKm;

                if (selected == "Милі")
                {
                    listGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
                    listFavoritesObjects.RefreshListInMile(listBoxFavorites);
                }
                else
                {
                    listGeoObjects.RefreshList(listBoxGeoObjectsAll);
                    listFavoritesObjects.RefreshList(listBoxFavorites);
                }
            }
            mainForm.Show();
            this.Close();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            //перевіряємо iм'я
            string name = textBoxNameFilter.Text;
            if (name != "")
            {
                if (!name.All(char.IsLetter))
                {
                    MessageBox.Show("Назва повинна містити тільки літери.");
                    return;
                }
                if ( name.Length >= 100)
                {
                    MessageBox.Show("Некоректна назва! Введіть назву до 100 символів");
                    return;
                }
            }
            

            //перевіряємо широту та довготу
            string latitudemin = textBoxLatitudeMin.Text;
            string latitudemax = textBoxLatitudeMax.Text;
            string longitudemin = textBoxLongitudeMin.Text;
            string longitudemax = textBoxLongitudeMax.Text;

            if (latitudemin != "")
            {
                int ind = latitudemin.IndexOf(".");
                if (ind != -1)
                {
                    latitudemin = (latitudemin.Substring(0, ind) + "," + latitudemin.Substring(ind + 1));
                }
            }
            else
            {
                latitudemin = "-90";
            }
            if (latitudemax != "")
            {
                int ind = latitudemax.IndexOf(".");
                if (ind != -1)
                {
                    latitudemax = (latitudemax.Substring(0, ind) + "," + latitudemax.Substring(ind + 1));
                }
            }
            else
            {
                latitudemax = "90";
            }
            if (longitudemin != "")
            {
                int ind = longitudemin.IndexOf(".");
                if (ind != -1)
                {
                    longitudemin = longitudemin.Substring(0, ind) + "," + longitudemin.Substring(ind + 1);
                }
            }
            else
            {
                longitudemin = "-180";
            }
            if (longitudemax != "")
            {
                int ind = longitudemax.IndexOf(".");
                if (ind != -1)
                {
                    longitudemax = longitudemax.Substring(0, ind) + "," + longitudemax.Substring(ind + 1);
                }
            }
            else
            {
                longitudemax = "180";
            }


            double minlatdouble, maxlatdouble, minlondouble, maxlondouble;
            if (!double.TryParse(latitudemin, out minlatdouble) || minlatdouble < -90 || minlatdouble > 90)
            {
                MessageBox.Show("Невірне мінімальне значення широти! Введіть значення від -90 до 90.");
                return;
            }

            if (!double.TryParse(latitudemax, out maxlatdouble) || maxlatdouble < -90 || maxlatdouble > 90)
            {
                MessageBox.Show("Некоректне максимальне значення широти! Введіть значення від -90 до 90.");
                return;
            }

            if (!double.TryParse(longitudemin, out minlondouble) || minlondouble < -180 || minlondouble > 180)
            {
                MessageBox.Show("Некоректне мінімальне значення довготи! Введіть значення від -180 до 180.");
                return;
            }

            if (!double.TryParse(longitudemax, out maxlondouble) || maxlondouble < -180 || maxlondouble > 180)
            {
                MessageBox.Show("Некоректне максимальне значення довготи! Введіть значення від -180 до 180.");
                return;
            }

            if (minlatdouble > maxlatdouble)
            {
                MessageBox.Show("Некоректні значення широти! Мінімальне значення не може бути більше за максимальне");
                return;
            }

            if (minlondouble > maxlondouble)
            {
                MessageBox.Show("Некоректні значення Широти! Мінімальне значення не може бути більше за максимальне");
                return;
            }
            filterlistGeoObjects.Filter(listGeoObjects, name, minlatdouble, maxlatdouble, minlondouble, maxlondouble);
            filterlistFavoritesObjects.Filter(listFavoritesObjects, name, minlatdouble, maxlatdouble, minlondouble, maxlondouble);
            if (mainForm is MainForm main)
            {
                string selected = main.SelectedMorKm;

                if (selected == "Милі")
                {
                    filterlistGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
                    filterlistFavoritesObjects.RefreshListInMile(listBoxFavorites);
                }
                else
                {
                    filterlistGeoObjects.RefreshList(listBoxGeoObjectsAll);
                    filterlistFavoritesObjects.RefreshList(listBoxFavorites);
                }
            }
            mainForm.Show();
            this.Close();
        }
    }
}
