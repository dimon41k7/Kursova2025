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
    public partial class AddCountryForm : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private ListBox listBoxGeoObjectsAll;
        private ListBox listBoxFavorites;
        private Form mainForm;
        public AddCountryForm(ListGeoObjects list, Favorites listf, ListBox listBox, ListBox listBox1, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            listBoxGeoObjectsAll = listBox;
            listBoxFavorites = listBox1;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void AddCountryForm_Load(object sender, EventArgs e)
        {
            listBoxGovernmentType.Items.Add("Абсолютна монархія");
            listBoxGovernmentType.Items.Add("Конституційна монархія");
            listBoxGovernmentType.Items.Add("Парламентська монархія");
            listBoxGovernmentType.Items.Add("Президентська республіка");
            listBoxGovernmentType.Items.Add("Парламентська республіка");
            listBoxGovernmentType.Items.Add("Змішана республіка");
            listBoxGovernmentType.Items.Add("Теократія");
            listBoxGovernmentType.Items.Add("Федеративна держава");
            listBoxGovernmentType.Items.Add("Унітарна держава");
            listBoxGovernmentType.Items.Add("Воєнна диктатура");
            listBoxGovernmentType.Items.Add("Однопартійна система");
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
            if (!double.TryParse(areastr, out area) || area < 0 || area > 20000000)
            {
                MessageBox.Show("Невірна площа! Оберіть значення від 0.5 до 20000000 км");
                return;
            }

            //перевіряємо яка столиця країни
            string capital = textBoxCapital.Text.Replace(" ", "");
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
            capital = textBoxCapital.Text;

            //перевіряємо населення
            int population;
            string populationtext = textBoxPopulation.Text;
            if (!int.TryParse(populationtext, out population) || population < 0 || population > 1500000000)
            {
                MessageBox.Show("Некоректне населення! Введіть значення від 0 до 1 500 000 000.");
                return;
            }

            //отримуємо тип
            string selectedGovernmentType = Convert.ToString(listBoxGovernmentType.SelectedItem);
            if (selectedGovernmentType == "")
            {
                MessageBox.Show("Оберіть форму державного правління країни");
                return;
            }

            var country = new Country(name, (double.Parse(latitude), double.Parse(longitude)), area, population, selectedGovernmentType, capital);
            listGeoObjects.AddGeoObject(country);

            MessageBox.Show("Країна успішно додалася!");
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

        //private void AddCountryForm_FormClosing(object sender, FormClosingEventArgs e)
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
