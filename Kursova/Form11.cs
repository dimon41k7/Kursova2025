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
    public partial class FormShowObj : Form
    {
        private ListGeoObjects listGeoObjects;
        private Favorites listFavoritesObjects = new Favorites();
        private ListBox listBoxGeoObjectsAll;
        private ListBox listBoxFavorites;
        private Form mainForm;
        private ListGeoObjects listShow;
        public FormShowObj(ListGeoObjects list, Favorites listf, ListBox listBox, ListBox listBox1, Form mainForm, ListGeoObjects listShow)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            listBoxGeoObjectsAll = listBox;
            listBoxFavorites = listBox1;
            this.mainForm = mainForm;
            this.listShow = listShow;
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

        private void FormShowObj_Load(object sender, EventArgs e)
        {
            listShow.RefreshList(listBoxShowObject);
        }
    }
}
