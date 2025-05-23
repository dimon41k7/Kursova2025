using System.Windows.Forms;
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
            listBoxGeoObjects.Items.Add("̳���");
            listBoxGeoObjects.Items.Add("�����");
            listBoxGeoObjects.Items.Add("�����");
            listBoxGeoObjects.Items.Add("���������");
            comboBoxArea.Items.Add("ʳ�������");
            comboBoxArea.Items.Add("���");
            comboBoxArea.SelectedIndex = 0;
        }

        private void ������_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjects.SelectedItem;
            if (selectedItem == "̳���")
            {
                AddCityForm addForm = new AddCityForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddRegionForm addForm = new AddRegionForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "�����")
            {
                AddCountryForm addForm = new AddCountryForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else if (selectedItem == "���������")
            {
                AddContinentForm addForm = new AddContinentForm(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
                this.Hide();
                addForm.Show();
            }
            else
            {
                MessageBox.Show("���� �� ������ ������ ����, �����, ����� �� ��������� �� ������, �� ��� ������� ������ � ������, �� �� ������ ������!");
            }
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ ������ � ������!");
                return;
            }
            string selected = comboBoxArea.SelectedItem.ToString();
            string line = selectedItem.ToString();

            listFavoritesObjects.AddToFavorites(line, selected);

            if (selected == "���")
            {
                listFavoritesObjects.RefreshListInMile(listBoxFavorites);
            }
            else if (selected == "ʳ�������")
            {
                listFavoritesObjects.RefreshList(listBoxFavorites);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            listGeoObjects.SaveData("objects.txt");
            listFavoritesObjects.SaveData("favoritesobjects.txt");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            listGeoObjects.LoadData();
            listFavoritesObjects.LoadData();
            string selected = comboBoxArea.SelectedItem.ToString();
            if (selected == "���")
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

        private void buttonShowObject_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ �������� �� ���");
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
                MessageBox.Show("������ ���� ���� �������, ���� �� ������ �������� �� ���");
                return;
            }
            string[] arrword = selectedItem.ToString().Split('|');
            GeoObject.ShowInMap(arrword);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxGeoObjectsAll.SelectedItem;
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ ��������");
                return;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem == null)
            {
                var result = MessageBox.Show("�� ����� ������ ��������?", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        listGeoObjects.RemoveGeoObject(listBoxGeoObjectsAll.SelectedIndex);
                        string selected = comboBoxArea.SelectedItem.ToString();

                        if (selected == "���")
                        {
                            listGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
                        }
                        else if (selected == "ʳ�������")
                        {
                            listGeoObjects.RefreshList(listBoxGeoObjectsAll);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem != null)
            {
                var result = MessageBox.Show("�� ����� ������ ��������?", "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        listFavoritesObjects.RemoveFavorite(listBoxFavorites.SelectedIndex);
                        string selected = comboBoxArea.SelectedItem.ToString();

                        if (selected == "���")
                        {
                            listFavoritesObjects.RefreshListInMile(listBoxFavorites);
                        }
                        else if (selected == "ʳ�������")
                        {
                            listFavoritesObjects.RefreshList(listBoxFavorites);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("������ ���� ���� �������, ���� �� ������ ��������");
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


        private void listBoxGeoObjectsAll_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxGeoObjectsAll.SelectedItem != null)
            {
                ListGeoObjects listShow = new ListGeoObjects();
                listShow.SearchObj(listBoxGeoObjectsAll.SelectedIndex, listGeoObjects);
                string selected = comboBoxArea.SelectedItem.ToString();
                FormShowObj filterForm;
                if (selected == "���")
                {
                    filterForm = new FormShowObj(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this, listShow, true);
                }
                else
                {
                    filterForm = new FormShowObj(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this, listShow);
                }
                this.Hide();
                filterForm.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("�� ������ �������� ���?", "", MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    listGeoObjects.SaveData("objects.txt");
                    listFavoritesObjects.SaveData("favoritesobjects.txt");
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

            if (selected == "���")
            {
                listGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
                listFavoritesObjects.RefreshListInMile(listBoxFavorites);
            }
            else if (selected == "ʳ�������")
            {
                listGeoObjects.RefreshList(listBoxGeoObjectsAll);
                listFavoritesObjects.RefreshList(listBoxFavorites);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FormFilter filterForm = new FormFilter(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, this);
            this.Hide();
            filterForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem == null)
            {
                MessageBox.Show("������, ���� ������� �� ������ ������������");
                return;
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem == null)
            {
                int ind = listBoxGeoObjectsAll.SelectedIndex;

                string line = Convert.ToString(listBoxGeoObjectsAll.SelectedItem);
                if (line.StartsWith("̳���|"))
                {
                    FormCityEdit editForm = new FormCityEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, true, this);
                    this.Hide();
                    editForm.Show();
                }
                else if (line.StartsWith("�����|"))
                {
                    FormRegionEdit editForm = new FormRegionEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, true, this);
                    this.Hide();
                    editForm.Show();
                }
                else if (line.StartsWith("�����|"))
                {
                    FormCountryEdit editForm = new FormCountryEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, true, this);
                    this.Hide();
                    editForm.Show();
                }
                else if (line.StartsWith("���������|"))
                {
                    FormContinentEdit editForm = new FormContinentEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, true, this);
                    this.Hide();
                    editForm.Show();
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem == null && listBoxFavorites.SelectedItem != null)
            {
                int ind = listBoxFavorites.SelectedIndex;

                string line = Convert.ToString(listBoxFavorites.SelectedItem);
                if (line.StartsWith("̳���|"))
                {
                    FormCityEdit editForm = new FormCityEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, false, this);
                    this.Hide();
                    editForm.Show();
                }
                else if (line.StartsWith("�����|"))
                {
                    FormRegionEdit editForm = new FormRegionEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, false, this);
                    this.Hide();
                    editForm.Show();
                }
                else if (line.StartsWith("�����|"))
                {
                    FormCountryEdit editForm = new FormCountryEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, false, this);
                    this.Hide();
                    editForm.Show();
                }
                else if (line.StartsWith("���������|"))
                {
                    FormContinentEdit editForm = new FormContinentEdit(listGeoObjects, listFavoritesObjects, listBoxGeoObjectsAll, listBoxFavorites, ind, false, this);
                    this.Hide();
                    editForm.Show();
                }
            }
            else if (listBoxGeoObjectsAll.SelectedItem != null && listBoxFavorites.SelectedItem != null)
            {
                MessageBox.Show("������ ���� ���� �������, ���� �� ������ ������������");
                return;
            }
        }

        private void buttonGetFact_Click(object sender, EventArgs e)
        {
            labelGetFact.Text = GeoObject.InterestingFact();
        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            listGeoObjects.GetTestData();
            string selected = comboBoxArea.SelectedItem.ToString();

            if (selected == "���")
            {
                listGeoObjects.RefreshListInMile(listBoxGeoObjectsAll);
            }
            else if (selected == "ʳ�������")
            {
                listGeoObjects.RefreshList(listBoxGeoObjectsAll);
            }
            buttonGetData.Visible = false;
        }

        public string SelectedMorKm
        {
            get => comboBoxArea.SelectedItem?.ToString();
        }
    }
}
