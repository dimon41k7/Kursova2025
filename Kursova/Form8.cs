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
    public partial class FormRegionEdit : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private ListBox listBoxGeoObjectsAll;
        private ListBox listBoxFavorites;
        private int indelem;
        private bool boollistall;
        private Form mainForm;
        public FormRegionEdit(ListGeoObjects list, Favorites listf, ListBox listBox, ListBox listBox1, int index, bool ifitislistall, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            listBoxGeoObjectsAll = listBox;
            listBoxFavorites = listBox1;
            indelem = index;
            boollistall = ifitislistall;
            this.mainForm = mainForm;
            InitializeComponent();
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
            //перевіряємо iм'я
            string name = textBoxName.Text;
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


            //перевіряємо яка столиця регіону
            string capital = textBoxCapital.Text;
            if (!capital.All(char.IsLetter))
            {
                MessageBox.Show("Назва столиці повинна містити тільки літери.");
                return;
            }
            if (capital.Length == 0 || capital.Length >= 100)
            {
                MessageBox.Show("Некоректна назва столиці! Введіть назву від 1 символу до 100 символів");
                return;
            }

            //перевіряємо яій країні належить
            string country = textBoxCountry.Text;
            if (!country.All(char.IsLetter))
            {
                MessageBox.Show("Назва країни повинна містити тільки літери.");
                return;
            }
            if (country.Length == 0 || country.Length >= 100)
            {
                MessageBox.Show("Некоректна назва країни, якій належить регіон! Введіть назву від 1 символу до 100 символів");
                return;
            }

            //перевіряємо населення
            int population;
            string populationtext = textBoxPopulation.Text;
            if (!int.TryParse(populationtext, out population) || population < 0 || population > 100000000)
            {
                MessageBox.Show("Некоректне населення! Введіть значення від 0 до 100 000 000.");
                return;
            }

            //отримуємо тип
            string selectedType = Convert.ToString(listBoxType.SelectedItem);
            if (selectedType == "")
            {
                MessageBox.Show("Оберіть тип регіону");
                return;
            }

            if (boollistall == true)
            {

                listGeoObjects[indelem] = new GeoRegion(name, (double.Parse(latitude), double.Parse(longitude)), selectedType, country, capital, population);
            }
            else
            {
                listFavoritesObjects[indelem] = new GeoRegion(name, (double.Parse(latitude), double.Parse(longitude)), selectedType, country, capital, population);
            }
            MessageBox.Show("Дані регіону успішно відредаговані");

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

        private void FormRegionEdit_Load(object sender, EventArgs e)
        {
            GeoRegion obj;
            if (boollistall == true)
            {
                obj = GeoRegion.FromString(Convert.ToString(listGeoObjects[indelem]));
            }
            else
            {
                obj = GeoRegion.FromString(Convert.ToString(listFavoritesObjects[indelem]));
            }

            textBoxName.Text = obj.Name;
            textBoxLatitude.Text = Convert.ToString(obj.Coordinates.Latitude);
            textBoxLongitude.Text = Convert.ToString(obj.Coordinates.Longitude);
            textBoxCapital.Text = obj.Capital;
            textBoxCountry.Text = obj.Country;
            textBoxPopulation.Text = Convert.ToString(obj.Population);
            listBoxType.Items.Add("Область");
            listBoxType.Items.Add("Автономна область");
            listBoxType.Items.Add("Край");
            listBoxType.Items.Add("Автономний округ");
            listBoxType.Items.Add("Провінція");
            listBoxType.Items.Add("Штат");
            listBoxType.Items.Add("Земля");
            listBoxType.Items.Add("Департамент");
            listBoxType.Items.Add("Кантон");
            listBoxType.Items.Add("Округ");
            listBoxType.Items.Add("Графство");
            listBoxType.Items.Add("Регіон");
            listBoxType.Items.Add("Територія");
            listBoxType.Items.Add("Муніципалітет");
            listBoxType.Items.Add("Громада");
            listBoxType.Items.Add("Повіт");
            listBoxType.Items.Add("Район");
            listBoxType.Items.Add("Лен");
            listBoxType.Items.Add("Федеральна земля");
            listBoxType.Items.Add("Емірат");
            listBoxType.Items.Add("Префектура");
            listBoxType.Items.Add("Метрополія");
            listBoxType.SelectedItem = obj.Type;
        }
    }
}
