namespace Kursova
{
    public partial class MainForm : Form
    {
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
                AddCityForm addForm = new AddCityForm();
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddRegionForm addForm = new AddRegionForm();
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddCountryForm addForm = new AddCountryForm(); 
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "���������")
            {
                AddContinentForm addForm = new AddContinentForm();
                this.Hide();
                addForm.Show();
            }
            else
            {
                MessageBox.Show("���� �� ������ ������ ����, �����, ����� �� ��������� �� ������, �� ��� ������� ������ � ������, �� �� ������ ������!");
            }
        }
    }
}
