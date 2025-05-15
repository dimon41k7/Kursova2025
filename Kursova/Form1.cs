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
            listBoxGeoObjects.Items.Add("̳���");
            listBoxGeoObjects.Items.Add("�����");
            listBoxGeoObjects.Items.Add("�����");
            listBoxGeoObjects.Items.Add("���������");
        }

        private void ������_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjects.SelectedItem;
            if (selectedItem == "̳���")
            {
                AddCityForm addForm = new AddCityForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddRegionForm addForm = new AddRegionForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddCountryForm addForm = new AddCountryForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "���������")
            {
                AddContinentForm addForm = new AddContinentForm(listGeoObjects, this);
                this.Hide();
                addForm.Show();
            }
            else
            {
                MessageBox.Show("���� �� ������ ������ ����, �����, ����� �� ��������� �� ������, �� ��� ������� ������ � ������, �� �� ������ ������!");
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
