using Kursova.Models;

namespace Kursova
{
    public partial class MainForm : Form
    {
        private ListGeoObjects listGeoObjects = new ListGeoObjects();
        private Favorites listFavoritesObjects = new Favorites();
        private int lastClickedIndexAll = -1;
        private int lastClickedIndexFavorites = -1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxGeoObjects.Items.Add("Місто");
            listBoxGeoObjects.Items.Add("Регіон");
            listBoxGeoObjects.Items.Add("Країна");
            listBoxGeoObjects.Items.Add("Континент");
            comboBoxArea.Items.Add("Кілометри");
            comboBoxArea.Items.Add("Милі");
            comboBoxArea.SelectedIndex = 0;
        }

        private void Додати_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjects.SelectedItem;
            if (selectedItem == "Місто")
            {
                AddCityForm addForm = new AddCityForm(listGeoObjects, listFavoritesObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "Регіон")
            {
                AddRegionForm addForm = new AddRegionForm(listGeoObjects, listFavoritesObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "Країна")
            {
                AddCountryForm addForm = new AddCountryForm(listGeoObjects, listFavoritesObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "Континент")
            {
                AddContinentForm addForm = new AddContinentForm(listGeoObjects, listFavoritesObjects, this);
                this.Hide();
                addForm.Show();
            }
            else
            {
                MessageBox.Show("Якщо ви хочете додати місто, регіон, країну чи континент до списку, то вам потрібно обрати з списку, що ви хочете додати!");
            }
        }

        public void RefreshList()
        {
            listBoxGeoObjectsAll.Items.Clear();
            foreach (var item in listGeoObjects.ShowGeoObjects())
            {
                listBoxGeoObjectsAll.Items.Add(item.ToString());
            }

            listBoxFavorites.Items.Clear();
            foreach (var item in listFavoritesObjects.ShowFavorites())
            {
                listBoxFavorites.Items.Add(item.ToString());
            }
        }

        public void RefreshListInMile()
        {
            listBoxGeoObjectsAll.Items.Clear();
            foreach (var item in listGeoObjects.ShowGeoObjects())
            {
                listBoxGeoObjectsAll.Items.Add(item.ToStringInMile());
            }

            listBoxFavorites.Items.Clear();
            foreach (var item in listFavoritesObjects.ShowFavorites())
            {
                listBoxFavorites.Items.Add(item.ToStringInMile());
            }
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Оберіть, який елемент ви хочете додати в обране!");
                return;
            }
            string selected = comboBoxArea.SelectedItem.ToString();
            string line = selectedItem.ToString();
            if (line.StartsWith("Місто|"))
                listFavoritesObjects.AddFavorite(City.FromString(line));
            else if (line.StartsWith("Регіон|"))
                listFavoritesObjects.AddFavorite(GeoRegion.FromString(line));
            else if (line.StartsWith("Країна|"))
            {
                var obj = Country.FromString(line);
                if (selected == "Милі")
                {
                    obj.Area = obj.Area * 1.60934;
                }
                listFavoritesObjects.AddFavorite(obj);
            }
                
            else if (line.StartsWith("Континент|"))
            {
                var obj = Continent.FromString(line);
                if (selected == "Милі")
                {
                    obj.Area = obj.Area * 1.60934;
                }
                listFavoritesObjects.AddFavorite(Continent.FromString(line));
            } 
            if (selected == "Милі")
            {
                RefreshListInMile();
            }
            else if (selected == "Кілометри")
            {
                RefreshList();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
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
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (!File.Exists("objects.txt") || !File.Exists("favoritesobjects.txt"))
            {
                return;
            }

            using (StreamReader reader = new("objects.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    {
                        if (line.StartsWith("Місто|"))
                            listGeoObjects.AddGeoObject(City.FromString(line));
                        else if (line.StartsWith("Регіон|"))
                            listGeoObjects.AddGeoObject(GeoRegion.FromString(line));
                        else if (line.StartsWith("Країна|"))
                            listGeoObjects.AddGeoObject(Country.FromString(line));
                        else if (line.StartsWith("Континент|"))
                            listGeoObjects.AddGeoObject(Continent.FromString(line));
                    }
                }
            }
            using (StreamReader reader = new("favoritesobjects.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    {
                        if (line.StartsWith("Місто|"))
                            listFavoritesObjects.AddFavorite(City.FromString(line));
                        else if (line.StartsWith("Регіон|"))
                            listFavoritesObjects.AddFavorite(GeoRegion.FromString(line));
                        else if (line.StartsWith("Країна|"))
                            listFavoritesObjects.AddFavorite(Country.FromString(line));
                        else if (line.StartsWith("Континент|"))
                            listFavoritesObjects.AddFavorite(Continent.FromString(line));
                    }
                }

            }
            string selected = comboBoxArea.SelectedItem.ToString();

            if (selected == "Милі")
            {
                RefreshListInMile();
            }
            else if (selected == "Кілометри")
            {
                RefreshList();
            }
        }

        private void buttonShowObject_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("Оберіть, який елемент ви хочете побачити на мапі");
                return;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem == null)
            {
                selectedItem = listBoxGeoObjectsAll.SelectedItem;
            }
            else if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem != null)
            {
                selectedItem = listBoxFavorites.SelectedItem;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("Оберіть лише один елемент, який ви хочете побачити на мапі");
                return;
            }
            string[] arrword = selectedItem.ToString().Split('|');
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("Оберіть, який елемент ви хочете видалити");
                return;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem == null)
            {
                var result = MessageBox.Show("Ви дійсно хочете видалити?", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        listGeoObjects.RemoveGeoObject(listBoxGeoObjectsAll.SelectedIndex);
                        string selected = comboBoxArea.SelectedItem.ToString();

                        if (selected == "Милі")
                        {
                            RefreshListInMile();
                        }
                        else if (selected == "Кілометри")
                        {
                            RefreshList();
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem != null)
            {
                var result = MessageBox.Show("Ви дійсно хочете видалити?", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        listFavoritesObjects.RemoveFavorite(listBoxFavorites.SelectedIndex);
                        string selected = comboBoxArea.SelectedItem.ToString();

                        if (selected == "Милі")
                        {
                            RefreshListInMile();
                        }
                        else if (selected == "Кілометри")
                        {
                            RefreshList();
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("Оберіть лише один елемент, який ви хочете видалити");
                return;
            }
        }

        private void listBoxGeoObjectsAll_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxGeoObjectsAll.IndexFromPoint(e.Location);

            if (index == -1) return;

            if (index == listBoxGeoObjectsAll.SelectedIndex && index == lastClickedIndexAll)
            {
                listBoxGeoObjectsAll.ClearSelected();
                lastClickedIndexAll = -1;
            }
            else
            {
                listBoxGeoObjectsAll.SelectedIndex = index;
                lastClickedIndexAll = index;
            }
        }

        private void listBoxFavorites_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBoxFavorites.IndexFromPoint(e.Location);

            if (index == -1) return;

            if (index == listBoxFavorites.SelectedIndex && index == lastClickedIndexFavorites)
            {
                listBoxFavorites.ClearSelected();
                lastClickedIndexFavorites = -1;
            }
            else
            {
                listBoxFavorites.SelectedIndex = index;
                lastClickedIndexFavorites = index;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxArea.SelectedItem.ToString();

            if (selected == "Милі")
            {
                RefreshListInMile();
            }
            else if (selected == "Кілометри")
            {
                RefreshList();
            }
        }

        public string SelectedMorKm
        {
            get => comboBoxArea.SelectedItem?.ToString();
        }
    }
}
