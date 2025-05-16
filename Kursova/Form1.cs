using Kursova.Models;

namespace Kursova
{
    public partial class MainForm : Form
    {
        private ListGeoObjects listGeoObjects = new ListGeoObjects();
        private Favorites listFavoritesObjects = new Favorites();
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
        }

        private void Додати_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjects.SelectedItem;
            if (selectedItem == "Місто")
            {
                AddCityForm addForm = new AddCityForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "Регіон")
            {
                AddRegionForm addForm = new AddRegionForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "Країна")
            {
                AddCountryForm addForm = new AddCountryForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "Континент")
            {
                AddContinentForm addForm = new AddContinentForm(listGeoObjects, this);
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

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Оберіть, який елемент ви хочете додати в обране!");
                return;
            }
            string line = selectedItem.ToString();
            if (line.StartsWith("Місто|"))
                listFavoritesObjects.AddFavorite(City.FromString(line));
            else if (line.StartsWith("Регіон|"))
                listFavoritesObjects.AddFavorite(GeoRegion.FromString(line));
            else if (line.StartsWith("Країна|"))
                listFavoritesObjects.AddFavorite(Country.FromString(line));
            else if (line.StartsWith("Континент|"))
                listFavoritesObjects.AddFavorite(Continent.FromString(line));

            RefreshList();
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
            RefreshList();
        }
    }
}
