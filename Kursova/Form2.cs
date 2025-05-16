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
    public partial class AddCityForm : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private Form mainForm;
        public AddCityForm(ListGeoObjects list, Favorites listf, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void Додати_Click(object sender, EventArgs e)
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


            //перевіряємо населення
            int population;
            string populationtext = textBoxPopulation.Text;
            if (!int.TryParse(populationtext, out population) || population < 0 || population > 50000000)
            {
                MessageBox.Show("Некоректне населення! Введіть значення від 0 до 50 000 000.");
                return;
            }

            var city = new City(name, (double.Parse(latitude), double.Parse(longitude)), population);
            listGeoObjects.AddGeoObject(city);
            MessageBox.Show("Місто успішно додалося!");
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (mainForm is MainForm main)
            {
                string selected = main.SelectedMorKm;

                if (selected == "Милі")
                    main.RefreshListInMile();
                else
                    main.RefreshList();
            }
            //((MainForm)mainForm).RefreshList();
            mainForm.Show();
            this.Close();
        }

        //private void AddCityForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var result = MessageBox.Show("Ви хочете зберегти дані?", "", MessageBoxButtons.YesNoCancel);
        //    switch (result)
        //    {
        //        case DialogResult.Yes:
        //            using (StreamWriter writer = new("objects.txt"))
        //            {
        //                foreach (var obj in listGeoObjects)
        //                {
        //                    writer.WriteLine(obj.ToString());
        //                }
        //            }

        //            using (StreamWriter writer = new("favoritesobjects.txt"))
        //            {
        //                foreach (var obj in listFavoritesObjects)
        //                {
        //                    writer.WriteLine(obj.ToString());
        //                }
        //            }
        //            break;
        //        case DialogResult.No:
        //            break;
        //        case DialogResult.Cancel:
        //            e.Cancel = true;
        //            break;
        //    }
        //}
    }
}
