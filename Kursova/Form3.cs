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
    public partial class AddRegionForm : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private Form mainForm;

        public AddRegionForm(ListGeoObjects list, Favorites listf, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void AddRegionForm_Load(object sender, EventArgs e)
        {
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

            var region = new GeoRegion(name, (double.Parse(latitude), double.Parse(longitude)), selectedType, country, capital, population);
            listGeoObjects.AddGeoObject(region);
            MessageBox.Show("Регіон успішно додався!");
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

        //private void AddRegionForm_FormClosing(object sender, FormClosingEventArgs e)
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
