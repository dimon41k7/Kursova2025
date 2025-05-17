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
        private Form mainForm;
        public FormFilter(ListGeoObjects list, Favorites listf, Form mainForm)
        {
            listGeoObjects = list;
            listFavoritesObjects = listf;
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (mainForm is MainForm main)
            {
                string selected = main.SelectedMorKm;

                //if (selected == "Милі")
                //    //main.RefreshListInMile();
                //else
                //    //main.RefreshList();
            }
            //((MainForm)mainForm).RefreshList();
            mainForm.Show();
            this.Close();
        }
    }
}
