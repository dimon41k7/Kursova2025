using System;
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
    public partial class FormCityEdit : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private ListBox listBoxGeoObjectsAll;
        private ListBox listBoxFavorites;
        private int indelem;
        private bool boollistall;
        private Form mainForm;
        public FormCityEdit(ListGeoObjects list, Favorites listf, ListBox listBox, ListBox listBox1, int index, bool ifitislistall, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            listBoxGeoObjectsAll = listBox;
            listBoxFavorites = listBox1;
            indelem = index;
            boollistall = ifitislistall;
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
            //((MainForm)mainForm).RefreshList();
            mainForm.Show();
            this.Close();
        }

        private void Редагувати_Click(object sender, EventArgs e)
        {

            City obj;
            if (boollistall == true)
            {
                obj = City.FromString(Convert.ToString(listGeoObjects[indelem]));
            }
            else
            {
                obj = City.FromString(Convert.ToString(listFavoritesObjects[indelem]));
            }

            //перевіряємо iм'я
            string name = textBoxName.Text.Replace(" ", "");
            if (!name.All(char.IsLetter))
            {
                MessageBox.Show("Назва повинна містити тільки літери.");
                return;
            }
            if (name.Length == 0 || name.Length >= 100)
            {
                MessageBox.Show("Некоректна назва! Введіть назву від 1 символу до 100 символів");
                return;
            }
            name = textBoxName.Text;

            //перевіряємо широту та довготу
            string latitude = textBoxLatitude.Text;
            string longitude = textBoxLongitude.Text;

            int ind = latitude.IndexOf(".");
            if (ind != -1)
            {
                latitude = (latitude.Substring(0, ind) + "," + latitude.Substring(ind + 1));
            }

            ind = longitude.IndexOf(".");
            if (ind != -1)
            {
                longitude = longitude.Substring(0, ind) + "," + longitude.Substring(ind + 1);
            }

            double latdouble, londouble;
            if (!double.TryParse(latitude, out latdouble) || latdouble < -90 || latdouble > 90)
            {
                MessageBox.Show("Некоректна широта! Введіть значення від -90 до 90.");
                return;
            }

            if (!double.TryParse(longitude, out londouble) || londouble < -180 || londouble > 180)
            {
                MessageBox.Show("Некоректна довгота! Введіть значення від -180 до 180.");
                return;
            }


            //перевіряємо населення
            int population;
            string populationtext = textBoxPopulation.Text;
            if (!int.TryParse(populationtext, out population) || population < 0 || population > 50000000)
            {
                MessageBox.Show("Некоректне населення! Введіть значення від 0 до 50 000 000.");
                return;
            }
            if (boollistall == true)
            {

                listGeoObjects[indelem] = new City(name, (double.Parse(latitude), double.Parse(longitude)), population);
                for(int i = 0; i < listFavoritesObjects.Count; i++)
                {
                    if (listFavoritesObjects[i] is City currentCity &&
                    listFavoritesObjects[i].Name == obj.Name &&
                    listFavoritesObjects[i].Coordinates.Latitude == obj.Coordinates.Latitude &&
                    listFavoritesObjects[i].Coordinates.Longitude == obj.Coordinates.Longitude &&
                    currentCity.Population == obj.Population)
                    {
                        listFavoritesObjects[i] = new City(name, (double.Parse(latitude), double.Parse(longitude)), population);
                        break;
                    }
                }
            }
            else
            {
                listFavoritesObjects[indelem] = new City(name, (double.Parse(latitude), double.Parse(longitude)), population);
                for (int i = 0; i < listGeoObjects.Count; i++)
                {
                    if (listGeoObjects[i] is City currentCity &&
                    listGeoObjects[i].Name == obj.Name &&
                    listGeoObjects[i].Coordinates.Latitude == obj.Coordinates.Latitude &&
                    listGeoObjects[i].Coordinates.Longitude == obj.Coordinates.Longitude &&
                    currentCity.Population == obj.Population)
                    {
                        listGeoObjects[i] = new City(name, (double.Parse(latitude), double.Parse(longitude)), population);
                        break;
                    }
                }
            }
            MessageBox.Show("Дані міста успішно відредаговані");

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
            //((MainForm)mainForm).RefreshList();
            mainForm.Show();
            this.Close();

        }

        private void FormCityEdit_Load(object sender, EventArgs e)
        {
            City obj;
            if (boollistall == true)
            {
                obj = City.FromString(Convert.ToString(listGeoObjects[indelem]));
            }
            else
            {
                obj = City.FromString(Convert.ToString(listFavoritesObjects[indelem]));
            }

            textBoxName.Text = obj.Name;
            textBoxLatitude.Text = Convert.ToString(obj.Coordinates.Latitude);
            textBoxLongitude.Text = Convert.ToString(obj.Coordinates.Longitude);
            textBoxPopulation.Text = Convert.ToString(obj.Population);
        }
    }
}
