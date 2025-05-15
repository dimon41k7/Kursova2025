using Kursova.Models;

namespace Kursova
{
    public partial class MainForm : Form
    {
        private ListGeoObjects listGeoObjects = new ListGeoObjects();
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
        }

    }
}
