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
using Kursova.Services;

namespace Kursova
{
    public partial class AddContinentForm : Form
    {
        private ListGeoObjects listGeoObjects;
        private ListGeoObjects listFavoritesObjects = new ListGeoObjects();
        private ListBox listBoxGeoObjectsAll;
        private ListBox listBoxFavorites;
        private Form mainForm;
        private bool closeByBackButton = false;

        public AddContinentForm(ListGeoObjects list, ListGeoObjects listf, ListBox listBox, ListBox listBox1, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            listBoxGeoObjectsAll = listBox;
            listBoxFavorites = listBox1;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Додати_Click(object sender, EventArgs e)
        {
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


            //перевіряємо площу
            string areastr = textBoxArea.Text;
            int ind1 = areastr.IndexOf(".");
            if (ind1 != -1)
            {
                areastr = (areastr.Substring(0, ind1) + "," + areastr.Substring(ind1 + 1));
            }
            double area;
            if (!double.TryParse(areastr, out area) || area < 0 || area > 44580000)
            {
                MessageBox.Show("Невірна площа! Оберіть значення від 0.5 до 44 580 000 км");
                return;
            }

            //перевіряємо населення
            int population;
            string populationtext = textBoxPopulation.Text;
            if (!int.TryParse(populationtext, out population) || population < 0 || population > 4700000000)
            {
                MessageBox.Show("Некоректне населення! Введіть значення від 0 до 4 700 000 000.");
                return;
            }

            var continent = new Continent(name, (double.Parse(latitude), double.Parse(longitude)), area, population);
            listGeoObjects.AddGeoObject(continent);
            MessageBox.Show("Континент успішно додався!");

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            closeByBackButton = true;
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

        private void AddContinentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeByBackButton == false)
            {
                var result = MessageBox.Show("Ви хочете зберегти дані?", "", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        using (StreamWriter writer = new("objects.txt"))
                        {
                            foreach (var obj in listGeoObjects)
                            {
                                writer.WriteLine(obj.ToString());
                            }
                        }

                        using (StreamWriter writer = new("favoritesobjects.txt"))
                        {
                            foreach (var obj in listFavoritesObjects)
                            {
                                writer.WriteLine(obj.ToString());
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
